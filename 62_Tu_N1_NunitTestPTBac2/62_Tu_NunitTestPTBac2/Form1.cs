using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62_Tu_NunitTestPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Tinh_tu62_Click(object sender, EventArgs e)
        {

            double a, b, c;
            string ketqua;

            try
            {
                a = double.Parse(txt_a_tu62.Text);
                b = double.Parse(txt_b_tu62.Text);
                c = double.Parse(txt_c_tu62.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Hệ số phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ngừng thực thi hàm nếu xảy ra lỗi
            }


            PTBac2_Tu62 pt = new PTBac2_Tu62(a, b, c);
            ketqua = pt.Execute_Tu62(a, b, c);
            txt_kq_tu62.Text = ketqua;


           

        }
    }
}
