using System;

namespace WordCounter
{
  public class WordCounter
  //RepeatCounter class
  {
    public int CountWordsTest(string Word, string[] InputStringArray)
    {
      int WordCounter=0;
      string LowerCaseWord = Word.ToLower();

      if(Word !=  "")
      {
        for(var i=0; i < InputStringArray.Length; i++)
        {
          string LowerCaseStringArray = InputStringArray[i].ToLower();
          if(LowerCaseStringArray.Contains(LowerCaseWord))
          {
            if(LowerCaseStringArray==LowerCaseWord)
            {
              WordCounter++;
            }
          }
        }
        return WordCounter;
      } else {
        return WordCounter;
      }
    }
  }
}
