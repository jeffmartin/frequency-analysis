using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FrequencyAnalyzer
{
    public class Analyzer
    {
        public AnalysisResult Analyze(string corpus, char[] alphabet)
        {
            var analysisResult = new AnalysisResult();
            foreach (var letter in alphabet)
            {
                var matches = Regex.Matches(corpus, letter.ToString(), RegexOptions.IgnoreCase);
                var characterResult = new AnalysisCharacterResult(letter.ToString(), matches.Count, corpus.Length);
                analysisResult.CharacterFrequencies.Add(characterResult);
            }
            return analysisResult;
        }
    }
}
