using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
                MessageBox.Show("Giới tính của bạn là Nam","Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
                MessageBox.Show("Giới tính của bạn là Nữ", "Thông báo");
        }
    }
}
