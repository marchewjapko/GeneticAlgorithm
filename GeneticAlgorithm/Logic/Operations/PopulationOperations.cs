using GeneticAlgorithm.Logic.Entities;
using System.Diagnostics;

namespace GeneticAlgorithm.Logic.Operations
{
    public static class PopulationOperations
    {
        public static void NormalizeFitness(Population population)
        {
            double totalFitness = 0;
            foreach (var individual in population.individuals)
            {
                totalFitness += Fitness.GetFitness(individual.GetDecimalValue());
            }
            foreach (var individual in population.individuals)
            {
                individual.FitnessValue = Fitness.GetFitness(individual.GetDecimalValue()) / totalFitness;
            }
            double lowestFitness = 0;
            foreach (var individual in population.individuals)
            {
                if (lowestFitness > individual.FitnessValue)
                    lowestFitness = individual.FitnessValue;
            }
            foreach (var individual in population.individuals)
            {
                individual.FitnessValue -= lowestFitness;
            }
        }

        public static void DenormalizeFitness(Population population)
        {
            foreach (var individual in population.individuals)
            {
                individual.FitnessValue = Fitness.GetFitness(individual.GetDecimalValue());
            }
        }

        public static void GetFitness(Population population)
        {
            foreach (var individual in population.individuals)
            {
                individual.FitnessValue = Fitness.GetFitness(individual.GetDecimalValue());
            }
        }

        public static List<(Individual, Individual)> RouletteSelection(Population population)
        {
            population.individuals = population.individuals.OrderByDescending(x => x.FitnessValue).ToList();
            var selectedIndividuals = new List<(Individual, Individual)>();
            var random = new Random();

            string chosenParent1 = "";
            string chosenParent2 = "";
            while (selectedIndividuals.Count < population.individuals.Count / 2)
            {
                double partialFitness = 0;
                double randomValue = random.NextDouble();
                for (int i = 0; i < population.individuals.Count; i++)
                {
                    partialFitness += population.individuals[i].FitnessValue;
                    if (partialFitness > randomValue)
                    {
                        chosenParent1 = population.individuals[i].Id;
                        break;
                    }
                }

                partialFitness = 0;
                randomValue = random.NextDouble() - population.individuals.First(x => x.Id == chosenParent1).FitnessValue;
                for (int i = 0; i < population.individuals.Count; i++)
                {
                    if(population.individuals[i].Id == chosenParent1)
                    {
                        continue;
                    }
                    partialFitness += population.individuals[i].FitnessValue;
                    if (partialFitness > randomValue)
                    {
                        chosenParent2 = population.individuals[i].Id;
                        break;
                    }
                }
                selectedIndividuals.Add((population.individuals.First(x => x.Id == chosenParent1), population.individuals.First(x => x.Id == chosenParent2)));
            }
            return selectedIndividuals;
        }

        public static double GetAverageFitness(Population population)
        {
            return population.individuals.Average(x => x.FitnessValue);
        }

        public static double GetHighestFitness(Population population)
        {
            return population.individuals.Max(x => x.FitnessValue);
        }
    }
}
