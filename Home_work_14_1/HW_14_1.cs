using System.IO;
using System.Text;

namespace Home_work_14_1
{
    internal class HW_14_1
    {
        public static int ValueWords(string text) 
        {
            int valueWords;

            char[] separators = new char[] { ' ', '-'};

            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            valueWords = subs.Length;

            return valueWords;
        }
        public static string ReadFile()
        {
            string? contentTxt = default;
            string path = @"sometext.txt";

            using (FileStream fstream = File.OpenRead(path))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);
                contentTxt = Encoding.Default.GetString(buffer);
            }

            return contentTxt;
        }

        static void Main(string[] args)
        {
            // Task 14_1
            // Дан текстовый файл. Подсчитать количество слов в нём.
            string sigsfh = ReadFile();

            int nuberWords = ValueWords(sigsfh);

            Console.WriteLine("\"sometext.txt\" contain is {0} words", nuberWords);
        }
    }
}