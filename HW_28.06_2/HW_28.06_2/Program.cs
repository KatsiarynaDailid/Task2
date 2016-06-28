using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  1. What if the array is empty.
    2. Float number like '45454.' and '4556,545'.
     
*/


namespace HW_28._06_2
{
    class Program
    {
        static void Main(string[] args)
        {

            long intNumber;
            float realNumber;
            String str = null;
            List<long> intNumbers = new List<long>();
            List<float> realNumbers = new List<float>();
            List<float> realWithTwoDigitAfterDot = new List<float>();

            List<string> remainingStrings = new List<string>();



            while (str != "ex") {
                Console.WriteLine("Enter the string or 'ex' to exit:");
                str = Console.ReadLine();
                if (long.TryParse(str, out intNumber))
                {
                    intNumbers.Add(intNumber);
                }
                else if (float.TryParse(str, out realNumber))
                {
                    realNumbers.Add(realNumber);
                }
                else {
                    remainingStrings.Add(str);
                }



            }
            Console.WriteLine($"The quantity of integer numbers is: {intNumbers.Count}");
            Console.WriteLine($"The quantity of real numbers is: {realNumbers.Count}");

            Console.WriteLine("The list of integer numbers:");
            for (int i = 0; i < intNumbers.Count; i++) {

                String number = intNumbers[i].ToString();

                Console.WriteLine(number.PadLeft(30));

            }
            Console.WriteLine($"The average: {intNumbers.Average()}".PadLeft(30));

            //myDoubleNumber.ToString("R").Split('.')[1].Length



            Console.WriteLine("The list of real numbers:");

            for (int i = 0; i < realNumbers.Count; i++) {


               int length =  realNumbers[i].ToString().Split('.')[1].Length;

                if (length == 2) {
                    
                    realWithTwoDigitAfterDot.Add(realNumbers[i]);

                    String number = realNumbers[i].ToString();

                    Console.WriteLine(number.PadLeft(30));
                }
            }
            Console.WriteLine($"The average: {realWithTwoDigitAfterDot.Average()}".PadLeft(30));



            Console.WriteLine("sgergw");
            Console.ReadLine();

        }
    }
}
