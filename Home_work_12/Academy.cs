using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_work_12
{
    public class Academy
    {
        private string _Name_Of_Academy;

        public Academy(string nameOfAcademy = "Very important things") 
        {
            _Name_Of_Academy = nameOfAcademy;

        }

        public void Print() => Console.WriteLine("Name of academy: \"{0}\"", _Name_Of_Academy);
    }
}