namespace Home_work_7_2
{
    internal class HW_7_2
    {
        static int RangeSum(int start, int end)
        {
            int sumRange = 0;
            for (int i = start + 1; i < end; i++)
            {
                sumRange = sumRange + i; 
            }

            return sumRange;
        }
        static void GettingNumbers(out int startNumber, out int endNumber)
        {
            try
            {
                Console.Write("Entered start range: ");
                startNumber = int.Parse(Console.ReadLine());

                Console.Write("Entered end range: ");
                endNumber = int.Parse(Console.ReadLine());

                if(startNumber > endNumber) 
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                GettingNumbers(out startNumber, out endNumber);
            }
        }
        static void Main(string[] args)
        {
            // Task 7_2
            // Написать функцию, которая получает в качестве параметров 2 целых числа и
            // возвращает сумму чисел из диапазона между ними.

            int startrange, endRange;

            GettingNumbers(out startrange, out endRange);

            Console.WriteLine($"The sum of numbers in the range from {startrange} to {endRange} is {RangeSum(startrange, endRange)}");
        }
    }
}