namespace Home_work_12
{    
    public class Person
    {
        protected string _Surname;
        protected string _Name;
        protected string _LastName;
        protected int _Age;
        protected string _Gender;
        private string? informationPerson;

        public Person(string surname, string name, string lastName, int age, string gender)
        {
            _Surname = surname;
            _Name = name;
            _LastName = lastName;
            _Age = age;
            _Gender = gender;
        }

        public string ShowPersonInformation()
        {
            informationPerson = $"Full name: {_Surname} {_Name} {_LastName}" +
                $"\nAge: {_Age}" + 
                $"\nSex: {_Gender}";

            return informationPerson;
        }
    }
}