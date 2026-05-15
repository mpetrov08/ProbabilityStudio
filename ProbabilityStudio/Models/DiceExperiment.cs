using ProbabilityStudio.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityStudio.Models
{
    public class DiceExperiment : IExperiment
    {
        public DiceExperiment(DiceSearchType searchType, int searchedValue, int trialCount)
        {
            SearchType = searchType;
            SearchedValue = searchedValue;
            TrialCount = trialCount;
        }

        public DiceSearchType SearchType { get; set; }

        public int SearchedValue { get; set; }

        public int TrialCount { get; set; }

        public double CalculateProbability()
        {
            if (SearchType == DiceSearchType.ExactValue)
            {
                return Math.Pow(1.0 / 6.0, TrialCount);
            }
            else
            {
                int successfullCases = CountWays(TrialCount, 0, SearchedValue);
                int totalCases = (int)Math.Pow(6, TrialCount);

                return (double)successfullCases / totalCases;
            }
        }

        public SimulationResult Simulate()
        {
            int successCount = 0;

            Random rnd = new Random();
            if (SearchType == DiceSearchType.ExactValue)
            {
                for (int i = 0; i < 100_000; i++)
                {
                    bool isSuccessed = true;
                    for (int j = 0; j < TrialCount; j++)
                    {
                        int result = rnd.Next(1, 7);
                        if (result != SearchedValue)
                        {
                            isSuccessed = false;
                            break;
                        }
                    }

                    if (isSuccessed)
                    {
                        successCount++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 100_000; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < TrialCount; j++)
                    {
                        sum += rnd.Next(1, 7);
                    }

                    if (sum == SearchedValue)
                    {
                        successCount++;
                    }
                }
            }

            return new SimulationResult(100_000, successCount);
        }

        private int CountWays(int diceLeft, int currentSum, int targetSum)
        {
            if (diceLeft == 0)
            {
                return currentSum == targetSum ? 1 : 0;
            }

            int count = 0;

            for (int face = 1; face <= 6; face++)
            {
                count += CountWays(diceLeft - 1, currentSum + face, targetSum);
            }

            return count;
        }
    }
}
