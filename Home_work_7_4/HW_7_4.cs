using System.IO;


namespace Home_work_7_4
{
    internal class Program
    {
        const int minCardVlue = 1, maxCardValue = 36, lastClubs = 9, lastDiamonds = 18, lastHearts = 27;

        enum CardWeight
        {
            six,
            seven,
            eight,
            nine,
            ten,
            Jack,
            Queen,
            King,
            Ace
        }

        // Креста (1 - 9)   ♣
        // Бубна (10 - 18)  ♦
        // Черви (19 - 27)  ♥
        // Пики (28 - 36)   ♠

        public static void OutputSelectedCard()
        {
            int selectedCard = ChooseCard();

            if(selectedCard <= lastClubs)
            {
                Console.WriteLine($"\nYou have choos a card: \u2663 {(CardWeight)selectedCard - 1}");
            }

            else if (selectedCard > lastClubs && selectedCard  <= lastDiamonds)
            {
                Console.WriteLine($"\nYou have choos a card: \u2666 {(CardWeight)(selectedCard - (lastClubs+1))}");
            }

            else if (selectedCard > lastDiamonds && selectedCard <= lastHearts)
            {
                Console.WriteLine($"\nYou have choos a card: \u2665 {(CardWeight)(selectedCard - (lastDiamonds + 1))}");
            }

            else 
            {
                Console.WriteLine($"\nYou have choos a card: \u2660 {(CardWeight)(selectedCard - (lastHearts + 1))}");
            }
        }

        public static int ChooseCard()
        {
            int numberCard = 0;
            try
            {
                Console.Write($"Entered number of card ({minCardVlue} - {maxCardValue}): ");
                numberCard= int.Parse(Console.ReadLine());

                if(numberCard < minCardVlue || numberCard > maxCardValue)
                {
                    throw new Exception();
                }                
            }
            catch (Exception)
            {
                Console.WriteLine("\nErrors!\nIncorrd data entry!\nRepeat data entry!\n");
                ChooseCard();
            }

            return numberCard;
        }

        static void Main(string[] args)
        {
            // Task 7_4
            // Написать функцию, выводящую на экран переданную ей игральную карту.

            OutputSelectedCard();
        }
    }
}