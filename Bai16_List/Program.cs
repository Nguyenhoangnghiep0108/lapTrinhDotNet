namespace Bai16_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<kieudulieu> tenlist = new list<kieudulieu>();
            List<int> dst = new List<int>() { 1, 2, 3, 4, 5, 6 };//khoi tao list co gia tri
            foreach (int i in dst)//Duyet in ra danh sách
            {
                Console.Write(i +"\t");
            }
            //Phuong thuc add(them phan tu vao cuoi danh sach)add(so can them)
            dst.Add(100);
            Console.WriteLine("Danh sach sao khi them 1 phan tu");
            foreach (int i in dst)//Duyet in ra danh sách
            {
                
                Console.Write(i + "\t");
            }
            //Phuong thuc remove (xoa phan tu dau tien giong trong list)remove(Phan tu can xoa)
            dst.Remove(1);
            Console.WriteLine("Danh sach sao khi xoa phan tu");
            foreach (int i in dst)//Duyet in ra danh sách
            {

                Console.Write(i + "\t");
            }

            //Phuong thuc count(dem phan tu trong danh sach)
            Console.Write("\nTong so phan tu trong danh sach la: ");
            Console.Write(dst.Count());
            //Phuong thuc clear(xoa tat ca phan tu trong danh sach)
            //dst.Clear();
            //Phuong thuc addrange(Them phan tu cua danh sach nay vao cuoi cua danh sach kia) danhsach1.Addrange(Danhsach2)
            dst.AddRange(dst);
            Console.WriteLine("Danh sach sao khi cong 2 danh sach");
            foreach (int i in dst)//Duyet in ra danh sách
            {

                Console.Write(i + "\t");
            }
            //Phuong thuc bool contains(Kiem tra xem gia tri do co ton tai khong dung tra ve true no false)
            bool kq = dst.Contains(100);
            Console.Write( "\nTra ket qua sao khi tim so 100 la :"+ kq);
            //Phuong thuc Getrange( tra ve mot list con va ki tu cua list  nguon)
            List <int> list1 = dst.GetRange(2,3);//Lay tu vi tri 2 va lay 3 phan tu
            Console.WriteLine("Danh sach sao khi lay tu vi tri 2 va lay 3 phan tu");
            foreach (int i in list1)//Duyet in ra danh sách
            {

                Console.Write(i + "\t");
            }
            //Phuong thuc indexof(Tra ve vi tri tim thay gia tri do neu khong tim thay tra ve -1 neu 2 phan tu no chi tra ve gia tri tim thay dau tien)
            int chek = dst.IndexOf(100);
            Console.Write("Ket qua sao khi chek 100 :");
           Console.WriteLine(chek + "\t");
            //Phuong thuc insert(Them 1 phan tu vao liss o vi tri nao do)
            dst.Insert(0, 999);
            Console.WriteLine("Ket qua sao khi them ");
            foreach (int i in dst)//Duyet in ra danh sách
            {

                Console.Write(i + "\t");
            }
            //Phuong thuc con lai
            dst.InsertRange(2, list1);//chen list1 vao dst o vi tri 2 cua dst
            dst.RemoveAt(1);//Xoa gia tri o vi tri 1
            dst.RemoveRange(2, 3);//Xoa phan tu tu vi tri 2 va xoa 3 phan tu
            dst.Reverse();//Dao nguoc danh sach
            dst.Sort();//Sap xep danh sach tang dan
            dst.BinarySearch(50);//Tim kim nhi phan "SAP XEP MS DUNG DUOC"
            dst.Max();//Tim so lon nhat
            dst.Min();//Tim so be nhat
        }
    }
}
