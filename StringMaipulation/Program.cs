using System;
using System.Collections.Generic;

namespace StringMaipulation
{


    internal static class Program
    {
        public static List<int> AllIndexesOf(this string str, string value) {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", value);
            List<int> indexes = new List<int>();
            for (int index = 0;; index += value.Length) {
                index = str.IndexOf(value, index, StringComparison.Ordinal);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }

        public static void Main(string[] args)
        {
            //code to read  an alphabet  string into a  char array
            string alphabet = "abcdefghijklmnopqrstwxyz";
            char[] alphabetArray = alphabet.ToCharArray(0, 24);
            Console.WriteLine("there are {0} letters in {1}", alphabetArray.Length.ToString(), alphabet);
            foreach (char t in alphabetArray)
            {
                Console.WriteLine(t);
            }


            //code to split string  based on delimiter
            string helloWorld = "Hello, World!";
            string[] words = helloWorld.Split(',');

            foreach (string t in words)
            {
                Console.WriteLine(t);
            }


            // write out a string wth quotes
            // use the  escape character \ before it
            string quote = "\"To be or not to be\"";
            Console.WriteLine(quote);
            Console.WriteLine("Please  enter your  first  string");
            string firstString = Console.ReadLine();
            Console.WriteLine("Please  enter your  second  string");
            string secondString = Console.ReadLine();

            Console.WriteLine(firstString != secondString ? "The strings are different" : "The strings are the same");

            //comparing lexograpbically  i.e which string is first alphabetically
            // convert string  to char  arrays
            char[] firstArray = firstString.ToCharArray(0, firstString.Length);
            char[] secondArray = secondString.ToCharArray(0, secondString.Length);

            //get the smallest  string length
            int length = Math.Min(firstArray.Length, secondArray.Length);
            string outputString = "";
            if (firstArray.Length > secondArray.Length)
            {
                outputString="Second string is earlier.";
            }
            else if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        outputString="second string is earlier.";
                        break;
                    }
                    else if (secondArray[i] > firstArray[i])
                    {
                        outputString="first string  is earlier.";
                        break;
                    }
                    else
                    {
                        outputString="strings  are equal.";

                    }
                }
            }
            else
            {
                outputString="First string is earlier.";
            }
             Console.WriteLine(outputString);
            // end of checking lexogrpahically

            // Concatonate  strings imputed output them to console
            string concat = firstString + secondString;
            Console.WriteLine(concat);

            // changing cases examples
            string messedUpCase = "ALL Kinds OF LeTTers";
            Console.WriteLine(messedUpCase.ToLower());
            Console.WriteLine(messedUpCase.ToUpper());

            // retreive index location
            string findIndex = "Introduction to C#";
            Console.WriteLine(value: findIndex.IndexOf("C#", StringComparison.Ordinal));

            // retrive all index locations
            string findAllOccurances = "The main intent of the C# book is to introduce programming in C# to newbies";
            List<int> inst = findAllOccurances.AllIndexesOf("C#");

            Console.Write("\"C#\" occurrs at potitions:");
            foreach (var i in inst)
            {
               Console.Write(" {0}",i);
            }


        }



    }
}