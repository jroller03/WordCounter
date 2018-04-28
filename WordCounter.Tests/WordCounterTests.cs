using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  //ReapeatCounter Test class
  {
    [TestMethod]
    public void MatchOneWord_One()
    {
      string Word = "Sally";
      string[] InputStringArray = new string[] {"Sally"};
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(1, testWordCounter.CountWordsTest(Word, InputStringArray));
    }
    [TestMethod]
    public void NoInput_Zero()
    {
      string Word = "";
      string[] InputStringArray = new string[] {""};
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(0, testWordCounter.CountWordsTest(Word, InputStringArray));
    }
    [TestMethod]
    public void PartialMatch_Zero()
    {
      string Word = "b";
      string[] InputStringArray = new string[] {"back"};
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(0, testWordCounter.CountWordsTest(Word, InputStringArray));
    }
    [TestMethod]
    public void NoMatch_Zero()
    {
      string Word = "ball";
      string[] InputStringArray = new string[] {"Practice","makes","perfect"};
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(0, testWordCounter.CountWordsTest(Word, InputStringArray));
    }
    [TestMethod]
    public void WrongInputNumber_Zero()
    {
      string Word = "3";
      string[] InputStringArray = new string[] {"apple"};
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(0, testWordCounter.CountWordsTest(Word, InputStringArray));
    }
    [TestMethod]
    public void MultipleWordMatch_Two()
    {
      string Word = "apple";
      string[] InputStringArray = new string[] {"apple", "bags", "of", "apple"};
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(2, testWordCounter.CountWordsTest(Word, InputStringArray));
    }
  }
}
