namespace _01C_
{
    internal class Program
    {
        static void Main00(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();//暂停当前程序,待用户按下任意键继续，按下的任意键将显示在控制台中
            Console.WriteLine("222Hello, World!");
            Console.ReadKey();//ctrl shift B 生成解决方案
        }

        /// <summary>
        /// 返回两个整数最大整数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>返回最大的整数</returns>
        public static int getMax(int a, int b)//三个斜线文档注释
        {
            return a + b;
        }
    }
}