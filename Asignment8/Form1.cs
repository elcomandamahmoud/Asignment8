using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNClick_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TXTNum.Text.Trim());
            if (num>20)
            {
                MessageBox.Show("هذا الرقم "+num+" بالطبع أكبر من 20.");
            }
            if (num<100)
            {
                MessageBox.Show("هذا الرقم "+num+" أصغر من 100");
            }
        }
    }
}
