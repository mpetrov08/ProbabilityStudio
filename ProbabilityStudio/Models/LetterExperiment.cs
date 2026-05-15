using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityStudio.Models
{
    public class LetterExperiment : IExperiment
    {
        public LetterExperiment(string text, char searchedLetter, int trialCount, bool isCaseSensitive, bool isIncludedPunctuationAndSpaces)
        {
            Text = text;
            SearchedLetter = searchedLetter;
            TrialCount = trialCount;
            IsCaseSensitive = isCaseSensitive;
            IsIncludedPunctuationAndSpaces = isIncludedPunctuationAndSpaces;

            ProcessText();
        }

        public string Text { get; set; }

        public char SearchedLetter { get; set; }

        public int TrialCount { get; set; }

        public bool IsCaseSensitive { get; set; } 

        public bool IsIncludedPunctuationAndSpaces { get; set; }

        public double CalculateProbability()
        {
            int letterCount = Text.Count(c => c == SearchedLetter);

            return Math.Pow(letterCount / (double)Text.Length, TrialCount);
        }

        public SimulationResult Simulate()
        {
            int successCount = 0;

            Random rnd = new Random();

            for (int i = 0; i < 100_000; i++)
            {
                bool isSuccessfulTrial = true;

                for (int j = 0; j < TrialCount; j++)
                {
                    int randomIndex = rnd.Next(0, Text.Length);
                    char randomLetter = Text[randomIndex];

                    if (randomLetter != SearchedLetter)
                    {
                        isSuccessfulTrial = false;
                        break;
                    }
                }

                if (isSuccessfulTrial)
                {
                    successCount++;
                }
            }

            return new SimulationResult(100_000, successCount);
        }

        private void ProcessText()
        {
            if (!IsCaseSensitive)
            {
                Text = Text.ToLower();
                SearchedLetter = char.ToLower(SearchedLetter);
            }

            if (!IsIncludedPunctuationAndSpaces)
            {
                Text = new string(Text.Where(char.IsLetter).ToArray());
            }
        }
    }
}
