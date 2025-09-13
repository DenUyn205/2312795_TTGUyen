using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312795_TTGUyen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void btSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

       

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
