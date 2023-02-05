namespace Home_work_6_2
{
    internal class HW_6_2
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            // Task 6_2
            // Пользователь вводит прибыль фирмы за год(12 месяцев).
            // Необходимо определить месяц, в котором прибыль была максимальна и месяц,
            // в котором прибыль была минимальна.

            double[] monthlyProfit = new double[Enum.GetNames(typeof(Months)).Length];
            double finalProfit = 0, minProfit, maxProfit;
            int month = 0;
            Random randomProfit = new Random();

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                try
                {
                    // Random values
                    monthlyProfit[i] = randomProfit.Next(0, 2048);
                    Console.WriteLine($"Enteres profit for {(Months)i}: {monthlyProfit[i]}");

                    // Keyboard input
                    //Console.Write($"Enteres profit for {(Months)i}: {monthlyProfit[i]}");
                    //monthlyProfit[i] = double.Parse(Console.ReadLine());

                    if (monthlyProfit[i] < 0)
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

            // Min Profit

            minProfit = monthlyProfit[0];

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                if (minProfit > monthlyProfit[i])
                {
                    minProfit = monthlyProfit[i];
                    month = i;
                }
                   
            }

            Console.WriteLine($"\nMin profit from 12 months is {minProfit}$ in {(Months)month}");
            
            // Max Profit

            maxProfit = monthlyProfit[0];

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                if (maxProfit < monthlyProfit[i])
                {
                    maxProfit = monthlyProfit[i];
                    month = i;
                }
                    
            }

            Console.WriteLine($"\nMax profit from 12 months is {maxProfit}$ in {(Months)month}");

            //Total Profit

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                finalProfit += monthlyProfit[i];
            }

            Console.WriteLine($"\nTotal profit for year is {finalProfit}$");
        }
    }
}