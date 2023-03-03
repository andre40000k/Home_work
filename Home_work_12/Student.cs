namespace Home_work_12
{
    public class Student : Person
    {
        protected int _NumberRecord;
        public Student(string surname, string name, string lastName, int age, string gender, int numberRecord) 
            :base(surname, name, lastName, age, gender)
        {
            _NumberRecord = numberRecord;
        }

        public void ShowStudetInformation()
        {
            Console.WriteLine("Information about studen {0}." + "\n" + ShowPersonInformation() + "\nNumber record: {1}", _Name, _NumberRecord );
        }
    }
}