using System;

namespace CreatePhoneNumber {
  public class Kata
  {
    //Code for Students to write
    public static string CreatePhoneNumber(int[] numbers)
    {
      string phoneNum = "";
      string par = "(";
      string two = " ";
      int count = 0;
      
      if(numbers.Length != 10)
        return "Error";
      
      foreach(int i in numbers)
      {
        if(count >= 0 && count < 3)
        {
          if(i >= 0 || i < 10)
            par += i.ToString();
          if(count == 2)
            par += ")";
        }
        
        if(count >= 3 && count < 6)
        {
          if(i >= 0 || i < 10)
            two += i.ToString();
          if(count == 5)
            two += "-";
        }
        
        if(count >= 6)
          two += i.ToString();
        
        if(count == 9)
          phoneNum = par + two;
        count++;
      }
    
      return phoneNum;
    }
  
    //Code that tests student's CreatePhoneNumber method
    public static void TestPhoneNumber()
    {
      int[][] phoneNumbers = new int[][]
      {
        new int[] {1,2,3,4,5,6,7,8,9,0},
        new int[] {1,1,1,1,1,1,1,1,1,1},
        new int[] {3, 8, 3, 4, 3, 6, 7, 2, 3, 1},
        new int[] {9, 7, 3, 2, 1, 0, 7, 5, 8, 6}
      };

      string[] phoneNums = 
      {
        "(123) 456-7890",
        "(111) 111-1111",
        "(383) 436-7231",
        "(973) 210-7586"
      };

      string[] yourAnswers = 
      {
        CreatePhoneNumber(phoneNumbers[0]),
        CreatePhoneNumber(phoneNumbers[1]),
        CreatePhoneNumber(phoneNumbers[2]),
        CreatePhoneNumber(phoneNumbers[3])
      };

      int correct = 0;

      for(int i = 0; i < phoneNums.Length; i++)
      {
        int testNum = i + 1;
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($"Test #{testNum}:");
        Console.WriteLine($"Correct Answer: {phoneNums[i]}");
        if(yourAnswers[i] == phoneNums[i])
        {
          Console.ForegroundColor = ConsoleColor.Green;
          correct++;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        Console.WriteLine($"Your Answer: {yourAnswers[i]}");
        Console.ResetColor();
      }

      if(correct == 4)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n>>>>>>>100% Great Job!<<<<<<<");
        Console.ResetColor();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n>>>>>>>Try again<<<<<<<");
        Console.ResetColor();
      }
    }
  }
}

// public class Kata
// {
//   public static string CreatePhoneNumber(int[] numbers)
//   {
//     return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
//   }
// }