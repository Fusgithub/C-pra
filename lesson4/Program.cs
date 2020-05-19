using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(5);
            Console.WriteLine(person.GetAge());
            Console.WriteLine(Person.GetFive());
            Console.WriteLine(person.Age);
            person.Age = 10;
            Console.WriteLine(person.GetAge());
            Console.ReadLine();
        }
    }

    class Person : man, ISuper
    {
        int age;

        //屬性創建
        public int Age
        {
            get
            {
                return age + 10;
            }
            set
            {
                age = value - 10;
            }
        }

        //每個class都自帶一個默認的構造函式
        public Person(int myAge)
        {
            this.age = myAge;  //age = myAge;
        }



        public int GetAge()  //方法
        {
            return age;
        }

        public static int GetFive()
        {
            return 5;
        }

        public int GetSuper()
        {
            return age + 100;
        }

        public override int GetAbstract()
        {
            return 50;
        }
    }

    abstract class man
    {
        public string name;

        public string GetName()
        {
            return name;
        }
        public abstract int GetAbstract();
    }

    interface ISuper
    {
        int GetSuper();
    }
}