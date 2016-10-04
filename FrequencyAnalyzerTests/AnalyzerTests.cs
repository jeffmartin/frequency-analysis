using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrequencyAnalyzer;
using System.Linq;

namespace FrequencyAnalyzerTests
{
    [TestClass]
    public class AnalyzerTests
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        [TestMethod]
        public void WhenCorpusIsValid_ShouldReturnFrequencies()
        {
            var analyzer = new Analyzer();
            var result = analyzer.Analyze("The quick brown fox jumps over the lazy dog", alphabet.ToCharArray());
            Assert.AreEqual(result.CharacterFrequencies.Count, alphabet.Length);
            Assert.IsTrue(result.MostCommon.Any(x => x.Character == "o"));
            Assert.IsTrue(result.GetData()["o"] == 4);
        }
    }
}
