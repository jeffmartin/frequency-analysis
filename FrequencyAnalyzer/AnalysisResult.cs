using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyAnalyzer
{
    public class AnalysisCharacterResult
    {
        public AnalysisCharacterResult(string character, long numberOfOccurrences, long totalCorpusLength)
        {
            Character = character;
            NumberOfOccurrences = numberOfOccurrences;
            TotalCorpusLength = totalCorpusLength;
        }
        public string Character { get; private set; }
        public double FrequencyPercentage {
            get
            {
                return (double)(NumberOfOccurrences / TotalCorpusLength) * 100;
            }
        }
        public long NumberOfOccurrences { get; private set; }
        public long TotalCorpusLength { get; private set; }
    }

    public class AnalysisResult
    {
        public AnalysisResult()
        {
            CharacterFrequencies = new List<AnalysisCharacterResult>();
        }

        public List<AnalysisCharacterResult> CharacterFrequencies { get; set; }
        public List<AnalysisCharacterResult> MostCommon {
            get
            {
                return CharacterFrequencies.Where(y=>y.NumberOfOccurrences == CharacterFrequencies.Max(x => x.NumberOfOccurrences)).ToList();
            }
        }
        public List<AnalysisCharacterResult> LeastCommon {
            get {
                return CharacterFrequencies.Where(y => y.NumberOfOccurrences == CharacterFrequencies.Min(x => x.NumberOfOccurrences)).ToList();
            }
        }
        public Dictionary<string, long> GetData()
        {
            return CharacterFrequencies.ToDictionary(x => x.Character, x => x.NumberOfOccurrences);
        }
    }
}
