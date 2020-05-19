using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //object, string, dynamic
            //System.Object, System.String, System.Dynamic
            object o = new object();
            object o2 = new System.Object();
            Console.WriteLine(o.GetType());
            Console.WriteLine(o.ToString());
            int i = 5;
            Console.WriteLine(i.ToString());

            string s = "jikexuieyuan";
            string s2 = "jike";
            s2 += "xuieyuan";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s == s2);
            Console.WriteLine((object)s == (object)s2); //string相等  object並不相等->對其重載

            char c = s[2];
            Console.WriteLine(c);

            string u = "\\\u0066\n";  //unicode
            Console.WriteLine(u);
            // \表unicude => 若開頭加@ -> \不會被轉成unicode
            string at = @"C:\jikexueyuan\hello.cs";
            Console.WriteLine(at);
            String noAt = "C:\\jikexueyuan\\hello.cs";
            Console.WriteLine(noAt);
            at.Contains("jike"); //是否包含
            Console.WriteLine(at.Length);
            Console.WriteLine(at.IndexOf("ji"));

            StringBuilder builder = new StringBuilder(); //可變動的字符串
            builder.Append("jike");
            builder.Append("xueyuan");
            Console.WriteLine(builder);
            builder.AppendFormat(" hello{0}", "jikexueyuan");
            Console.WriteLine(builder);
            builder.AppendFormat(" hello{0} {1}", "jikexueyuan", " world");
            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}