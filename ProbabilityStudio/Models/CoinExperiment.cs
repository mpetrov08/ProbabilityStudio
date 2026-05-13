using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityStudio.Models
{
    public class CoinExperiment : IExperiment
    {
        public CoinExperiment(string searchedSide)
        {
            SearchedSide = searchedSide;
        }

        public string SearchedSide { get; set; }

        public decimal CalculateProbability(int trialCount)
        {
            throw new NotImplementedException();
        }

        public SimulationResult Simulate(int trialCount)
        {
            throw new NotImplementedException();
        }
    }
}
