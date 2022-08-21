using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454982_HW04_1_.ViewModels
{
    public class FactoryViewModel : Applicant
    {

        private string _FactoryExp;
        private string _MachinerySkill;

        public FactoryViewModel(string name, string surname, int age, string factoryexp, string machineryskill) : base(name, surname, age)
        {

            _FactoryExp = factoryexp;
            _MachinerySkill = machineryskill;


        }


        public string FactoryExp
        {
            get { return _FactoryExp; }
            set { _FactoryExp = value; }
        }
        public string MachinerySkill
        {
            get { return _MachinerySkill; }
            set { _MachinerySkill = value; }
        }
        public override string getInfo()
        {
            return base.getInfo() + " and has " + MachinerySkill + " machinery skill.";
        }
        public override string Jobless()
        {
            return "Young and eager to work hard and give it everything I got.";
        }
    }
}