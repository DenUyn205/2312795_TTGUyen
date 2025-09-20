using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBTKFORM
{
    public partial class frmBai3 : Form
    {
        List <string> list = new List <string> ();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void txtNghia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            listBox1 .Items.Add (tu);
            list.Add (nghia);

            txtTuMoi.Focus(); // sau khi nhấn thêm mới, con trỏ quay lại ô thêm mới để nhập tiếp
            txtTuMoi.Text = ""; // xoá cả 2 ô khi thêm thành công
            txtNghia.Text = "";

            listBox1.SelectedIndex = listBox1 .Items.Count - 1; // chọn phần từ cuối (mới thêm)
            txtHienThiNghia.Text = nghia ;
            // sau khi thêm từ mới danh sách từ sẽ mặc định chọn vào từ mới được thêm và nghĩa từ đó sẽ xuất hiện bên khung nghĩa.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy số thứ tự của từ trong listbox
            var stt = listBox1.SelectedIndex;
            // tra nghĩa của từ trong danh sách dựa vào số thứ tự
            txtHienThiNghia.Text = list[stt];
        }
    }
}
