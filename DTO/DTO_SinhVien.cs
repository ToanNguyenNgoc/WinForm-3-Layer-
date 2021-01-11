using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        private string _SV_MSV;
        private string _SV_TENSINHVIEN;
        private string _SV_LOP;
        private string _SV_GIOITINH;
        private int _SV_DIEM;

        public string SV_MSV
        {
            get { return _SV_MSV; }
            set { _SV_MSV = value; }
        }
        public string SV_TENSINHVIEN
        {
            get { return _SV_TENSINHVIEN; }
            set { _SV_TENSINHVIEN = value; }
        }
        public string SV_LOP
        {
            get { return _SV_LOP; }
            set { _SV_LOP = value; }
        }
        public string SV_GIOITINH
        {
            get { return _SV_GIOITINH; }
            set { _SV_GIOITINH = value; }
        }
        public int SV_DIEM
        {
            get { return _SV_DIEM; }
            set { _SV_DIEM = value; }
        }
        public DTO_SinhVien(string msv, string tensinhvien, string lop, string gioitinh, int diem)
        {
            this.SV_MSV = msv;
            this.SV_TENSINHVIEN = tensinhvien;
            this.SV_LOP = lop;
            this.SV_GIOITINH = gioitinh;
            this.SV_DIEM = diem;
        }
    }
}
