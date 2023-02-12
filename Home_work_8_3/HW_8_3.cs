namespace Home_work_8_3
{
    internal class HW_8_3
    {
      
        static int RangeSum(int resultSumRange, int end)
        {
            if (resultSumRange == end)
                return resultSumRange;

            return resultSumRange + RangeSum(resultSumRange + 1, end);
        }


        static void GettingNumbers(out int startNumber, out int endNumber)
        {
            try
            {
                Console.Write("Entered start range: ");
                startNumber = int.Parse(Console.ReadLine());

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
                GettingNumbers(out startNumber, out endNumber);
            }
        }

        static void Main(string[] args)
        {
            //Task 8_3
            //Написать рекурсивную функцию, которая вычисляет сумму всех чисел в диапазоне от a до b.
            //Пользователь вводит a и b.
            //Проиллюстрируйте работу функции примером. (протестировать функцию).

            int startRange, endRange;

            GettingNumbers(out startRange, out endRange);

            Console.WriteLine($"The sum of numbers in the range from {startRange} to {endRange} is {RangeSum(startRange, endRange)}");
        }
    }
}