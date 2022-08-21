using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454982_HW04_1_.ViewModels
{
    public class AdminViewModel : Applicant
    {
        
        private string _AdminExp;
        private string _CommunicationSkill;

        public AdminViewModel(string name, string surname, int age, string adminexp, string communicationskill) : base(name, surname, age)
        {
            
            _AdminExp = adminexp;
            _CommunicationSkill = communicationskill;


        }

        
        public string AdminExp
        {
            get { return _AdminExp; }
            set { _AdminExp = value; }
        }
        public string CommunicationSkill
        {
            get { return _CommunicationSkill; }
            set { _CommunicationSkill = value; }
        }
        public override string getInfo()
        {
            return base.getInfo() + " and has " + CommunicationSkill + " communication skill.";
        }
        public override string Jobless()
        {
            return "Young and eager to work hard and give it everything I got.";
        }

    }
}