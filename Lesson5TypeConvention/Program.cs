using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5TypeConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = i;
            C1 c1 = new C2();

            double d = 10.05;
            int iFromD = (int)d;
            Console.WriteLine(iFromD);

            C1 c11 = new C1();
            try
            {
                C2 c2 = (C2)c11;  //無法直接強制轉換class -> try
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(c11 is C1); //判斷c11是否為C1
            Console.WriteLine(c11 is C2);

            C2 c22 = c11 as C2;  //將c11轉換為C2->無法轉換->回傳空
            Console.WriteLine(c22 == null);

            string sFromI = i.ToString();
            int iFromS = Convert.ToInt32("100");
            int iFromS2 = Int32.Parse("100");
            int iFromS3;
            bool succed = Int32.TryParse("faaaa", out iFromS3); //格式錯誤，回傳0
            Console.WriteLine(iFromS3);
            //IConvertible,TypeConventer

            int iToBoxing = 100;
            object iBoxed = iToBoxing;

            int iUnboxing = (int)iBoxed;
            object nullObject = 5;
            int iNull = (int)nullObject;

            int? iNullable = null;  //int? -> 値可以為null
            System.Nullable<int> iNullable2 = 100;  //與上相等
            Console.WriteLine(iNullable.HasValue); //iNullable.Value -> 不能顯示空値  //HasValue判斷是否為空直
            Console.WriteLine(iNullable.GetValueOrDefault()); //可顯示値，若為空顯示0

            Console.ReadLine();
        }

        class C1
        { }

        class C2 : C1
        { }
    }
}