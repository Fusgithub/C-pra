using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    //限定變量
    enum Days { Monday, Tuesday, Wenseday, Thursday, Friday, Saturday, Sunday}

    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 0;  //System.Int32 i = 0;

            //int intValue = 0;  ==  int intValue2 = new int();

            bool a = true; //System.Boolean

            Person person = new Person();
            person.age = 10;
            Console.WriteLine(person.age);

            Console.WriteLine(Days.Monday);

            var day = Days.Thursday;
            Console.WriteLine((int)day);
            Console.ReadLine();
        }


        struct Person {
            //struct 打包封裝比較小的數值集  可做class大部分的工作
            //public  private internal protected
            public int age;
            public string name;
            public string fname;
            public string lastName; 
        }
    }
}
