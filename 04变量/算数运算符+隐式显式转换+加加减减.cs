using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04变量
{
    internal class 算数运算符
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            int c = a / b;//3
            double d1 = a / b; //3 a与b原本就是整数类型 只能得3
            double d2 = a * 1.0 / b; //把一边整数类型提升为double类型
            Console.WriteLine(c);
            Console.WriteLine(d1);//3
            Console.WriteLine(d2);//3.333333333333
            Console.WriteLine("{0:0.00}",d2);//3.33小数点后留两位
            Console.WriteLine(a/b);
            Console.WriteLine("-----------");


            //类型转换 都要是数字
            //隐式转换  小转大
            int num = 10;
            double dd = num;

            //显式转换  大转小
            //语法（待转换的类型）要转换的值
            double ddd = 303.6;
            int nn = (int)ddd;//303
            Console.WriteLine(nn);
            Console.WriteLine("---------------");

            //convert类型转换 两个类型的变量不兼容
            //或者用int.Parse("123")
            /*
                int number = 0;
                bool b = int.TryParse("123abc",out number)//(参数。返回值) 成功返回true 失败返回false和0 ------ 这个更好 不会产生异常
             */
            string s = "123";
            //string s = "123abc";//程序异常
            double dc = Convert.ToDouble(s);
            int i = Convert.ToInt32(s);//int 32
            Console.WriteLine(dc);  
            Console.WriteLine(i);

            Console.WriteLine("-------------");
            //++ --
            int nu = 10;
            int result = 10 + nu++;//++放后面 先用原值去计算再++
            Console.WriteLine(nu);//11
            Console.WriteLine(result);//20  

            int aa = 5;
            int bb = aa++ + ++a * 2 + --a + a++;
                //   5    +   7*2   +  6  + 6

            Console.ReadKey();

        }
    }
}
