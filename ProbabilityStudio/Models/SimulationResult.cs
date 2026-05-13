using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityStudio.Models
{
    public class SimulationResult
    {
        public SimulationResult(int trialCount, int successfulTrials)
        {
            TrialCount = trialCount;
            SuccessfulTrials = successfulTrials;
        }

        public int TrialCount { get; set; }

        public int SuccessfulTrials { get; set; }
    }
}
