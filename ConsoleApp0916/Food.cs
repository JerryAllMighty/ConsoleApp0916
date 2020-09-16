using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Food : ForInheritance
    {
        public override int CheckErr(string str)
        {
            int number;
            bool bFlag = int.TryParse(str, out number);
            if (bFlag)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Error! 숫자로 입력해달라능!!")
                    Console.WriteLine( "123" ); ;
                return 0;
            };
        }
    }
}
