using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Andy Renton";
            emp1.EmployeeID = 006;
            Employee emp2 = new Employee();
            emp2.Name = "Edward Donne";
            emp2.EmployeeID = 001;

            Employee employee = new Employee();
            employee.Comparison(emp1, emp2);

        }
    }
}
