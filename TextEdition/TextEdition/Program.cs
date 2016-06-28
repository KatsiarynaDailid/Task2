using System;


/*TODO:
            1. Ignore whitespace in regex.
            2. Constractor and field in TextChange class.
            3. Userfriendly interface.
            4. Write in a file.
     
     
     */

namespace TextEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            String text;
            String path;
            WorkWithFile file = new WorkWithFile();

            path = Console.ReadLine();
            while (!file.CheckThePath(path)) 
            {

                path = Console.ReadLine();
                Console.WriteLine("File do not exist. Try again...");

            } 



            text = file.ReadAFile(path);

            TextChange textChange = new TextChange();

            string[] textSplit = textChange.SlitTheText(text);
             textSplit = textChange.ChangeTheCase(textSplit);
            textSplit = textChange.AddTime(textSplit);
            //textSplit = textChange.SlitTheText(textSplit);
            Console.Write(string.Concat(textSplit));
          
            Console.ReadLine(); 


        }
    }
}
