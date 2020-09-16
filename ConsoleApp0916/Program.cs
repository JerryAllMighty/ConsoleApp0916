using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp0916
{
    class Person
    {
        string name;
        int age;
        double height;
        double weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person[] arr = new Person[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Person p1 = new Person();


                Console.WriteLine("이름을 입력하세요 : ");
                p1.Name = Console.ReadLine();

                Console.WriteLine("나이을 입력하세요 : ");
                p1.Age = ClassLibrary1.Utility.ConvertInt(Console.ReadLine());

                Console.WriteLine("키를 입력하세요 : ");
                p1.Height = ClassLibrary1.Utility.ConvertDouble(Console.ReadLine());

                Console.WriteLine("몸무게를 입력하세요 : ");
                p1.Weight = ClassLibrary1.Utility.ConvertDouble(Console.ReadLine());

                arr[i] = p1;
            }


            //입력된 정보를 출력하세요.
            foreach (Person per in arr)
            {
                Console.WriteLine($"{per.Name}, {per.Age}, {per.Height}, {per.Weight}");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"");
            }
        }
    }
}
