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
    public partial class Form1 : Form
    {
        Detka Detka;
        About About;
        public static Label loc;
        public Form1()
        {
            InitializeComponent();
            radioButton3.Checked = true;
            radioButton4.Checked = true;
            loc = new Label();
            loc.Location = new Point(127, 230);
            groupBox1.Controls.Add(loc);
        }
        public static int countD = 0, countA = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (countD == 0)
            {
                Detka = new Detka(this, About);
                Detka.Text = textBox1.Text;
                Detka.Height = (int)numericUpDown1.Value;
                Detka.Width = (int)numericUpDown2.Value;
                Detka.BackColor = colorForDetka;
                Detka.Show();
                loc.Text = loc.Text = Detka.Location.X + ";" + Detka.Location.Y;
                if (normD)
                    WindowState = FormWindowState.Normal;
                else if (maxD)
                    WindowState = FormWindowState.Maximized;
                else if (minD)
                    WindowState = FormWindowState.Minimized;
                if (flagD)
                    Detka.Visible = true;
                else
                    Detka.Visible = false;
                countD++;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (countD == 1)
            {
                Detka.Close();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (countA == 1)
            {
                About.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (countA == 0)
            {
                About = new About(this);
                if (normA)
                    About.WindowState = FormWindowState.Normal;
                else if (maxA)
                    About.WindowState = FormWindowState.Maximized;
                else if (minA)
                    About.WindowState = FormWindowState.Minimized;
                if (flagA)
                    About.Show();
                else
                    About.ShowDialog();
                countA++;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                flagD = true;
                if (countD == 1)
                    Detka.Visible = true;
            }
            else
            {
                flagD = false;
                if (countD == 1)
                    Detka.Visible = false;
            }
        }
        public static bool flagA = false, flagD = false;
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                flagA = true;
            else
                flagA = false;
        }
        bool maxD = false, maxA = false, minD = false, minA = false, normD = false, normA = false;
        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                minA = true;
                if (countA == 1)
                    About.WindowState = FormWindowState.Minimized;
            }
            else
                minA = false;
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                maxA = true;
                if (countA == 1)
                    About.WindowState = FormWindowState.Maximized;
            }
            else
                maxA = false;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                normA = true;
                if (countA == 1)
                    About.WindowState = FormWindowState.Normal;
            }
            else
                normA = false;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                minD = true;
                if (countD == 1)
                    Detka.WindowState = FormWindowState.Minimized;
            }
            else
                minD = false;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                maxD = true;
                if (countD == 1)
                    Detka.WindowState = FormWindowState.Maximized;
            }
            else
                maxD = false;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (countD == 1)
                Detka.Height = (int)numericUpDown1.Value;
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (countD == 1)
                Detka.Width = (int)numericUpDown2.Value;
        }
        Color colorForDetka = Color.White;
        private void Button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && countD == 1)
                Detka.BackColor = colorDialog1.Color;
            else if (colorDialog1.ShowDialog() == DialogResult.OK)
                colorForDetka = colorDialog1.Color;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (countD == 1)
                Detka.loc2.Text = Height + ";" + Width;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            if (countD == 1)
                Detka.Close();
        }


        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                normD = true;
                if (countD == 1)
                    Detka.WindowState = FormWindowState.Normal;
            }
            else
                normD = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CanClose(this))
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (countD == 1)
                Detka.Text = textBox1.Text;
        }
        public static bool CanClose(Form f)
        {
            CanClose canClose = new CanClose();
            canClose.Text = "Вы уверены, что хотите закрыть форму '" + f.Text + "'?";
            canClose.ShowDialog();
            if (canClose.close)
                return true;
            else
                return false;
        }
        public void ChangeSize(decimal f, decimal s)
        {
            numericUpDown1.Value = f;
            numericUpDown2.Value = s;
        }
    }
}
