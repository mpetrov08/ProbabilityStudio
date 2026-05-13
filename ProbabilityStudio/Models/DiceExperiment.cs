using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityStudio.Models
{
    public class DiceExperiment : IExperiment
    {
        public DiceExperiment(int searchedValue)
        {
            SearchedValue = searchedValue;
        }

        public int SearchedValue { get; set; }

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
