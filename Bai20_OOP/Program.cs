namespace Bai20_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sinhVien1 = new SinhVien(234065,"NguyenHoangNghiep","Vinhlong");
            Console.WriteLine(sinhVien1.maSV);
            SinhVien sinhVien3 = new SinhVien();
            Console.WriteLine(sinhVien3.maSV);

        }
    }
}
