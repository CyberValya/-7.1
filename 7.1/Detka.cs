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
    public partial class Detka : Form
    {
        public static Label loc1;
        public static Label loc2;
        public static Label loc3;
        Form1 mainForm;
        public Detka(Form1 f1, Form Ab)
        {
            InitializeComponent();
            mainForm = f1;
            loc1 = new Label();
            loc1.Location = new Point(63, 9);
            Controls.Add(loc1);
            loc1.Text = Height + ";" + Width;
            loc2 = new Label();
            loc2.Location = new Point(63, 72);
            Controls.Add(loc2);
            loc2.Text = f1.Height + ";" + f1.Width;
            loc3 = new Label();
            loc3.Location = new Point(63, 139);
            Controls.Add(loc3);
            if (Form1.countA == 1)
            {
                loc3.Text= Ab.Height + ";" + Ab.Width;
            }
        }

        private void Detka_Move(object sender, EventArgs e)
        {
            Form1.loc.Text = Location.X + ";" + Location.Y;
        }

        private void Detka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.countD--;
        }
        public bool flag;
        private void Detka_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form1.CanClose(this))
            {
                e.Cancel = false;
                flag = true;
            }
            else
            {
                e.Cancel = true;
                flag = false;
            }
        }

        private void Detka_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                mainForm.radioButton3.Checked = true;
            else if (WindowState == FormWindowState.Maximized)
                mainForm.radioButton2.Checked = true;
            else if (WindowState == FormWindowState.Minimized)
                mainForm.radioButton1.Checked = true;
            mainForm.ChangeSize((decimal)Height, (decimal)Width);
            loc1.Text = Height + ";" + Width;
        }
    }
}
