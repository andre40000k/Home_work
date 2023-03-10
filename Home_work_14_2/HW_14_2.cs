using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Home_work_14_2
{
    internal class HW_14_2
    {
        public static void WriteFile(string path) 
        {
            string? contentTxt = default;
            contentTxt = GenerateString();

            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {                
                byte[] buffer = Encoding.Default.GetBytes(contentTxt);
                fstream.Write(buffer, 0, buffer.Length);
            }
        }

        public static void WriteFile(string path, string editText)
        {
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(editText);
                fstream.Write(buffer, 0, buffer.Length);
            }
        }

        public static string GenerateWord()
        {
            int randomLetter = default;

            const int statrRange = 3, endRange = 10;

            string lettersUpeer = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                lettersLover = lettersUpeer.ToLower(),
                letters = string.Concat(lettersUpeer,lettersLover);

            char[] letter = letters.ToCharArray();

            Random random = new Random();
            int rndLenghtWord = random.Next(statrRange, endRange);

            StringBuilder newWord = new StringBuilder();
            
            for (int i = 0; i < rndLenghtWord; i++)
            {
                randomLetter = random.Next(letters.Length);
                newWord.Append(letter[randomLetter]);
            }

            return newWord.ToString();
        }

        public static string GenerateString()
        {           
            string? newWord = default;
            const int statrRange = 10, endRange = 15;
            string[] separator = { ". ", ", ", " ", " - "};
            int lenghtSeparator = separator.Length;

            Random random = new Random();
            int valueWords = random.Next(statrRange, endRange);

            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < valueWords; i++)
            {
                newWord = GenerateWord();
                newString.Append(newWord);
                newString.Append(separator[random.Next(lenghtSeparator)]);
            }

            return newString.ToString();
        }

        public static string ReadFile(string path)
        {
            string? contentTxt = default;

            using (FileStream fstream = File.OpenRead(path))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);
                contentTxt = Encoding.Default.GetString(buffer);
            }

            return contentTxt;
        }
        public static List<string> ExceptionWords(string text)
        {
            int maxLenghtWord = 7;

            char[] separator = {' ', '\n'};

            char[] punctuationMarls = { '.', ',', ';', ':' };
            int lenghtPunctuationMarks = punctuationMarls.Length;

            bool checkSeparator = default;

            string[] subs = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            List<string> exceptionWords = new List<string>();
            
            foreach (string s in subs)
            {
                checkSeparator = CheckSeparator(s);

                if (s.Length == maxLenghtWord + 1 && checkSeparator == true)
                {
                    continue;
                }
                else if (s.Length > maxLenghtWord)
                {
                    exceptionWords.Add(s);
                }
            } 

            return exceptionWords;

            bool CheckSeparator(string word)
            {
                for (int i = 0; i < lenghtPunctuationMarks; i++)
                {
                    if (word.Contains(punctuationMarls[i]))
                        return true;
                }

                return false;
            }
        }

        public static string EditText(string corect_text)
        {
            StringBuilder stb_corect_text = new StringBuilder(corect_text);
            List<string> invalid_words = ExceptionWords(corect_text);

            int number_invalid_words = invalid_words.Count();

            for (int i = 0; i < number_invalid_words; i++)
            {
                stb_corect_text.Replace(invalid_words[i], default);
            }

            corect_text = stb_corect_text.ToString();

            return corect_text;
        }

        static void Main()
        {
            // Task 14_2
            // Дан текстовый файл.Необходимо создать новый файл, в который требуется переписать из исходного файла все слова, 
            // состоящие не менее чем из семи букв.
            //   - создать руками или кодом файл и записать туда какой - то текст
            //   - считать в переменную текст с файла и поработать с этим текстом как со строкой
            //   - результат привести к строке(если работали с List) и записать строчку в новый файл


            string pathRead = @"OriginalText.txt",
                pathWrite = @"EditedText.txt";

            WriteFile(pathRead); //create someText

            string textFromFile = ReadFile(pathRead);

            Console.WriteLine("Text before:\n\n{0}",textFromFile);

            Console.WriteLine('\n' + new string ('-', 100) + '\n');

            string editText = EditText(textFromFile);

            Console.WriteLine("Text after:\n\n{0}", editText);
            WriteFile(pathWrite, editText);

            Console.ReadKey();
        }
    }
}