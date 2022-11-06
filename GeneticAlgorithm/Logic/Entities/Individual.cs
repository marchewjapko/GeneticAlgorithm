using System;
using System.Collections;
using System.Diagnostics;

namespace GeneticAlgorithm.Logic.Entities
{
    public class Individual
    {
        public string Chromosome { get; set; }
        public double FitnessValue { get; set; }
        public string Id { get; set; }

        public Individual(int value)
        {
            string str = Convert.ToString(value, 2);
            while(str.Length < 5)
            {
                str = str.Insert(0, "0");
            }
            Chromosome = str[^5..];
            this.Id = this.GetType().Name.ToString() + this.GetHashCode().ToString();
        }

        public Individual(string _chromosome)
        {
            Chromosome = _chromosome;
            this.Id = this.GetType().Name.ToString() + this.GetHashCode().ToString();
        }

        public int GetDecimalValue()
        {
            int lol = Convert.ToInt32(Chromosome, 2);
            return Convert.ToInt32(Chromosome, 2);
        }
    }
}
