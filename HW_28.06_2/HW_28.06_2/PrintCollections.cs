using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW_28._06_2
{
    class PrintCollections
    {

        private List<long> intNumbers;
        private List<float> realNumbers;    
        private List<string> remainingStrings;

        public PrintCollections(List<long> intNumbers, List<float> realNumbers, List<string> remainingStrings)
        {
            this.intNumbers = intNumbers;
            this.realNumbers = realNumbers;
            this.remainingStrings = remainingStrings;
        }
       
        

        public void PrintInt() {
            Console.WriteLine("The list of integer numbers:");

            for (int i = 0; i < intNumbers.Count; i++)
            {
                String number = intNumbers[i].ToString();
                Console.WriteLine(number.PadLeft(30));

            }           
            Console.WriteLine($"The average: {intNumbers.Average()}".PadLeft(30));
        }

        public void PrintFloat()
        {

            Console.WriteLine("The list of real numbers:");
            for (int i = 0; i < realNumbers.Count; i++)
            {
                String number = realNumbers[i].ToString("0.00");
                Console.WriteLine(number.PadLeft(30));

            }

            String average = realNumbers.Average().ToString("0.00");
            Console.WriteLine($"The average: {average}".PadLeft(30));
        }

        public void PrintStrings()
        {
            Console.WriteLine("The list of sorted strings:");

            IEnumerable<string> remStr = remainingStrings.OrderBy(s => s.Length).ThenBy(s => s);

            foreach (var str in remStr)
                Console.WriteLine(str);
        }

        public void DetermineType()
        {
            long intNumber;
            float realNumber;
            String str = null;
            String separator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            Console.WriteLine("If you want to enter the real number, you shoud enter them in format: [numbers]" + separator + "[numbers]");
            while (str != "ex")
            {             
                Console.WriteLine("Enter the string or 'ex' if you would like to exit:");
                str = Console.ReadLine();
                if (str == "ex")
                {
                    continue;
                }
                if (long.TryParse(str, out intNumber))
                {
                    intNumbers.Add(intNumber);
                }
                else if (DetermineFloat(str, separator))
                {
                    realNumber = float.Parse(str);
                    realNumbers.Add(realNumber);
                }
                else
                {
                    remainingStrings.Add(str);
                }

            }

            Console.WriteLine($"The quantity of integer numbers is: {intNumbers.Count}");
            Console.WriteLine($"The quantity of real numbers is: {realNumbers.Count}");

        }

        public static Boolean DetermineFloat(String str, String separator)
        {

            var reg = new Regex(@"\s*[0-9]*\" + separator + "[0-9]+");
            return reg.IsMatch(str);
        }
    }
}
