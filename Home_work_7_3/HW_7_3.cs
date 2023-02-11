namespace Home_work_7_3
{
    internal class HW_7_3
    {
        const int minNumberRange = 1;

        static void perfectNumber(int start, int end)
        {
            int sumDivision = 0;

            for (int i = start + 1; i < end; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        sumDivision = sumDivision + j;
                    }
                }

                if(sumDivision == i)
                {
                    Console.WriteLine($"\nNumber {i} perfect");
                }

                sumDivision= 0;
            }

            return;
        }

        static void GettingRange(out int startNumber, out int endNumber)
        {            
            try
            {
                Console.Write("Entered start range: ");
                startNumber = int.Parse(Console.ReadLine());

                if (startNumber < minNumberRange)
                {
                    throw new Exception();
                }

                Console.Write("Entered end range: ");
                endNumber = int.Parse(Console.ReadLine());

                if (startNumber > endNumber)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                GettingRange(out startNumber, out endNumber);
            }
        }

        static void Main(string[] args)
        {
            // Task 7_3
            // Число называется совершенным, если сумма всех его делителей равна ему самому.
            // Напишите функцию поиска таких чисел во введенном интервале.

            int startrange, endRange;

            GettingRange(out startrange, out endRange);

            perfectNumber(startrange, endRange);
        }
    }
}