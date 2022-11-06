using OxyPlot.Series;
using OxyPlot;
using GeneticAlgorithm.Logic;
using System.Diagnostics;
using OxyPlot.Legends;
using GeneticAlgorithm.Logic.Operations;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var geneticAlgorithm = new GeneticAlgorithmSolver(int.Parse(this.populationSizeTextBox.Text), int.Parse(this.mutationChanceTextBox.Text), int.Parse(this.iterationsTextBox.Text));
            geneticAlgorithm.Solve();

            var bestIndividual = geneticAlgorithm.GetBestIndividual();
            this.bestIndividualFitnessTextBox.Text = bestIndividual.FitnessValue.ToString();
            this.bestIndividualValueTextBox.Text = bestIndividual.GetDecimalValue().ToString();

            var graphModel = new PlotModel { Title = "Genetic algorithm" };
            graphModel.Series.Add(GetAverageFitness(geneticAlgorithm));
            graphModel.Series.Add(GetMaxFitness(geneticAlgorithm));
            graphModel.Legends.Add(new Legend()
            {
                LegendTitle = "Legend",
                LegendPosition = LegendPosition.RightBottom,
            });
            this.plotView1.Model = graphModel;


            var graphModelFitness = new PlotModel { Title = "Fitness" };
            graphModelFitness.Series.Add(GetFunction());
            graphModelFitness.Series.Add(GetBestIndividual(geneticAlgorithm));
            graphModelFitness.Legends.Add(new Legend()
            {
                LegendTitle = "Legend",
                LegendPosition = LegendPosition.RightBottom,
            });
            this.plotView2.Model = graphModelFitness;
        }

        private FunctionSeries GetFunction()
        {
            var serie = new FunctionSeries();
            serie.Title = "Fitness function";
            for (int x = -2; x < 25; x++)
            {
                DataPoint data = new DataPoint(x, Fitness.GetFitness(x));
                serie.Points.Add(data);
            }
            return serie;
        }

        private FunctionSeries GetAverageFitness(GeneticAlgorithmSolver geneticAlgorithm)
        {
            var serie = new FunctionSeries
            {
                Title = "Average fitness"
            };
            for (int i = 0; i < geneticAlgorithm.populations.Count; i++)
            {
                DataPoint data = new DataPoint(i, PopulationOperations.GetAverageFitness(geneticAlgorithm.populations[i]));
                serie.Points.Add(data);
            }
            return serie;
        }

        private FunctionSeries GetMaxFitness(GeneticAlgorithmSolver geneticAlgorithm)
        {
            var serie = new FunctionSeries
            {
                Title = "Max fitness"
            };
            for (int i = 0; i < geneticAlgorithm.populations.Count; i++)
            {
                DataPoint data = new DataPoint(i, PopulationOperations.GetMaxFitness(geneticAlgorithm.populations[i]));
                serie.Points.Add(data);
            }
            return serie;
        }

        private FunctionSeries GetBestIndividual(GeneticAlgorithmSolver geneticAlgorithm)
        {
            var serie = new FunctionSeries
            {
                Title = "Best individual",
                MarkerType = MarkerType.Circle,
                StrokeThickness = 0,
                MarkerSize = 4

            };
            DataPoint data = new DataPoint(geneticAlgorithm.GetBestIndividual().GetDecimalValue(), Fitness.GetFitness(geneticAlgorithm.GetBestIndividual().GetDecimalValue()));
            serie.Points.Add(data);
            return serie;
        }
    }
}