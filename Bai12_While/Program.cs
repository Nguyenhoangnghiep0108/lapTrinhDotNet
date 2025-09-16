namespace Bai12_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bienSo;
            Console.WriteLine("Vui long nhap so tu 1 den 99");
            bienSo = int.Parse(Console.ReadLine());
            while(bienSo < 1 || bienSo > 99)
            {
                Console.WriteLine($"Ban da nhap so vuoc gioi han cho phep {bienSo}");
                bienSo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Ban da nhap so {bienSo}");
            int a = 1;
            while (true)//no tro thanh vong lap vo tan
            {
                Console.WriteLine($"{a}");
                a++;
            }
        }
    }
}
