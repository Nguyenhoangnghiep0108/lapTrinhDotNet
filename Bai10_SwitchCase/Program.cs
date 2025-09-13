namespace Bai10_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 so de kiem tra chan le ");
            int soCanKiemTra;
            soCanKiemTra = int.Parse(Console.ReadLine());
            int chanle = soCanKiemTra % 2;
            switch (chanle)
            {
                case 0:
                    Console.WriteLine("Day la so chan");
                    break;
                default:
                    Console.WriteLine("Day la so le");
                    break;
            }
        }
    }
}
