using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_CK1
{
    public partial class Form1 : Form
    {
        CXulyPT xuly;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            xuly = new CXulyPT();
            hienthi(xuly.GetdsPT());
        }
        private void hienthi(List<CPhieuThue> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CPhieuThue a = new CPhieuThue();
            a.MaPT = txtMaphong.Text;
            a.NgayBD = Convert.ToDateTime(dtpNgaythue.Value);
            a.NgayKT = Convert.ToDateTime(dtpNgaytra.Value);
            a.TenKH = txtTenkhachhang.Text;
            if (rdA.Checked == true)
                a.LoaiPhong = KieuLoaiPhong.A;
            else if (rdB.Checked == true)
                a.LoaiPhong = KieuLoaiPhong.B;
            else if (rdC.Checked == true)
                a.LoaiPhong = KieuLoaiPhong.C;
            else
                a.LoaiPhong = KieuLoaiPhong.D;
            if (xuly.them(a) == true)
            {
                hienthi(xuly.GetdsPT());
            }
            else
                MessageBox.Show("Ma phieu thue da co");
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mapt = r.Cells[0].Value.ToString();
                xuly.xoa(mapt);

            }
            hienthi(xuly.GetdsPT());
        }
    }
}
