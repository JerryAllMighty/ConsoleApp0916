using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class ForInheritance        //형 변환을 담당하는 클래스
    {
        public virtual int CheckErr(string str)
        {
            int number;
            bool bFlag = int.TryParse(str, out number);
            if (bFlag)
            {
                return number;
            }
            else 
            {
                Console.WriteLine("Error! 숫자로 입력해달라능!!");    
                return 0; }
        }
    }
}
