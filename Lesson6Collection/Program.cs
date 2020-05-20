using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array

            int[] numbers = new int[5];
            string[,] names = new string[5, 4];
            byte[][] scores = new byte[5][];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }

            int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers4 = { 1, 2, 3, 4, 5 };

            string[,] names2 = { { "g", "k" }, { "h", "j" } };
            int[][] numberss = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };

            Console.WriteLine(numbers2[2]);
            Console.WriteLine(numbers2.Length);

            foreach(int i in numbers2)
            {
                Console.WriteLine(i);
            }
            #endregion
            //System.Collections
            //ArrayList 可儲存多種不同類型的元素
            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add(100);
            al.Remove(5);
            al.Add("jikexueyuan");

            foreach(var e in al)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(al[0]);

            //List 只能儲存同一類型的元素
            List<int> intList = new List<int>();
            intList.Add(500);
            intList.AddRange(new int[] { 501, 502 });
            Console.WriteLine(intList.Contains(200));
            Console.WriteLine(intList.IndexOf(501));
            intList.Remove(501);
            intList.Insert(1, 1001);
            
            //Hashtable 沒有強制規定類型
            Hashtable ht = new Hashtable();
            ht.Add("first", "jike");
            ht.Add("second", "xueyuan");
            ht.Add(100, 100);
            Console.WriteLine(ht["second"]);
            Console.WriteLine(ht[100]);

            //Dictionary 只能儲存同一類型，線程不是安全
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("first", "jike");
            //線程安全->ConcurrentDictionary

            //經過排序的List，根據key進行排序
            SortedList<int, int> sl = new SortedList<int, int>();
            sl.Add(5, 105);
            sl.Add(2, 102);
            sl.Add(10, 99);
            foreach(var sle in sl)
            {
                Console.WriteLine(sle.Value);
            }

            //stack 先進後出, queue 先進先出
            Console.ReadLine();
        }
    }
}
