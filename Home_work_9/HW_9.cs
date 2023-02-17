namespace Home_work_9
{
    internal class HW_9
    {
        //сортировка пузырьком
        static void BubbleSort(int[] unSrtMass, ref int[] srtMass)
        {
            // получаем длину массива
            int lenghtMass = unSrtMass.Length;

            // циклическое повторение попарного сравнение чисел с уменьшением количества операций  внутренего цикла сравнения на "1" от общей длины массива чисел.
            for (int i = 1; i < lenghtMass; i++)
            {
                // внутренний цикл, в котором производится попарное сравнение двух элементов массива
                // при котором если в паре соседних чисел, "правое" число по значению меньше за "левое",
                // то большее число в массиве сдвигается вправо на индекс "n + 1", а меньшее - в лево на индекс "n - 1"
                // (меняются местами в массиве)
                // в ином случаи, числа в данной итерации не меняют свой индекс в массиве
                for (int j = 0; j < lenghtMass - i; j++)
                {
                    // проверяем больше ли текущая переменная по отношению к следующей
                    if (unSrtMass[j] > unSrtMass[j + 1])
                    {
                        // текущий элемент записываем в временную переменную
                        int temp  = unSrtMass[j];

                        // меняем значение текущей переменной на следующую переменную
                        unSrtMass[j] = unSrtMass[j + 1];

                        // следующему элементу присваеваем значения со временной переменной
                        unSrtMass[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < lenghtMass; i++)
            {
                srtMass[i] = unSrtMass[i];
            }
        }

        static void Main(string[] args)
        {
            // Создать массив на 30 чисел и заполнить случайными числами от 1 до 100.
            // Отсортировать алгоритмом пузырьковой сортировки.
            // Pазобраться как работает, продебажить и написать самостоятельно, не списывая.
            // FYI: обязательно написать сортировку пузырьком, добавить комментарии с пояснениями каждой строке.


            Console.WriteLine("Сортировка пузырьком");

            int massivSize = 5;
            int [] unSortMass = new int[massivSize];
            int[] sortMass = new int[massivSize];
            Random rnd = new Random();

            Console.WriteLine("\nДо сортировки");

            for (int i = 0; i < massivSize; i++)
            {
                unSortMass[i] = rnd.Next(-5, 5);
                Console.Write($"{unSortMass[i]}\t");

            }

            Console.WriteLine("\n\nПосле сортировки");
            BubbleSort(unSortMass, ref sortMass);

            for (int i = 0; i < massivSize; i++)
            {                
                Console.Write($"{sortMass[i]}\t");
            }

            //Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array)));

            Console.ReadLine();
        }
    }
}