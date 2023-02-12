namespace Home_work_8_2
{
    internal class HW_8_2
    {
        static string OutputStarsVersOne(int numberStars, string starsWriting)
        {
            if (numberStars == 1)
                return starsWriting;

            return starsWriting + OutputStarsVersOne(numberStars - 1, starsWriting);
        }

        static string OutputStarsVersTwo(int numberStars)
        {
            if (numberStars == 0)
                return "";

            return "*" + OutputStarsVersTwo(numberStars - 1);
        }
        static void GettingNumbers(out int inputNumberStars)
        {
            try
            {
                Console.Write("Entered number of stars: ");
                inputNumberStars = int.Parse(Console.ReadLine());

                if (inputNumberStars < 0)
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                GettingNumbers(out inputNumberStars);
            }
        }

        static void Main(string[] args)
        {
            //Task 8_2
            // Написать рекурсивную функцию, которая выводит N звезд в ряд, число N задает пользователь.
            // Проиллюстрируйте работу функции примером. (протестировать функцию).

            int numberStars;
            string stars = "*";

            GettingNumbers(out numberStars);

            Console.WriteLine($"\nStarsssssss!!!!\n\n{OutputStarsVersOne(numberStars, stars)}");

            //Console.WriteLine($"\nStarsssssss!!!!\n\n{OutputStarsVersTwo(numberStars)}");

            Console.WriteLine(stars);

        }
    }
}