using System.Numerics;

namespace Home_work_12
{
    internal class HW_12
    {
        public static int randomStudeRecord()
        {
            int minNumberStudeecordValue = 1000,
                maxNumberStudeRecordValue = 9999;
            Random rnd = new Random();
            return rnd.Next(minNumberStudeecordValue, maxNumberStudeRecordValue);
        }

        public static int FindFirstNuberStudRecord()
        {
            int recordNumber = default,
                minNumber = int.MaxValue;

            for (int i = 0; i < students.Length; i++)
            {
                if(minNumber > students[i]._NumberStudRecord)
                {
                    minNumber = students[i]._NumberStudRecord;
                    recordNumber = i;
                }   
            }

            return recordNumber;
        }

        public static void FindMenStudent()
        {
            string genderMen = "Муж";

            UsefulMethods.Delimiter('M', 60);
            Console.WriteLine("Men student!\n");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._Gender == genderMen)
                {
                    students[i].ShowStudetInformation();
                }
            }            
        }

        public static void FindWomenStudent()
        {
            string genderMen = "Жен";

            UsefulMethods.Delimiter('Ж', 60);
            Console.WriteLine("Women student!\n");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._Gender == genderMen)
                {
                    students[i].ShowStudetInformation();
                }
            }
        }

        // Студенты с номером зачётки до 5000 учат математику, от 5000 - учат физику
        public static void WhatStudentsTeach()
        {
            int lustIdexStudRecordWhoTheachPhisics = 5000,
                indexPhisicsTheacher = 0,
                lustIdexStudRecordWhoTheachMath = 5001,
                indexMathTheacher = 1;
            string nameTecher;

            nameTecher = teachers[indexPhisicsTheacher]._Name + " " + teachers[indexPhisicsTheacher]._LastName;

            Console.WriteLine("Students who teach phisics with {0}", nameTecher);

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._NumberStudRecord <= lustIdexStudRecordWhoTheachPhisics)
                {
                    students[i].ShowStudetInformation();
                }
            }

            UsefulMethods.ExtendedDelimiter();

            nameTecher = teachers[indexMathTheacher]._Name + " " + teachers[indexMathTheacher]._LastName;

            Console.WriteLine("Students who teach math with {0}", nameTecher);

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._NumberStudRecord >= lustIdexStudRecordWhoTheachMath)
                {
                    students[i].ShowStudetInformation();
                }
            }
        }

        static void Main(string[] args)
        {
            int minRecordNumber = default;

            Academy academy = new Academy();
            academy.PrintNameAcademy();

            UsefulMethods.ExtendedDelimiter();

            for (int i = 0; i < students.Length; i++)
            {
                students[i].ShowStudetInformation();                 
            }

            UsefulMethods.ExtendedDelimiter();

            minRecordNumber = FindFirstNuberStudRecord();
            students[minRecordNumber].ShowStudetInformation();

            UsefulMethods.ExtendedDelimiter();

            FindMenStudent();

            UsefulMethods.ExtendedDelimiter();

            FindWomenStudent();

            UsefulMethods.ExtendedDelimiter();

            WhatStudentsTeach();
        }

        public static Student[] students =
        {
            new Student("Антощук", "Гена", "Крокодилович", 19, "Муж", randomStudeRecord()),
            new Student("Антощук", "Ирина", "Анатольевна", 20, "Жен", randomStudeRecord()),
            new Student("Варварюк", "Инна", "Темофеевна", 18, "Жен", randomStudeRecord()),
            new Student("Всеволод", "Михаил", "Игорович", 18, "Муж", randomStudeRecord()),
            new Student("Вармилион", "Фёдор", "Игнатович", 19, "Муж", randomStudeRecord())
        };

        public static Teacher[] teachers =
        {
            new Teacher("Пурпулит", "Олег", "Анатольевич", 65, "Муж", "Физика"),
            new Teacher("Кропива", "Наталья", "Владимировна", 50, "Жен", "Математика")
        };
    }
}