using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class PC_Restaurant
    {

        static void Main()
        {
            ForInheritance f1 = new ForInheritance();

            bool bFlag = true;

            while (bFlag)
            {
                Console.WriteLine("무엇을 드시겠습니까 ? 숫자로 택해주세요: \n1.뻐킹! 햄버거 \n2. 아임 어메리칸! 피자 \n3. 국민음식 치킨\n4.나의 사랑 듬뿍♡");
                int num1 = f1.CheckErr(Console.ReadLine());
                
                if (num1 == 0)
                {
                    bFlag = true;
                }
                else 
                {
                    Console.WriteLine($"{num1}을 선택하셨습니다 조금만 기다려주삼^ㅡ^");
                    break; 
                }
            }
            
            

           
        }
    }
}
