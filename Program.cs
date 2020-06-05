using System;

namespace PersonalTasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            var inputValues = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries);
            string inputString = inputValues[0];
            int limit = int.Parse(inputValues[1]);

            Console.WriteLine(stringReduction(inputString,limit));
            
        }

        public static string stringReduction(string inputString, int limit)
        {
            var outputString = "";
            int length = 0;


            //aabbaa (1) => aba
            //aaab (2) => aab


            for (int i = 0; i < inputString.Length; i++)
            {
                if ((i > 0) && (inputString[i] == inputString[i - 1]))
                {
                    length++;
                }
                else
                {
                    length = 0;
                }

                if (length < limit)
                {
                    outputString += inputString[i];
                }
            }
            return outputString;
        }
    }
}
