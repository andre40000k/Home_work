using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_12
{
    public class UsefulMethods
    {
        private static int numberDelimierChapters = 80;
        private static char delimierChapter = '-';


        private static string DelimiterLine(char delimierChapter, int numberDelimierChapters)
        {
            return new string(delimierChapter, numberDelimierChapters);

        }
        public static void Delimiter()
        {
            Console.WriteLine(DelimiterLine(delimierChapter, numberDelimierChapters));
        }

        public static void Delimiter(char delimierChapter)
        {
            Console.WriteLine(DelimiterLine(delimierChapter, numberDelimierChapters));
        }

        public static void Delimiter(int numberDelimierChapters)
        {
            Console.WriteLine(DelimiterLine(delimierChapter, numberDelimierChapters));
        }

        public static void Delimiter(char delimierChapter, int numberDelimierChapters)
        {
            Console.WriteLine(DelimiterLine(delimierChapter, numberDelimierChapters));
        }

        public static void ExtendedDelimiter()
        {
            Console.WriteLine('\n' + DelimiterLine(delimierChapter, numberDelimierChapters) + 
                              '\n' + DelimiterLine(delimierChapter, numberDelimierChapters) + '\n');
        }
    }
}
