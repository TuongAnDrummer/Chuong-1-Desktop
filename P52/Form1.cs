using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemSelect = lblDanhSach.SelectedItems.Count -1;
            for (int i = itemSelect; i >= 0; i--)
            {
                lblDanhSachChon.Items.Add(lblDanhSach.SelectedItems[i]);
                lblDanhSach.Items.Remove(lblDanhSach.SelectedItems[i]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int itemSelect = lblDanhSachChon.SelectedItems.Count - 1;
            for (int i = itemSelect; i >= 0; i--)
            {              
                lblDanhSach.Items.Add(lblDanhSachChon.SelectedItems[i]);
                lblDanhSachChon.Items.Remove(lblDanhSachChon.SelectedItems[i]);
            }
        }
    }
}
