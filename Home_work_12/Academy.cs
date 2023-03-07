namespace Home_work_12
{
    public class Academy
    {
        private string _nameOfAcademy;

        public Academy(string nameOfAcademy = "Very important things") 
        {
            _nameOfAcademy = nameOfAcademy;
        }

        public string _NameOfAcademy { get { return _nameOfAcademy; } }

        public void PrintNameAcademy() => Console.WriteLine("\nName of academy: \"{0}\"", _nameOfAcademy);
    }
}