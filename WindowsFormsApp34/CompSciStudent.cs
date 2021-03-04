using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp34
{
    class CompSciStudent : Student
    {
        private double MATH_Hours = 20;
        private double CS_HOURS = 40;
        private double GEN_Hours = 60;

        private string _academicTrack;

        public CompSciStudent(string name, string id, string track) : base(name, id)
        {
            _academicTrack = track;
        }
        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }
        public override double RequiredHours
        {
            get { return MATH_Hours + CS_HOURS + GEN_Hours; }
        }
    }
}
