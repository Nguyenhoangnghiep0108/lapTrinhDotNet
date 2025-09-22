using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_OOP
{

    public class SinhVien//Tao doi tuong Sinh vien
    {
        //Khai bao cac phuong thuc cua sinh vien
        public int maSV;
        public string tenSV;
        public string queQuan;

        public SinhVien(int maSV, string tenSV, string queQuan)//Khai bao constructor co tham so
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.queQuan = queQuan;
        }
        public SinhVien() { //Khai bao constructor mac dinh
              this.maSV = 0;
            this.tenSV = "Noname";
            this.queQuan = "No";
        }
    }
}
