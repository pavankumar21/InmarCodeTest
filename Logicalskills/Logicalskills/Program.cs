using System;

namespace Logicalskills
{
    class Program
    {
        static void Main(string[] args)
        {
            //FixBuzz logic solution call
            //  FizzBuzz.FizzBuzzDisplayMethod();

            //sting reversal solution call
            // var input =  Console.ReadLine();
            //stringReversal.stringReversalMethod(input);


            Console.ReadLine();
        }
    }

    public class FizzBuzz
    {
        public static void FizzBuzzDisplayMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("fizzbuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("buzz");
            }
        }
    }

    public class stringReversal
    {
        public static void stringReversalMethod(string input)
        {
            var result = string.Empty;
            foreach(char ch in input)
            {
                result = ch + result;
            }
            Console.WriteLine(result);
        }
    }
}
