using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1
{
    public partial class About : Form
    {
        Form1 f;
        public About(Form1 f1)
        {
            InitializeComponent();
            f = f1;
            if (Form1.countD == 1)
                Detka.loc3.Text = Height + ";" + Width;
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.countA--;
            if (Form1.countD == 1)
                Detka.loc3.Text = "";
        }

        private void About_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                f.radioButton4.Checked = true;
            else if (WindowState == FormWindowState.Maximized)
                f.radioButton5.Checked = true;
            else if (WindowState == FormWindowState.Minimized)
                f.radioButton6.Checked = true;
            if (Form1.countD == 1)
                Detka.loc3.Text = Height + ";" + Width;
        }
    }
}
