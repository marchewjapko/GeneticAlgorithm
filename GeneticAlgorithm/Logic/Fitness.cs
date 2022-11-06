using GeneticAlgorithm.Logic.Entities;

namespace GeneticAlgorithm.Logic
{
    public static class Fitness
    {
        public static double GetFitness(int value)
        {
            return -0.4 * value * value + 9 * value + 11;
        }
    }
}
