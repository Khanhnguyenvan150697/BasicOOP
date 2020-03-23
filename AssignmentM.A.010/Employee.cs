using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    public abstract class Employee : IPayable
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }

        public Employee()
        {

        }
        public Employee(string ssn, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }

        public abstract string getSSN();
        public abstract void setSSN();
        public abstract string getFirstName();
        public abstract void setFirstName();
        public abstract string getLastName();
        public abstract void setLastName();

        public abstract void Display();
        public double GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
