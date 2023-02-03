namespace Home_work_4_2
{
    internal class HW_4_2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Task 2
            // Пользователь вводит с клавиатуры два числа.
            // Нужно посчитать отдельно сумму четных, нечетных и чисел,
            // кратных 9 в указанном диапазоне, а также среднеарифметическое каждой группы.

            Console.WriteLine("Пользователь вводит с клавиатуры два числа(начало и конец диапазона)." +
                "\r\n1. Нужно посчитать отдельно сумму четных;" +
                "\n2. Нужно посчитать отдельно сумму нечетных;" +
                "\n3. Нужно посчитать отдельно сумму кратных 9;" +
                "\n4. Tакже среднеарифметическое каждой группы.");

            const int multiplicityOfTwo = 2, multiplicityOfNine = 9;

            int rengeStart = 0, rengeEnd = 0, reverseOrder, multiplesOfTwo = 0, multiplesNotTwo = 0, multiplesOfNine = 0,
             numberMultiplesTwo = 0, numberMultiplesNotTwo = 0, numberMultiplesOfNine = 0;

            try
            {
                Console.Write("\nEnter start of range: ");
                rengeStart = int.Parse(Console.ReadLine());

                Console.Write("Enter end of range: ");
                rengeEnd = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry");
                return;
            }

            Console.Write("\nT0" +
                "\t T1" +
                "\t T2" +
                "\t T3\n");

            reverseOrder = rengeEnd;

            for (int i = rengeStart; i <= rengeEnd; i++)
            {
                Console.WriteLine($"{i} " +
                    $"\t {(i % multiplicityOfTwo == 0 ? i : "-")}" +
                    $"\t {(i % multiplicityOfTwo != 0 ? i : "-")}" +
                    $"\t {(i % multiplicityOfNine == 0 ? i : "-")}");


                multiplesOfTwo = i % multiplicityOfTwo == 0 ? (multiplesOfTwo += i) : multiplesOfTwo;
                numberMultiplesTwo = i % multiplicityOfTwo == 0 ? ++numberMultiplesTwo : numberMultiplesTwo;

                multiplesNotTwo = i % multiplicityOfTwo != 0 ? (multiplesNotTwo += i) : multiplesNotTwo;
                numberMultiplesNotTwo = i % multiplicityOfTwo != 0 ? ++numberMultiplesNotTwo : numberMultiplesNotTwo;

                multiplesOfNine = i % multiplicityOfNine == 0 ? (multiplesOfNine += i) : multiplesOfNine;
                numberMultiplesOfNine = i % multiplicityOfNine == 0 ? ++numberMultiplesOfNine : numberMultiplesOfNine;
            }

            Console.WriteLine('\n' + new string('-',80));

            Console.WriteLine($"\nSum:\t {multiplesOfTwo}" +
                $"\t {multiplesNotTwo}" +
                $"\t {multiplesOfNine}");

            Console.WriteLine($"\nT4\nAverage: {(double)multiplesOfTwo / numberMultiplesTwo}" +
                $"\t {(double)multiplesNotTwo / numberMultiplesNotTwo}" +
                $"\t {(double)multiplesOfNine / numberMultiplesOfNine}");
        }
    }
}