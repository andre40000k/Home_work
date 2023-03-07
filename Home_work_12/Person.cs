namespace Home_work_12
{    
    public class Person
    {
        private string _surname;
        private string _name;
        private string _lastName;
        private int _age;
        private string _gender;
        private string? informationPerson;


        public Person(string surname, string name, string lastName, int age, string gender)
        {
            _surname = surname;
            _name = name;
            _lastName = lastName;
            _age = age;
            _gender = gender;
        }

        public string _Surname { get { return _surname;} }
        public string _Name { get { return _name; } }
        public string _LastName { get { return _lastName;} }
        public int _Age { get { return _age;} }
        public string _Gender { get { return _gender;} }

        public string ShowPersonInformation()
        {
            informationPerson = $"Full name: {_surname} {_name} {_lastName}" +
                $"\nAge: {_age}" + 
                $"\nSex: {_gender}";

            return informationPerson;
        }        
    }
}