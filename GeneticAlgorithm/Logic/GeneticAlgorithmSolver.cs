using GeneticAlgorithm.Logic.Entities;
using GeneticAlgorithm.Logic.Operations;
using System.Diagnostics;

namespace GeneticAlgorithm.Logic
{
    public class GeneticAlgorithmSolver
    {
        public List<Population> populations;
        private int populationCount;
        private int mutationChance;
        private int maxIterations;
        public GeneticAlgorithmSolver(int _populationCount, int _mutationChance, int _maxIterations)
        {
            populationCount = _populationCount;
            mutationChance = _mutationChance;
            maxIterations = _maxIterations;

            populations = new List<Population>
            {
                new Population(populationCount)
            };
        }

        public void Solve()
        {
            while (populations.Count < maxIterations)
            {
                PopulationOperations.NormalizeFitness(populations[^1]);
                var selectedIndividuals = PopulationOperations.RouletteSelection(populations[^1]);
                var children = new List<Individual>();
                foreach(var pair in selectedIndividuals)
                {
                    var (child1, child2) = IndividualOperations.Crossover(pair.Item1, pair.Item2);
                    children.Add(child1);
                    children.Add(child2);
                }
                foreach (var child in children)
                {
                    IndividualOperations.Mutate(child, mutationChance);
                }
                populations.Add(new Population(children));
            }
            foreach(var population in populations)
            {
                PopulationOperations.DenormalizeFitness(population);
            }
        }

        public Individual GetBestIndividual()
        {
            var x = populations.SelectMany(x => x.individuals);
            foreach(var a in x)
            {
                a.FitnessValue = Fitness.GetFitness(a.GetDecimalValue());
            }
            return x.OrderByDescending(x => x.FitnessValue).First();
        }
    }
}
