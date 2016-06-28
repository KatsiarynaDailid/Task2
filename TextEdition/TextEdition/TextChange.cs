using System;
using System.Globalization;
using System.Text.RegularExpressions;


namespace TextEdition
{
    class TextChange
    {
        public string[] SlitTheText(String text) {        
            
            string[] sentences = Regex.Split(text, @"(?<=[.!?])");
            int lineCounter = sentences.Length;
            while (lineCounter != 0) {
                int b = sentences.Length - lineCounter;
                sentences[b]= sentences[b] + "\n";
                lineCounter--;              
            }

            return sentences;
        }


        public string[] ChangeTheCase(string[] text) {
            
            int lineCounter = text.Length;
            while (lineCounter != 0)
            {
                int b = text.Length - lineCounter;
                text[b] = text[b].ToLower();
                lineCounter--;
            }

            return text;
        }


        public string[] AddTime(string[] text) {

            int lineCounter = text.Length;
            while (lineCounter != 0)
            {
                int b = text.Length - lineCounter;
                string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff ", CultureInfo.InvariantCulture);
                text[b] = text[b].Trim();
                text[b] = timestamp + text[b];
                text[b] = text[b] + "\n";
                lineCounter--;
            }

            return text;
        }
    
    }
}
