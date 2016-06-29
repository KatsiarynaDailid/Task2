using System;
using System.Collections.Generic;




namespace HW_28._06_2
{
    class Program
    {
        static void Main(string[] args)
        {         
            List<long> intNumbers = new List<long>();
            List<float> realNumbers = new List<float>();          
            List<string> remainingStrings = new List<string>();           
          
            PrintCollections printObj = new PrintCollections(intNumbers, realNumbers, remainingStrings);
            printObj.DetermineType();


           
            if (intNumbers.Count != 0)
            {   
                printObj.PrintInt();
            }

            if (realNumbers.Count != 0)
            {
                printObj.PrintFloat();
            }

            if (remainingStrings.Count != 0)
            {
                printObj.PrintStrings();
            }

            Console.ReadLine();

        }



    }
}
