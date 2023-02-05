namespace Home_work_5_1
{
    internal class HW_5_1
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June
        }
        static void Main(string[] args)
        {
            // Task 5_1
            // Написать, программу, которая вычисляет прибыль фирмы за 6 месяцев.
            // Пользователь вводит прибыль фирмы за каждый месяц.

            double [] monthlyProfit = new double[Enum.GetNames(typeof(Months)).Length];
            double finalProfit = 0;

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                try
                {
                    Console.Write($"Enteres profit for {(Months)i}: ");
                    monthlyProfit[i] = double.Parse(Console.ReadLine());

                    if(monthlyProfit[i] < 0)
                    {                       
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    i--;
                    Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                }
            }

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                finalProfit += monthlyProfit[i];
            }
            Console.WriteLine($"\nTotal profit for 6 months is {finalProfit}");


        }
    }
}