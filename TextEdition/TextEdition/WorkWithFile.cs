using System;
using System.IO;


namespace TextEdition
{
    class WorkWithFile
    {

        public String ReadAFile(String path)
        {
            string text = File.ReadAllText(path);
            return text;
        }

        /*    public static void WriteInAFile(){

            }*/


        public Boolean CheckThePath(String path)
        {
            return File.Exists(path);
        }
    }
}
