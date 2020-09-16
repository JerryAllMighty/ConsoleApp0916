using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Calc      //기능만 있는 클래스  //메인 함수가 없는 클래스
    {
        int result;     //연산 결과

        public int Plus(int a, int b)
        {
            result = a * b;
            return result;
        }

        public int Minus(int a, int b)
        {
            result = a * b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            result = a * b;
            return result;
        }

        public int Divide(int a, int b)
        {
            result = a * b;
            return result;
        }

        //체크항목
        //숫자 입력란에 문자를 입력했을 떄
        public int CheckErr(string str)
        {
            int number;
            bool bFlag= int.TryParse(str, out number);
            if (bFlag)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Fail, 숫자로 다시 입력하십시오");
                return 0;
            }
        }
    }
}
