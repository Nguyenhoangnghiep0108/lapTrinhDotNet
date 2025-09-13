namespace Bai11_XayDungMenuLuaChon_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chao ban day la menu lua chon thao tac\n" +
                "1.Tim theo ten \n" +
                "2.Tim theo tac gia\n" +
                "3.Tim theo nha xuat ban\n" +
                "4.Tim theo tieu de\n" +
                "5.Thoat");
            int bienNhap;
            bienNhap = int.Parse(Console.ReadLine());
            switch (bienNhap)
            {
                case 1:
                    Console.WriteLine("Ban chon thao tac tim theo ten");
                    break;
                case 2:
                    Console.WriteLine("Day la thao tac tim theo tac gia");
                    break;
                case 3:
                    Console.WriteLine("Day la thao tac tiem theo nha xuat ban");
                    break;
                case 4:
                    Console.WriteLine("Day la thao tac tiem theo tieu de");
                    break;
                default:
                    break;
            }
        }
    }
}
