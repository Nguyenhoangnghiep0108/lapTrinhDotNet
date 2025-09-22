using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_OOP
{

    public class SinhVien//Tao doi tuong Sinh vien
    {
        #region khai bao thuoc tinh cua sinh vien
        private int maSV;
        private string hoTen;
        #endregion
        //Khoi tao constructor khogn tham so
        public SinhVien()
        {
            this.maSV = 0;
            this.hoTen = "No Name";
        }
        //Khoi tao constructor co tham so
        public SinhVien(int maSV,string hoten)
        {
            this.maSV = maSV;
            this.hoTen = hoten;
        }
        //Khai bao properties cho nguoi dung sua xoa khi sai private
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; } 
        }
        //Phuong thuc tostring
        public override string ToString()
        {
            return this.MaSV + "   " + this.HoTen; ;
        }
        public double TinhTong(params float[] mang)
        {
            float  s = 0;
            foreach (float i in mang)
            {
                s = s + i;
            }
            return s;

        }
    }   
}
