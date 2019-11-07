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
    public partial class CanClose : Form
    {
        public CanClose()
        {
            InitializeComponent();
        }
        public bool close = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            close = false;
            this.Close();
        }
    }
}
