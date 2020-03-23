using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    public class HourlyEmployee : Employee
    {
        public static HourlyEmployee[] arrHourly;
        public double Wage { get; set; }
        public double WorkingHours { get; set; }
        public string department { get; set; }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override string getFirstName()
        {
            throw new NotImplementedException();
        }

        public override string getLastName()
        {
            throw new NotImplementedException();
        }

        public override string getSSN()
        {
            throw new NotImplementedException();
        }

        public override void setFirstName()
        {
            throw new NotImplementedException();
        }

        public override void setLastName()
        {
            throw new NotImplementedException();
        }

        public override void setSSN()
        {
            throw new NotImplementedException();
        }
    }
}
