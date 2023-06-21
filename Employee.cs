using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_full_task
{
    internal abstract class Employee
    {
        public string name;
        public string departement;
        public double salary;
        public Employee(string name, string departement, double salary)
        {
            this.name = name;
            this.departement = departement;
            this.salary = salary;
        }
        public abstract void CalculatePay();
    }
    internal class Manager : Employee
    {
        public int numberOfManageEmployee;

        public Manager(string name, string departement, double salary, int numberOfManageEmployee) : base(name, departement, salary)
        {
            this.numberOfManageEmployee = numberOfManageEmployee;
        }

        
        
        public override void CalculatePay()
        {
            Console.WriteLine("the payment for managers =  " + (this.salary * numberOfManageEmployee));
        }
    }

    internal class Secretary : Employee
    {
        public int numberOfHoursPerWeek;
        public Secretary(string name, string departement, double salary, int numberOfHoursPerWeek) : base(name, departement, salary)
        {
            this.numberOfHoursPerWeek = numberOfHoursPerWeek;
        }
        public override void CalculatePay()
        {
            Console.WriteLine("the payment for security employers =  " + (this.salary * numberOfHoursPerWeek*4));//there work for one munth 4 weeks
        }
    }
}
