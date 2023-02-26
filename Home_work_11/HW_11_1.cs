using System.Text;
using System.Xml.Linq;

namespace Home_work_11
{
    internal class HW_11_1
    {
        public static string InputString()
        {
            Console.WriteLine("Enter text to check: ");
            string input_text = string.Empty;

            try
            {
                input_text = Console.ReadLine();
                //input_text = "today is a good day for walking. i will try to walk near the sea. ";
                //input_text = "let me introduce myself. my name is mariya i am a 20-year-old student from Lviv. " +
                //    "i study at the university in my native town and my future profession is bookkeeping. " +
                //    "i live with my parents and my elder sister lena. we are a friendly family. " +
                //    "lena is 2 years older than me. we share our room and tell all our secrets to each other.";
                //Console.WriteLine(input_text);

                if (string.IsNullOrWhiteSpace(input_text)) 
                {
                    throw new Exception();
                }

                input_text = input_text.Trim();
            }

            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                InputString();
            }
           
            return input_text;
        }

        public static string CorectText(string corect_text)
        {            
            string separator = ". ";
            const int firstSymbolIndex = 0;

            string [] strigs_text = corect_text.Split(separator);

            int value_str_text = strigs_text.Length;

            for (int i = 0; i < value_str_text; i++)
            {
                strigs_text[i] = strigs_text[i][firstSymbolIndex].ToString().ToUpper() + strigs_text[i].Substring(firstSymbolIndex + 1);
            }

            corect_text = string.Join(separator, strigs_text); 

            return corect_text;
        }
        static void Main(string[] args)
        {            
            // Task 11_1
            // Пользователь с клавиатуры вводит некоторый текст.
            // Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.

            // Например, если пользователь ввёл: «today is a good day for walking. i will try to walk near the sea».
            // Результат работы приложения: «Today is a good day for walking. I will try to walk near the sea».

            string check_text = string.Empty;
            check_text = InputString();            

            check_text = CorectText(check_text);

            Console.WriteLine("\nResult:\n{0}",check_text);

            Console.ReadLine();
        }
    }
}