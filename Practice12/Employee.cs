using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    class Employee
    {
        protected string lastName;
        protected string firstName;
        protected string middleName;
        protected string numberPhone;
        protected string passport;
        

        public Employee(string LastName, string FirstName, string MiddleName, string NumberPhone, string Passport)
        {
            this.lastName = LastName;
            this.firstName = FirstName;
            this.middleName = MiddleName;
            this.numberPhone = NumberPhone;
            this.passport = Passport;
        }


        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string MiddleName { get { return this.middleName; } set { this.middleName = value; } }
        public string NumberPhone { get { return this.numberPhone; } set { this.numberPhone = value; } }
        public string Passport { get { return this.passport; } set { this.passport = value; } }

        
    }
}
