namespace Home_work_4_1
{
    internal class HW_4_1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Task 1
            // Пользователь вводит с клавиатуры два числа(начало и конец диапазона).
            // Нужно вывести на экран:
            //  1.Все числа диапазона;
            //  2.Все числа диапазона в убывающем порядке;
            //  3.Все числа, кратные 7;
            //  4.Количество чисел, кратных 5.
            Console.WriteLine("Пользователь вводит с клавиатуры два числа(начало и конец диапазона)." +
                "\r\nНужно вывести на экран:" +
                "\n  1.Все числа диапазона;" +
                "\n  2.Все числа диапазона в убывающем порядке;" +
                "\n  3.Все числа, кратны 7;" +
                "\n  4.Количество чисел, кратных 5.\n");

            const int multiplicityOfFive = 5, multiplicityOfSeven = 7;

            int rengeStart = 0, rengeEnd = 0, reverseOrder, multiplesOfFive = 0;

            try
            {
                Console.Write("Enter start of range: ");
                rengeStart = int.Parse(Console.ReadLine());

                Console.Write("Enter end of range: ");
                rengeEnd = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry");
            }

            Console.Write("\nT1" +
                "\t T2" +
                "\t T3" +
                "\t T4\n");

            reverseOrder = rengeEnd;

            for (int i = rengeStart; i <= rengeEnd; i++)
            {
                Console.WriteLine($"{i} " +
                    $"\t {reverseOrder--} " +
                    $"\t {(i % multiplicityOfSeven == 0 ? i : "-")}" +
                    $"\t {(i % multiplicityOfFive == 0 ? i : "-")}");

                multiplesOfFive = i % multiplicityOfFive == 0 ? ++multiplesOfFive : multiplesOfFive;
            }

            Console.WriteLine($"\nResult of task 4: {multiplesOfFive}");

        }
    }
}