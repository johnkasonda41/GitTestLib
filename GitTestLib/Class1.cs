using System;

namespace GitTestLib
{
    public class Class1
    {
        public void Print(String input)
        {
            Utility.Print(input);
        }
    }

    public static class Utility {
        public static void Print(string input) 
        {
            Console.WriteLine(input);
        }
    }

}
