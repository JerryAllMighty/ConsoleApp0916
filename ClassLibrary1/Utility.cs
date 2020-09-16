using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Utility       //>>기본적으로 인터널!
    {  //문자열을 int로 형변환
        public static int ConvertInt(string str)
        {

            int num;
            bool bFlag = int.TryParse(str, out num);
            if (!bFlag)
            {
                num = 0;
            }
            return num;
            //int num = 0;
            //bool bFlag = false;
            //while (!bFlag)
            //{
            //    bFlag = int.TryParse(Console.ReadLine(), out num);          //콘솔에서만 쓰일 수 있다. 윈폼에서는 못 쓴다
            //}
            //if (!bFlag)
            //{
            //    num = 0;
            //}

            //return num;


        }

        //문자열을 double로 변환
        public static double ConvertDouble(string str)
        {
            double num;
            bool bFlag = double.TryParse(str, out num);
            if (!bFlag)
            {
                num = 0.0;
            }
            return num;
         }
    }
}
