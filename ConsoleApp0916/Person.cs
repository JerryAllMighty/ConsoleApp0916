using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Man 
    {
        private string fName;

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }


        public virtual void PrintInfo()
        {
            Console.WriteLine("==========Man==========");
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}" , lName );
            Console.WriteLine("=======================");
        }

        public override string ToString()
        {
            return $"{fName}{lName}";
        }
    }

    class Employee : Man
    {
        int employeeID;

        public Employee(int employeeID)
        {
            this.employeeID = employeeID;
        }


        public override void PrintInfo()
        {
            Console.WriteLine("==========Employer==========");
            Console.WriteLine(" employeeID : {0}", employeeID);
            Console.WriteLine("First Name : {0}", this.FirstName);
            Console.WriteLine("Last Name : {0}", this.LastName);
            Console.WriteLine("=======================");
        }
    }


    class InheritTest
    {
        static void Main()
        {
            Man man = new Man();
            man.FirstName = "류";
            man.LastName = "현진";
            man.PrintInfo();

            Employee emp1 = new Employee(2020155);
            emp1.FirstName = "아";
            emp1.LastName = "이유";
            emp1.PrintInfo();

            Console.WriteLine(man.ToString());
        }
    }
}
