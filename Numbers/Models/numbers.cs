using System;
using System.Collections.Generic;

namespace NumbersToWords
  {
  public class Conversion
    {
      public string result;
      public int quotient;
      public int remainder;
      public int quotient1;
      public int remainder1;
      public string finalResult;
      Dictionary<int, string> ones = new Dictionary<int, string>()
      {
        {0, ""},
        {1,"one"},
        {2,"two"},
        {3,"three"},
        {4,"four"},
        {5,"five"},
        {6,"six"},
        {7,"seven"},
        {8,"eight"},
        {9,"nine"}
      };
      Dictionary<int, string> tens = new Dictionary<int, string>()
      {
        {0, ""},
        {1,"ten"},
        {2,"twenty"},
        {3,"thirty"},
        {4,"fourty"},
        {5,"fifty"},
        {6,"sixty"},
        {7,"seventy"},
        {8,"eighty"},
        {9,"ninety"}
      };

      public string calculate(int number)
      //Tens
      {
        quotient = number / 10;
        remainder = number % 10;
        foreach(KeyValuePair<int, string> entry in tens)
        {
          if (quotient == entry.Key)
          {
            result = entry.Value;
          }
        }
      //One
        quotient1 = remainder / 1;
        remainder1 = remainder % 1;
        foreach(KeyValuePair<int, string> entry in ones)
        {
          if (quotient1 == entry.Key)
          {
            finalResult = entry.Value;
            finalResult = result + " " + finalResult;
          }
        }

        return finalResult;
    }
  }
}
