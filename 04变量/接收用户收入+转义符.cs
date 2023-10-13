using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04变量
{
    internal class 接收用户收入
    {
        static void Main02(string[] args)
        {
            Console.WriteLine("input");
            //字符串比较合适可以接收 数字 小数 字符串
            string str = Console.ReadLine();
            Console.WriteLine("name: {0}", str);


            //直接这样写
            int score = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            /*
                \n 表示换行
                \"表示一个英文半角的双引号
                \t表示一个TAB键的空格
                \b 表示一个退格键，放到字符串的两边没有效果
                \\表示一个\

                @符号
                1.取消\在字符串中的转义作用2.将字符串按照编辑的原格式输出
             */

        }
    }
}
