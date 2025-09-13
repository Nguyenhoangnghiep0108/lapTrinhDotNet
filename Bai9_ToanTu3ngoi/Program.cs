namespace Bai9_ToanTu3ngoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dtb;
            Console.WriteLine("Vui long nhap diem trung binh");
             dtb = double.Parse(Console.ReadLine());
            string kq = (dtb > 8) ? "Gioi" : (dtb < 8 && dtb > 6.5) ? "Kha" : "Yeu";
            Console.WriteLine(kq);
        }
    }
}
