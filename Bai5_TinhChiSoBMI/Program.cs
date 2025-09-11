namespace Bai5_TinhChiSoBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien luu can nang va chieu cao
            float weight, hight;
            Console.Write("Nhap vao can nang cua ban: ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao Chieu Cao cua ban: (VD:1m8 = 1.8) ");
            hight = float.Parse(Console.ReadLine());
            float bMI = weight / (hight*2);
            Console.WriteLine("Chi so BIM cua ban la {0}", bMI);
            if (bMI < 18.5)
            {
                Console.WriteLine("Ban can phai tang can");
            }
            else
            {
                if (bMI >= 18.5 && bMI <= 22.9) {
                    Console.WriteLine("Ban dang rat khoe");
                }
                else
                {
                    if(bMI >= 23 && bMI <= 24.9)
                    {
                        Console.WriteLine("Ban dang thua can ");
                    }
                    else
                    {
                        if(bMI >=25 && bMI <= 29.9){
                            Console.WriteLine("Ban can phai giam can ngay");
                        }
                        else
                        {
                            Console.WriteLine("Tinh Trang ban dang cap bao nen den gap bac si ngay");
                        }
                    }
                }
            }
        }
    }
}
