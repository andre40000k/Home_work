namespace Home_work_12
{
    sealed class Teacher : Person
    {
        protected string _idTaughtSubject;
        public Teacher(string surname, string name, string lastName, int age, string gender, string idSubject) 
            :base(surname, name, lastName, age, gender)
        {
            _idTaughtSubject = idSubject;
        }

        public string _IdTaughtSubject { get { return _idTaughtSubject; } }
        public void ShowTeacherInformation()
        {
            UsefulMethods.Delimiter('*', 60);
            Console.WriteLine("Information about teacher {0}." + "\n" + ShowPersonInformation() + "\nSubject: {1}", _Name, _idTaughtSubject);
        }
    }
}