namespace Home_work_12
{
    sealed class Student : Person
    {
        protected int _numberStudRecord;
        public Student(string surname, string name, string lastName, int age, string gender, int numberStudRecord) 
            :base(surname, name, lastName, age, gender)
        {
            _numberStudRecord = numberStudRecord;
        }

        public int _NumberStudRecord { get { return _numberStudRecord; } }

        public void ShowStudetInformation()
        {
            UsefulMethods.Delimiter('*', 60);
            Console.WriteLine("Information about studen {0}." + "\n" + ShowPersonInformation() + 
                "\nNumber record: {1}", _Name, _numberStudRecord);  
        } 
    }
}