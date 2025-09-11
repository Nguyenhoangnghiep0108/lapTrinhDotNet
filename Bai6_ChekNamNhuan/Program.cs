namespace Bai6_ChekNamNhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chek Nam Nhuan");
            long nam;
            Console.WriteLine("Nhap Nam Can Chek");
            nam = long.Parse(Console.ReadLine());
            if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
            {
                Console.WriteLine($"Nam {nam} la nam nhuan");
            }
            else 
            {
                Console.WriteLine($"Nam {nam} khong phai la nam nhuan");
            }
        }
    }
}
