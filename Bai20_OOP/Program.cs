namespace Bai20_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai bao sinh vien mac dinh
            SinhVien Sinhvien1 = new SinhVien();
            Console.WriteLine(Sinhvien1.HoTen);
            Console.WriteLine(Sinhvien1.MaSV);
            Console.WriteLine(Sinhvien1.ToString());
            Console.WriteLine(Sinhvien1);
            
            Console.WriteLine(Sinhvien1.TinhTong(1,2,3,4,5,1,2,32,1,1));
        }
    }
}
