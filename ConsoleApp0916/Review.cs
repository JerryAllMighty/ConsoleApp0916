using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Review
    {
        static void Main()
        {
            Calc c1 = new Calc();
            int result;
            bool bFlag = true;
            string keep_calc;

            while (bFlag)
            {
                Console.WriteLine("연산을 원하시는 첫번째 숫자를 입력해주십시오 : ");
                int num1 = c1.CheckErr(Console.ReadLine());
                
                Console.WriteLine("연산을 원하시는 두번째 숫자를 입력해주십시오 : ");
                int num2 = c1.CheckErr(Console.ReadLine());

                Console.WriteLine("원하시는 연산를 입력해주십시오 : +, -, *, / 중 선택해주십시오 ");
                string Yeonsan = Console.ReadLine();

                if (Yeonsan == "+")
                {
                    result = c1.Plus(num1, num2);
                }

                else if (Yeonsan == "-")
                {
                    result = c1.Minus(num1, num2);
                }

                else if (Yeonsan == "*")
                {
                    result = c1.Multiply(num1, num2);
                }
                else
                {
                    result = c1.Divide(num1, num2);
                }

                Console.WriteLine($"연산 결과값 : {result}");
                Console.WriteLine("다시 계산하시겠습니까? : 예 혹은 아니오로 입력하시오");
                keep_calc = Console.ReadLine();

                if (keep_calc == "예")
                {

                }
                else if (keep_calc == "아니오")
                {
                    bFlag = false;
                }
            }
            Console.WriteLine("수고하셨습니다");
        }
    }
}
