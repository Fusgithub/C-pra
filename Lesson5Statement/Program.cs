using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region condition
            bool condition = true;
            if (condition)
            {
                Console.WriteLine("condition is true");
            }

            int ten = 10;
            if (ten > 0)
            {
                Console.WriteLine("ten > 0");
            }

            if (!false)
            {
                Console.WriteLine("not false");
            }

            if (!false && false)  //&&:and , ||:or   //& , | 兩者都會運算，會出現例外錯誤
            {
                Console.WriteLine("True");
            }



            if (ten > 100)
            {
                Console.WriteLine("ten > 100");
                if (true)
                {
                    Console.WriteLine("true and true");
                }
            }
            else if (ten > 5)
            {
                Console.WriteLine("ten > 5 and ten <= 100");
            }
            else
            {
                Console.WriteLine("ten <= 5");
            }

            //?: 運算子
            ten = 101;
            int ifelse = ten < 100 ? ten : 99;
            Console.WriteLine(ifelse);

            int switchKey = 100;
            switch (switchKey)
            {
                case 10:
                    Console.WriteLine("switchKey is 10");
                    break;
                case 100:
                    Console.WriteLine("switchKey is 100");
                    break;
                default:
                    Console.WriteLine("I don't know switchKey");
                    break;
            }
            #endregion
            int i;
            int j = 10;
            for(i = 0, Console.WriteLine("Start:{0}", i); i < j; i++, j--, Console.WriteLine("i={0}, j={1}", i, j))
            {
                Console.WriteLine("Body of the loop");
            }

            bool stop = false;
            for(; !stop; )
            {
                stop = true;
                Console.WriteLine("Can u stop");
            }

            List<int> listInt = new List<int>() { 1, 2, 3 };
            foreach (var intInList in listInt)
            {
                Console.WriteLine(intInList);
            }

            int n = 1;
            //n++ 未加前先判斷
            //++n 加完後判斷
            while (n++ < 6)  
            {
                Console.WriteLine("n is {0}", n);
            }

            do
            {
                Console.WriteLine("time");
            }
            while (false);
            Console.ReadLine();
        }
    }
}
