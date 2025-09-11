namespace ToanTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai bao va nhap lieu
            float x ,y ;
            Console.WriteLine("Nhap gia tri cua x va y");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            // Cac toan tu
            Console.WriteLine("Toan tu x++");
            float x1 = ++x;
            float x2 = x*y; 
            float x3 = x/y;
            float x4 = x%y;
            Console.WriteLine($"Gia tri cua toan tu ++x la : {x1}");
            Console.WriteLine($"Gia tri cua toan tu X * y la : {x2}");
            Console.WriteLine($"Gia tri cua toan tu X / y la : {x3}");
            Console.WriteLine($"Gia tri cua toan tu X % y la : {x4}");

        }
    }
}
