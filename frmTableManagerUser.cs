using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnUngDung
{
    public partial class frmTableManagerUser : Form
    {
        public frmTableManagerUser()
        {
            InitializeComponent();
        }

        private void frmTableManager_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan f = new frmThongTinTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiMatKhau f = new frmThayDoiMatKhau();
            this.Hide();
            f.ShowDialog();
        }

        private void flTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemThongTin f = new frmXemThongTin();
            this.Hide();
            f.ShowDialog();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDonahThu f = new frmBaoCaoDonahThu();
            this.Hide();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
