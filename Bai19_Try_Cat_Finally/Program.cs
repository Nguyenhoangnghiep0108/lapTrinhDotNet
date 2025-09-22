using System.Globalization;
using System.Text;

namespace Bai19_Try_Cat_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                StringInfo s = Console.ReadLine();
                DateTime dateTime = dateTime.Parse(s);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Vui long nhap lai du lieu ");

            }
            finally
            {
            }
        }
    }
}
