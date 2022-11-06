namespace GeneticAlgorithm.Logic.Entities
{
    public class Population
    {
        public List<Individual> individuals;
        public Population(List<Individual> _individuals)
        {
            individuals = _individuals;
        }

        public Population(int populationSize)
        {
            individuals = new List<Individual>();
            var random = new Random();
            for (int i = 0; i < populationSize; i++)
            {
                var value = random.Next(-1, 23);
                individuals.Add(new Individual(value));
            }
        }
    }
}
