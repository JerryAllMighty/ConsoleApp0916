using AA = System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Button
    {
        
        static Button btn;
        int click = 0;


        
        private Button()            //지우면 안된다 왜냐면 컴파일러가 넣어주는 생성자는 퍼블릭이라서 //이게 있어야 외부에서 new로 인스턴스를 더이상 못 만드니까
        {
        }

        public static Button CreateInstanceBinder()            //최소 인스턴스 하나는 있어야 하니까 만들 수 있게 해주는 역할
        {
            if (btn == null)
            {
                btn = new Button();
            }
                return btn;


        }
        public void Click()
        {
            click++;
            AA.Console.WriteLine(click);
        }
    }

    class ClickCount
    {
        static void Main (string [] args)
        {

            if (args.Length == 2)
            { AA.Console.WriteLine(args[0] + "/" + args[1]); }


            Button b1 = Button.CreateInstanceBinder();
            b1.Click();
            b1.Click();
            b1.Click();

            Button b2 = Button.CreateInstanceBinder();
            b2.Click();

            
        }

        
    }
}
