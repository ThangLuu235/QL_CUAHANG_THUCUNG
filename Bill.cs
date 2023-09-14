using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_CUAHANG_THUCUNG
{
    public partial class Bill : Form
    {
        Customers cm = new Customers();
        DATA nv = new DATA();
        KNCSDL dl = new KNCSDL();
        public Bill()
        {
            InitializeComponent();
        }
        public void bingding(DataTable a)
        {
            txtMaHD.DataBindings.Clear();
            comboBox1.DataBindings.Clear();
            comboBox2.DataBindings.Clear();
            dtNgayLap.DataBindings.Clear();
            dtNgayGiao.DataBindings.Clear();

            txtMaHD.DataBindings.Add("text", a, "MAHD");
            comboBox1.DataBindings.Add("text", a, "MAKH");
            comboBox2.DataBindings.Add("text", a, "MANV");
            dtNgayLap.DataBindings.Add("text", a, "NGAYLAP");
            dtNgayGiao.DataBindings.Add("text", a, "NGAYGIAO");
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            //txtMaHD.Enabled = false;
            DataTable a = nv.loadHoaDon();
            bingding(a);
            loadNhanVIen();
            loadKH();
            LoadHoaDon();
            //loadDoanhThu();
        }
        //public void loadDoanhThu()
        //{
        //    int tong = 0;
        //    for (int i = 0; i < dgvHD.RowCount - 1; i++)
        //        tong += int.Parse(dgvHD.Rows[i].Cells[5].Value.ToString());
        //    lblTongDThu.Text = tong.ToString();
        //}
        public void LoadHoaDon()
        {
            DataTable a = nv.loadHoaDon();
            dgvHD.DataSource = a;
            int i;
            for (i = 0; i < dgvHD.RowCount; i++)
            {
                dgvHD.Rows[i].ReadOnly = true;
            }

        }
        public void loadNhanVIen()
        {
            //comboBox2.DataSource = dl.loadNhanVien();
            //comboBox2.ValueMember = "MANV";
        }

        public void loadKH()
        {
            comboBox1.DataSource = nv.LoadKH();
            comboBox1.ValueMember = "MAKH";
            comboBox1.DisplayMember = "MAKH";
        }

        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {

            if (nv.capNhatThanhTien() == true)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            rs();
            //loadDoanhThu();
        }
        public void rs()
        {
            while (dgvHD.Rows.Count > 1)
            {
                dgvHD.Rows.RemoveAt(0);
            }
            dgvHD.Refresh();
            DataTable a = nv.loadHoaDon();
            bingding(a);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn xóa không?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    if (nv.xoaHoaDon(txtMaHD.Text) == true)
                    {
                        MessageBox.Show("xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("xóa thất bại");
                    }
                }
                rs();
                //loadDoanhThu();
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

            int i;
            for (i = 0; i < dgvHD.RowCount - 1; i++)
                dgvHD.Rows[i].Cells[0].ReadOnly = true;
            dgvHD.Rows[i].ReadOnly = false;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (nv.Luu() == true)
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
            rs();
            //loadDoanhThu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable a = nv.NHANVIENHD(comboBox2.Text);
            dgvHD.DataSource = a;
            int i;
            for (i = 0; i < dgvHD.RowCount; i++)
            {
                dgvHD.Rows[i].ReadOnly = true;
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            xuathoadon rpt = new xuathoadon();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
                
        }

        

    }
}
