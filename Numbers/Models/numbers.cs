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
      public int quotient2;
      public int remainder2;
      public string result2;

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
        {2,"twenty "},
        {3,"thirty "},
        {4,"fourty "},
        {5,"fifty "},
        {6,"sixty "},
        {7,"seventy "},
        {8,"eighty "},
        {9,"ninety "}
      };
      Dictionary<int, string> teens = new Dictionary<int, string>()
      {
        {11,"eleven"},
        {12,"twelve"},
        {13,"thirteen"},
        {14,"fourteen"},
        {15,"fifteen"},
        {16,"sixteen"},
        {17,"seventeen"},
        {18,"eighteen"},
        {19,"nineteen"}
      };
      Dictionary<int, string> hundreds = new Dictionary<int, string>()
      {
        {0, ""},
        {1,"one hundred "},
        {2,"two hundred "},
        {3,"three hundred "},
        {4,"four hundred "},
        {5,"five hundred "},
        {6,"six hundred "},
        {7,"seven hundred "},
        {8,"eight hundred "},
        {9,"nine hundred "}
      };



      public string calculate(int number)
      {
      //Hundreds
      quotient2 = number / 100;
      remainder2 = number % 100;

        //if (hundreds.ContainsKey(quotient2))

           result2 = hundreds[quotient2];


      //Tens

        string teenResult = teenCheck(remainder2);
        if (teenResult != remainder2.ToString())
        {
          return teenResult;
        }

        quotient = remainder2 / 10;
        remainder = remainder2 % 10;


         if (tens.ContainsKey(quotient))
          {
           result = result2 + tens[quotient];
          }

      //One
        quotient1 = remainder / 1;
        remainder1 = remainder % 1;


          if (ones.ContainsKey(quotient1))
          {
            finalResult = ones[quotient1];
            finalResult = result + finalResult;
          }


        return finalResult;
    }
    public string teenCheck(int number)
    {


       if (teens.ContainsKey(number))
          {
           return result2 + teens[number];
          }

      return number.ToString();
    }
  }
  public class MainCalculation
  {
   public static void Main()
    {
      Console.WriteLine("Enter a number to translate into text!");
      string userInput = Console.ReadLine();
      int integerNumber=int.Parse(userInput);
      Conversion integer = new Conversion();
      Console.WriteLine(integer.calculate(integerNumber));
    }
  }
}
