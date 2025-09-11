using System.Text;

namespace bai1_Bien_KieuDuLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Giúp hiện chữ tiếng việt không lỗi font
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo biến a b c kiểu double
            double a, b, c;
            //Khai bao  biến kiểu dữ liệu kiểu var lưu ý khi khai báo phải có đi kèm giá trị
            var d = 10;
            //Nhập  giá trị của a b c Dùng hàm parse vì readline nhận giá trị chuổi
            Console.WriteLine("Nhap gia tri a b c : ");
            a = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

        }
    }
}
