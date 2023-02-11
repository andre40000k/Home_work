namespace Home_work_7_5
{
    internal class HW_7_5
    {
        public static void ChectTicket()
        {
            int[] ticket = GetTicket();
            int rightPart = 0, leftPart = 0;


            for (int i = 0, j = ticket.Length - 1; i < ticket.Length / 2; i++, j--)
            {
                rightPart += ticket[i];
                leftPart += ticket[j];
            }

            if(rightPart == leftPart)
            {
                Console.WriteLine($"\nTicket {string.Join("", ticket)} is happy!");
            }

            else
            {
                Console.WriteLine($"\nTicket {string.Join("", ticket)} is not happy!");
            }
        }

        public static int [] GetTicket()
        {
            int[] ticketNumbers = new int[6];
            string ticket = string.Empty;
            Console.Write("Entered nummber of ticket: ");
            ticket = Console.ReadLine();

            try
            {
                if(ticket.Length != 6)
                {
                    throw new Exception();
                }

                int i = 0;
                foreach (var number in ticket)
                {
                    ticketNumbers[i++] = (int)Char.GetNumericValue(number);

                    if (ticketNumbers[i - 1] == -1)
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                GetTicket();
            }

            return ticketNumbers;
        }

        static void Main(string[] args)
        {
            // Task 7_5
            // Написать функцию, которая определяет, является ли «счастливым» шестизначное число.

            ChectTicket();
        }
    }
}