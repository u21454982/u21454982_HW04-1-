using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454982_HW04_1_.ViewModels
{
    public abstract class Applicant
    {
        private int _Age;
        private string _Name;
        private string _Surname;
        

        public Applicant(string name, string surname, int age)
        {
            _Name = name;
            _Surname = surname;
            _Age = age;
           
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }

        }
        

        public virtual string getInfo()
        {
            return Name + " " + Surname + " is " + Age.ToString() + " years old.";
        }

        public abstract string Jobless();

    }
}