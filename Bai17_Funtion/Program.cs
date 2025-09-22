namespace Bai17_Funtion
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int tinhtong(int a, int b, int c)
        {
            return a + b + c;
        }
        static int daythua(int a)
        {
            int tich = 1;
            for (int i = a; i > 1; i--)
            {
                tich *= i; 
            }
            return tich;
        }


        static void Main(string[] args)
        {
            int a = tinhtong(1, 2, 3);
            Console.WriteLine(a);
            int b = daythua(5);
            Console.WriteLine(b);
        }
    }
}
