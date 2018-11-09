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
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
                
            
                frmTableManagerUser f = new frmTableManagerUser();
                this.Hide();
               f.ShowDialog();
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
