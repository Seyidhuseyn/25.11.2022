using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Employee
    {
        public string name;
        public bool issuccessful;
        public double salary;


        public string Name 
        { 
            get=> name ;
            set
            { 
                name = value; 
            }
        }
        public bool IsSuccessfull
        {
            get => issuccessful;
            set
            {
                issuccessful = value;
            }
        }

        public double Salary
        {
            get => salary;
            set
            {
                salary = value;
            }
        }
    }

}
