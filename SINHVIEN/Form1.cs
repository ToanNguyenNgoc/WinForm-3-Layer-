using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using BUS;

namespace SINHVIEN
{
    public partial class Form1 : Form
    {
        BUS_SinhVien busSV = new BUS_SinhVien();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSV.getSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(txtID.Text !="" && txtName.Text !="" && txtClass.Text != "" && comSex.Text != "" && txtScore.Text != "")
            {
                DTO_SinhVien sv = new DTO_SinhVien(txtID.Text, txtName.Text, txtClass.Text, comSex.Text, Int32.Parse(txtScore.Text));
                if (busSV.themSinhVien(sv))
                {
                    MessageBox.Show("Them thanh cong");
                    dataGridView1.DataSource = busSV.getSinhVien();
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text= row.Cells[1].Value.ToString();
            txtClass.Text= row.Cells[2].Value.ToString();
            comSex.Text= row.Cells[3].Value.ToString();
            txtScore.Text= row.Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtID.Text = row.Cells[0].Value.ToString();
            DTO_SinhVien sv = new DTO_SinhVien(txtID.Text, txtName.Text, txtClass.Text, comSex.Text, Int32.Parse(txtScore.Text));
            if (busSV.suaSinhVien(sv))
            {
                MessageBox.Show("Cap nhat thanh cong");
                dataGridView1.DataSource = busSV.getSinhVien();
            }
            else
            {
                MessageBox.Show("Cap nhat that bai");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string msv = row.Cells[0].Value.ToString();
            if (busSV.xoaSinhVien(msv))
            {
                MessageBox.Show("Xoa that bai");
                
            }
            else
            {
                dataGridView1.DataSource = busSV.getSinhVien();
                MessageBox.Show("Xoa thanh cong");
                txtID.Text = "";
                txtName.Text = "";
                txtClass.Text = "";
                comSex.Text = "";
                txtScore.Text = "";
            }
        }
    }
}
