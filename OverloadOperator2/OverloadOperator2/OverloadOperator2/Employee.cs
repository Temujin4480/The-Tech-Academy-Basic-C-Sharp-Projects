using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator2
{
    public class Employee
    {
        public Employee(string Name, int EmployeeID)
        {
            Name = "El Guapo";
            EmployeeID = 001;
        }

        public string Name { get; set; }
        public int EmployeeID { get; set; }

        //The comparison operators, if overloaded, must be overloaded in pairs; that is, if == is overloaded, != must also be 
        //overloaded. The reverse is also true, where overloading != requires an overload for ==. The same is true for comparison 
        //operators < and > and for <= and >=.  You have to implement == for two objects.

        //Try another way (also didn't work): 
        //public static bool operator ==(Employee emp1, Employee emp2)
        //{
        //    bool status = false;
        //    if (emp1 == emp2)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}

        //public static bool operator !=(Employee emp1, Employee emp2)
        //{
        //    bool status = true;
        //    if (emp1 != emp2)
        //    {
        //        status = false;
        //    }
        //    return status;
        //}

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1 == emp2)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return Comparison(emp1, emp2) == 0; // Comparison(emp1, emp2) ==0 implies that emp1 equals emp2
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1 != emp2)
            {
                return false;
            }
            else
            {
                return true;
            }
            //return Comparison(emp1, emp2) != 0;
            //}
            //public override bool Equals(object obj)
            //{
            //    if (!(obj is Employee)) return false;
            //    return this == (Employee)obj;
            //}
            //public static int Comparison(Employee emp1, Employee emp2)
            //{
            //    if (emp1.EmployeeID == emp2.EmployeeID)
            //        return 0;
            //}
        }
}
