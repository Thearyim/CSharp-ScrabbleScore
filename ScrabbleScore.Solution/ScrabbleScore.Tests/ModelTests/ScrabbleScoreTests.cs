using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore;

namespace ScrabbleScore.Tests
{
    [TestClass]
    public class ScrabbleScoreTest
    {

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterA_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("A");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterE_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("E");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterI_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("I");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterO_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("O");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterU_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("U");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterL_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("L");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterN_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("N");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterR_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("R");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterS_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("S");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterT_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("T");
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterD_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("D");
        Assert.AreEqual(2, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterG_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("G");
        Assert.AreEqual(2, result);
      }

      [TestMethod]
      public void GetScrabbleScore_WordWithLetterB_True()
      {
        ScrabbleScore testScrabbleScore = new ScrabbleScore();
        int result = testScrabbleScore.GetScrabbleScore("B");
        Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterC_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("C");
          Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterM_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("M");
          Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterP_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("P");
          Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterF_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("F");
          Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterH_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("H");
          Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterV_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("V");
          Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterW_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("W");
          Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterY_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("Y");
          Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterK_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("K");
          Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterJ_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("J");
          Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterX_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("X");
          Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterQ_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("Q");
          Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void GetScrabbleScore_WordWithLetterZ_True()
        {
          ScrabbleScore testScrabbleScore = new ScrabbleScore();
          int result = testScrabbleScore.GetScrabbleScore("Z");
          Assert.AreEqual(10, result);
        }
    }
}
