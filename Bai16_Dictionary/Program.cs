namespace Bai16_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai bao
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //Them gia tri
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { {1,"NguyenHoangNghiep"},{2,"NguyenHoangNghiep"} };
            //VD1:Key MaSSV Value HoTen
            Dictionary<int, string> dicSV = new Dictionary<int, string>() { {234065,"NguyenHoangNghiep" },{223312,"NguyenNgocMinhAnh"},{222211,"NguyenThiMinhChau"}  };
            //Phuong thuc add(them mot phan tu moi vao dic)
            dicSV.Add(423322, "NguyenThiCamTu");
            //Duyet  dic
            foreach(KeyValuePair <int,string> kpm in dicSV)
            {
                Console.WriteLine(kpm);//Lay ra ca cap du lieu
                Console.WriteLine(kpm.Key);//Lay ra 1 cot du lieu

            }
            //Kiem tra coi gia tri co o trong dic khong
            bool kq1 = dic.ContainsValue("NguyenHoangnghiep");//Neu dung tra ve true nguoc laij false
            //Lay gia tri tu key
            string name = dic[234065];//Ket qua se in ra duoc NguyenHoangNghiep
            //Xoa phan tu theo key
            dic.Remove(1);//No se xoa NguyenHoangNghiep ra khoi dic
            //Xoa toan bo phan tu 
            dic.Clear();//Xoa toan bo key va value trong dic
            //Chuyen dic sang list
            //Khai bao list
            List<int> listdic = new List<int>();
            listdic = dicSV.Keys.ToList();//Chuyen value thi thay tham so value
        }
    }
}
