namespace Home_work_12
{
    public class Teacher : Person
    {
        protected string _IdTaughtSubject;
        public Teacher(string surname, string name, string lastName, int age, string gender, string idSubject) 
            :base(surname, name, lastName, age, gender)
        {
            _IdTaughtSubject = idSubject;
        }

        public void ShowTeacherInformation()
        {
            Console.WriteLine("Information about teacher {0}." + "\n" + ShowPersonInformation() + "\nSubject: {1}", _Name, _IdTaughtSubject);
        }
    }
}