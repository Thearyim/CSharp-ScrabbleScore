namespace ScrabbleScore.Tests
{
    [TestClass]
    public class ScrabbleScoreTest
    {
      
        [TestMethod]
        public void GetScrabbleScore_WordWithLetterB_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore(B);
          Assert.AreEqual(1, result);
        }
    }
}
