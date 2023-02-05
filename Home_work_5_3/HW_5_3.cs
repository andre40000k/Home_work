using System.Reflection.Metadata.Ecma335;

namespace Home_work_5_3
{
    internal class HW_5_3
    {
        static void Main(string[] args)
        {
            // Task 5_3
            // Сжать(сдвинуть элементы) массив, удалив из него все 0,
            // и заполнить освободившиеся справа элементы значениями -1.
            // (нужно сделать через пересоздание массива)

            int numberValue = -1, arreySize = 10;
            int[] massiv1 = new int[arreySize];
            int[] massiv2 = Enumerable.Repeat(numberValue, arreySize).ToArray();

            Random randomValue= new Random();

            for (int i = 0; i < arreySize; i++)
            {
                massiv1[i] = randomValue.Next(0,3);
                Console.WriteLine(massiv1[i]);
            }

            Console.WriteLine('\n' + new string('-', 80) + '\n');

            int j = 0;
            for (int i = 0; i < arreySize; i++)
            {
                if (massiv1[i] != 0)
                {                    
                    massiv2[j] = massiv1[i];
                    j++;
                }
                else
                {
                    continue;
                }                  
            }

            for (int i = 0; i < arreySize; i++)
            {
                Console.WriteLine(massiv2[i]);
            }


        }
    }
}