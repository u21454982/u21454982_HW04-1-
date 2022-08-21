using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454982_HW04_1_.ViewModels
{
    public class DriverViewModel : Applicant
    {
        private string _JobDescription;
        private string _DrivingExp;
        private int _LisenceAge;

        public DriverViewModel(string name, string surname, string jobdescription, int age, string drivingexp, int licenseage) : base(name, surname, age)
        {

            _JobDescription = jobdescription;
            _DrivingExp = drivingexp;
            _LisenceAge = licenseage;
        }


        public string JobDescription
        {
            get { return _JobDescription; }
            set { _JobDescription = value; }
        }

        public string DrivingExp
        {
            get { return _DrivingExp; }
            set { _DrivingExp = value; }
        }
        public int LisenceAge
        {
            get { return _LisenceAge; }
            set { _LisenceAge = value; }
        }

        public override string getInfo()
        {
            return base.getInfo() + " and has " + LisenceAge + " years driving experience.";
        }

        public override string Jobless()
        {
            return "Young and eager to work hard and give it everything I got.";
        }
    }
}