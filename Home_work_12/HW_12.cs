namespace Home_work_12
{
    internal class HW_12
    {
        static void Main(string[] args)
        {
            string subject = Convert.ToString(Subjects_Id.Math);

            Teacher inforTeacher = new Teacher("Петросян", "Петросий", "Петросянович", 80, "Муж", subject);
            inforTeacher.ShowTeacherInformation();

            Console.WriteLine(new string('-', 80));

            Student inforStudent = new Student("Антощук", "Гена", "Крокодилович", 19, "Муж", 1234);
            inforStudent.ShowStudetInformation();
        }
    }
}