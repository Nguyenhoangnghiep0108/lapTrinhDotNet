namespace Bai4_TinhChuVi_DienTich
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Khai Bao Bien
            const float soPi = 3.14f;
            float duongKinh;
            float chieuDay;
            float chieuRong;
            float canhHinhVuong;
            
        //Tinh Chu Vi
            //Bai 1 : Tinh Chu vi hinh tron
            Console.Write("Nhap Vao duong kinh neu la ban kinh thi nhan doi : ");
            duongKinh= float.Parse(Console.ReadLine());
            float chuViTron =soPi * duongKinh;
            Console.WriteLine($"Chu vi hinh tron la : {chuViTron}");
            Console.WriteLine("====================================");

            //Bai 2 : Tinh Chu vi hinh Chu Nhat
            Console.Write("Nhap chieu rong hinh chu nhat : ");
            chieuRong = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu day hinh chu nhat :");
            chieuDay = float.Parse(Console.ReadLine());
            float chuViChuNhat = ((chieuDay + chieuRong)*2);
            Console.WriteLine($"Chu vi hinh Chu nhat la : {chuViChuNhat}");

            //Bai3: Chu vi hinh vuong
            Console.Write("Nhap vao canh cua hinh vuong ");
            canhHinhVuong= float.Parse(Console.ReadLine());
            float chuViHinhVuong = canhHinhVuong * 4;
            Console.WriteLine($"Chu vi hinh vuong la : {chuViHinhVuong}");
        }
    }
}
