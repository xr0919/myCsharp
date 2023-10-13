using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04变量
{
    internal class 占位符
    {
        static void Main01(string[] args)
        {
            int n1 = 10;
            int n2 = 10;
            int n3 = 10;
            Console.WriteLine("第一个占位符{0}，第二个占位符{1}，第三个占位符{2}", n1, n2, n3);//多填没效果，少填异常（语法没错，但是程序运行中由于某些原因不能正常运行）


            //交换变量 不使用第三方变量
            int a = 50;
            int b = 30;

            a = a - b;//a=20
            b = a + b;//b=50
            a = b - a;//a=30
        }
    }
}
