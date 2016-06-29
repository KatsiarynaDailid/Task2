using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;


namespace TextEdition
{
    class TextChange
    {

        private string[] sentences;
        private String text;

        public TextChange(String text) { this.text = text; }
        public TextChange(string[] sentences) { this.sentences = sentences; }

        public string[] SlitTheText() {        
            
            string[] sentences = Regex.Split(text, @"(?<=[.!?])");
            int lineCounter = sentences.Length;
            while (lineCounter != 0) {
                int b = sentences.Length - lineCounter;
                sentences[b]= sentences[b] + "\n";
                lineCounter--;              
            }

            return sentences;
        }


        public string[] ChangeTheCase() {
            
            int lineCounter = sentences.Length;
            while (lineCounter != 0)
            {
                int b = sentences.Length - lineCounter;
                sentences[b] = sentences[b].ToLower();
                lineCounter--;
            }

            return sentences;
        }


        public string[] AddTime() {

            int lineCounter = sentences.Length;
            while (lineCounter != 0)
            {
                int b = sentences.Length - lineCounter;
                string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff ", CultureInfo.InvariantCulture);
                sentences[b] = sentences[b].Trim();
                sentences[b] = timestamp + sentences[b];
                sentences[b] = sentences[b] + "\n";
                lineCounter--;
            }

            return sentences;
        }


        public void WriteInFile(string path)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                int i = -1;
                while (++i < sentences.Length)
                {
                    sr.WriteLine(sentences[i]);
                }
            }
        }


    }
}
