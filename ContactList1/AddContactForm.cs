using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList1
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text.Trim();
            string soDienThoai = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại.");
                return;
            }

            // Ví dụ: lưu email tạm
            MessageBox.Show($"Liên hệ mới:\n{hoTen} - {soDienThoai} - {email}");

            this.Close();
        }
    }
}
