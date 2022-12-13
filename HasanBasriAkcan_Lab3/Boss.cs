using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasanBasriAkcan_Lab3
{
    public class Boss : Person
    {
        public int EmployeeNumber { get; set; }
        public int EmployeeSalary { get; set; }

        public Boss(string firstName, string lastName, int employeeNumber, int employeeSalary) : base(firstName, lastName)
        {
            EmployeeNumber = employeeNumber;
            EmployeeSalary = employeeSalary;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Employee Number: " + EmployeeNumber, "\nEmployee Salary: " + EmployeeSalary);
        }

    }
}
