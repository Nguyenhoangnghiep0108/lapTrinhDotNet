namespace Bai7_ChekThangBaoNgay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang;
            Console.WriteLine("Nhap thang can chek ngay");
            thang = int.Parse(Console.ReadLine());
            if(thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                Console.WriteLine($"Thang {thang}nay co 31 ngay");
            }
            else
            {
                if (thang == 2)
                {
                    Console.WriteLine("Vui long nhap nam");
                    long nam;
                    nam = long.Parse(Console.ReadLine());
                    if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
                    {
                        Console.WriteLine($"Thang 2 nam {nam} co 29 ngay");
                    }
                    else
                    {
                        Console.WriteLine($"Thang 2 {nam}  co 28 ngay");
                    }
                }
            }
        }
    }
}
