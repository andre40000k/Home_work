using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Home_work_10
{    
    internal class HW_10
    {
        
        static void Main(string[] args)
        {
            // HW_10
            // Создать программу "список дел". (List)
            // Реализовать:
            //   - добавление задачи в список задач
            //   - изменение задачи(найти по индексу)
            //   - удаление задачи(найти по индексу)
            //Задача представляет из себя строчку(string).

            Random rnd = new Random();

            List<string> tasks = new List<string>() { "Task_1", "Task_2", "Task_3" };

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n' + new string('=', 80) + '\n');

            // Add

            for (int i = 4; i <= 6; i++)
            {
                tasks.Add($"Task_{i}");
            }

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n' + new string('=', 80) + '\n');

            // Change            

            int rnd_index = rnd.Next(0, tasks.Count());

            string rnd_task = "Change_" + tasks[rnd_index];

            //V1
            //tasks.RemoveAt(rnd_index);
            //tasks.Insert(rnd_index, rnd_task);


            //V2
            tasks[rnd_index] = rnd_task;

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n' + new string('=', 80) + '\n');

            // Remove

            rnd_index = rnd.Next(0, tasks.Count());

            tasks.RemoveAt(rnd_index);

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n' + new string('=', 80) + '\n');
        }
    }
}