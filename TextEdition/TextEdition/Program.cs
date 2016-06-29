using System;
using System.IO;

namespace TextEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            String text, path = null, pathForWriting = null;          
          
            Console.WriteLine("Write the path to the file with text you would like to edit: ");                    
            path = CheckThePath(path);          
            text = File.ReadAllText(path); //считываем с файла
              
            TextChange forSpliting = new TextChange(text); 
            string[] textSplit = forSpliting.SlitTheText(); 

            TextChange textChange = new TextChange(textSplit); 
            textChange.ChangeTheCase();
            textChange.AddTime();

            Console.WriteLine("Write the path to the file for writing results: ");
            pathForWriting = CheckThePath(pathForWriting);        
            textChange.WriteInFile(pathForWriting);
           

            Console.WriteLine("Press any key to exit...");         
            Console.ReadLine(); 


        }

        public static string CheckThePath(String path) {

            path = Console.ReadLine();
            while (!File.Exists(path))
            {
                Console.WriteLine("File do not exist. Try again...");
                path = Console.ReadLine();

            }
            return path;
        }

    }
}
