using Microsoft.VisualBasic;
using System.Globalization;
using System.Text;

namespace Bai19_Try_Cat_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try//Toan do dong code loi
            {
                Console.OutputEncoding = Encoding.UTF8;
                String s = Console.ReadLine();
                DateTime Ngay =DateTime.Parse(s);
                Console.WriteLine("Ngay sinh cua ban la :" + Ngay.ToString("dd//mm//yyyy"));
            }
            catch(Exception ex)//Xuat thong bao chuonwg trinh bi loi j
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Cam Mon ban da su dung chuong trinh");
            }
            //Throw statement (Dua loi ra mot noi khac de hien thi)//

        }
    }
}
