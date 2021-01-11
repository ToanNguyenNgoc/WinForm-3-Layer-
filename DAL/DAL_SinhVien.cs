using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_SinhVien: DBConnect
    {
        public DataTable getSinhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SINHVIEN_TB", _conn);
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            return dtSinhVien;
        }
        public bool themSinhVien(DTO_SinhVien sv)
        {
            try
            {
                _conn.Open();
                string sql = string.Format
                    ("insert into SINHVIEN_TB(MSV, TENSINHVIEN, LOP, GIOITINH, DIEM) values('{0}','{1}', '{2}','{3}','{4}')", sv.SV_MSV, sv.SV_TENSINHVIEN, sv.SV_LOP, sv.SV_GIOITINH, sv.SV_DIEM);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }catch(Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool suaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("update SINHVIEN_TB set TENSINHVIEN='{0}', LOP='{1}', GIOITINH='{2}', DIEM='{3}' where MSV='{4}'", sv.SV_TENSINHVIEN, sv.SV_LOP, sv.SV_GIOITINH, sv.SV_DIEM, sv.SV_MSV);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }catch(Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool xoaSinhVien(string SV_MSV)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("delete from SINHVIEN_TB where MSV='{0}'", SV_MSV);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return false;
            }catch(Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
