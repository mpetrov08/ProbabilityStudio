using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityStudio.Models
{
    public interface IExperiment
    {
        decimal CalculateProbability(int trialCount);

        SimulationResult Simulate(int trialCount);
    }
}
