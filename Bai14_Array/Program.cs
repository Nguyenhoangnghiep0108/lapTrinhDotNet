using System;
using System.Text;

namespace Bai14_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập số lượng phần tử cần tạo
            Console.Write("Nhập vào số lượng phần tử cần tạo: ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo mảng với số lượng phần tử do người dùng nhập
            int[] a = new int[n];

            // Tạo số ngẫu nhiên và gán vào mảng
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(0, 100); // Số ngẫu nhiên từ 0 đến 99
            }

            // In ra giá trị của mảng sau khi gán số ngẫu nhiên
            Console.WriteLine("Giá trị của mảng sau khi nhận số random:");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); // Xuống dòng sau khi in mảng

            // Một số ví dụ khác về khởi tạo mảng
            int[] e = { 1, 3, 2, 4, 5, 6, 7 }; // Khởi tạo trực tiếp
            float[] b = new float[10];        // Khởi tạo mảng float rỗng
            float[] c = new float[10];        // Khởi tạo khi khai báo
            //Khai bao mang 2 chieu
            float[,] d = new float[3, 2] { { 1, 2 }, { 1, 2 }, { 1, 2 } };//3 dong 2 cot
            // In thử mảng e
            Console.WriteLine("Mảng e gồm các phần tử:");
            foreach (int i in e)
            {
                Console.Write(i + " ");
            }
            Array.Reverse(a);//Đảo ngược mảng lại
            Console.WriteLine("Mảng a sao khi đảo ngược là:");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Array.Sort(a);
            Console.WriteLine("Mảng a sao khi sắp xếp là:");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Kết quả sao khi tính tổng là :");
            int tong = 0;
            foreach(int i in a)
            {
                tong = tong + i;
            }
            Console.Write(tong);
            foreach (int i in d)
            {
                Console.Write(i + " ");
            }
            //Dung getlen de in mang ra
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    Console.Write(d[i,j]+"\t");
                }
            }
        }
    }
}
