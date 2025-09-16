using System.Text;

namespace Bai14_Random_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int soNgauNhien = random.Next(0, 100);//tạo số nguyên ngãu nghiên
            Console.WriteLine(" so la " + soNgauNhien);
            double soNgauNhien1 = random.NextDouble();//lay tu 0 den 1
            Console.WriteLine(" so la L" + soNgauNhien1);
            //lau so ngau nghien 1.2 vvv
            double soNgauNhien2 = soNgauNhien+ soNgauNhien1;
            Console.WriteLine(" so ngau nhien la "+ soNgauNhien2);
            
        }
    }
}
