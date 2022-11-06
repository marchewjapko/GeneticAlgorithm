using GeneticAlgorithm.Logic.Entities;
using System.Collections;
using System.Text;

namespace GeneticAlgorithm.Logic.Operations
{
    public static class IndividualOperations
    {
        public static (Individual child1, Individual child2) Crossover(Individual individual1, Individual individual2)
        {
            Random random = new Random();
            int crossoverPoint = random.Next(1, 4);
            string childChromosome1 = "";
            string childChromosome2 = "";
            for (int i = 0; i < crossoverPoint; i++)
            {
                childChromosome1 = childChromosome1.Insert(childChromosome1.Length, individual1.Chromosome[i].ToString());
                childChromosome2 = childChromosome2.Insert(childChromosome2.Length, individual2.Chromosome[i].ToString());
            }
            for (int i = crossoverPoint; i < 5; i++)
            {
                childChromosome1 = childChromosome1.Insert(childChromosome1.Length, individual2.Chromosome[i].ToString());
                childChromosome2 = childChromosome2.Insert(childChromosome2.Length, individual1.Chromosome[i].ToString());
            }
            return (new Individual(childChromosome1), new Individual(childChromosome2));
        }

        public static void Mutate(Individual individual, int mutationChance)
        {
            StringBuilder chromosomeResult = new StringBuilder(individual.Chromosome);
            Random random = new Random();
            for (int i = 4; i >= 0; i--)
            {
                int rand = random.Next(0, 100);
                if (rand < mutationChance)
                {
                    chromosomeResult[i] = individual.Chromosome[i] == '0' ? '1' : '0';
                }
            }
            individual.Chromosome = chromosomeResult.ToString();
        }
    }
}
