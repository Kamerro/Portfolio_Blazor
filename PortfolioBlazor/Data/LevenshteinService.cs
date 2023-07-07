
using PortfolioBlazor.Helpers;
namespace L
{
    public class LevenshteinService
    {

        public static List<WordDistance> ComputeAllWords(List<string> listOfWords, string WordToCompute)
        {
            string retword = String.Empty;

            string lowerCaseText = WordToCompute.ToLower();

            var results = listOfWords.Select(word => new WordDistance()
            {
              Word = word,
              Distance=LevenshteinDistance.Compute(lowerCaseText, word)

            }).Where(x=>x.Distance<3).OrderBy(x => x.Distance).ToList();

            //var minLevenshtein = results.First().Distance;
            //retword = results.First().Word;
            return results;
           // return retword;
        }
    }
}
