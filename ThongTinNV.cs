using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CUAHANG_THUCUNG
{
    public partial class ThongTinNV : Form
    {
        DATA dl = new DATA();
        public ThongTinNV()
        {
            InitializeComponent();
        }
        public void ttnv()
        {
            DataTable a = dl.loadTTNV(QUYEN.tk, QUYEN.mk);
            foreach (DataRow r in a.Rows)
            {
                txt_MANV.Text = r[0].ToString();
                txt_Hoten.Text = r[1].ToString();
                //dateTimePicker1.Value = DateTime.Parse(r[3].ToString());
                txt_SDT.Text = r[4].ToString();
                txt_DiaChi.Text = r[5].ToString();
            }
        }

        private void ThongTinNV_Load(object sender, EventArgs e)
        {
            ttnv();
            //txt_MANV.Enabled = txt_Hoten.Enabled = dateTimePicker1.Enabled = txt_GioiTinh.Enabled =
            //    txt_DiaChi.Enabled = txt_SDT.Enabled = false;
        }

    }
}
