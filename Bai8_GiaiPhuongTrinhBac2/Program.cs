namespace Bai8_GiaiPhuongTrinhBac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doan ma giai phuong trinh bac 2");
            float a, b, c;
            Console.WriteLine("Nhap gia tri cua  ax^2 + bx + c = 0");
            Console.WriteLine("Hay nhap tham so: a x^2 + bx + c = 0");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            Console.WriteLine($"Phuong trinh ban vua nhap la ; {a}x^2 + {b}x + {c} = 0");
            double denTa;
            denTa = b * b - 4 * a * c;
            if (denTa < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                if (denTa == 0)
                {
                    float x1;
                    x1 = -b / 2 * a;
                    Console.WriteLine($"Phuong trinh co nghiem kep la : {x1}");
                }
                else
                {
                   Double x2, x3;
                    x2 = - b + Math.Sqrt(denTa)/ 2 * a;
                    x3 = -b - Math.Sqrt(denTa) / 2 * a;
                    Console.WriteLine($"Phuong trinh co 2 nghiem x1 = {x2} va x2 = {x3}");
                }
            }
        }
    }
}
