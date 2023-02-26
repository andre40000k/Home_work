using System.Text;

namespace Home_work_11_2
{
    internal class HW_11_2
    {
        public static string InputString()
        {
            Console.WriteLine("Enter text to check: ");
            string input_text = string.Empty;

            try
            {
                //input_text = Console.ReadLine();
                input_text = "To be, or not to be, that is the question, " +
                            "Whether 'tis nobler in the mind to suffer " +
                            "The slings and arrows of outrageous fortune, " +
                            "Or to take arms against a sea of troubles, " +
                            "And by opposing end them? To die: to sleep; " +
                            "No more; and by a sleep to say we end The heart-ache and the thousand natural shocks " +
                            "That flesh is heir to, 'tis a consummation Devoutly to be wish'd. To die, to sleep";

                Console.WriteLine(input_text);

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
            StringBuilder stb_corect_text = new StringBuilder(corect_text);
            char hiding_Element = '*';
            string [] invalid_words = { "die", "question", "flesh", "be"};
            int number_invalid_words = invalid_words.Length,
                lenght_invalid_word;


            for (int i = 0;i < number_invalid_words; i++)
            {
                lenght_invalid_word = invalid_words[i].Length;
                stb_corect_text.Replace(invalid_words[i], new string(hiding_Element, lenght_invalid_word));
            }

            corect_text = stb_corect_text.ToString();

            return corect_text;
        }
        static void Main(string[] args)
        {
            // Task 11_2
            // Создайте приложение, проверяющее текст на недопустимые слова.
            // Если недопустимое слово найдено, оно должно быть заменено на набор символов *.
            // По итогам работы приложения необходимо показать статистику действий. 

            string check_text = string.Empty;
            check_text = InputString();

            check_text = CorectText(check_text);

            Console.WriteLine("\nResult:\n{0}", check_text);

            Console.ReadLine();

        }
    }
}