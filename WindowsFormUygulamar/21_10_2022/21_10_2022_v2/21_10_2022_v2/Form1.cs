using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_10_2022_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clicka(sender, e);
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            Clicka(sender, e);
        }

        private void Clicka(object sender, EventArgs e)
        {
            Control groupBox = ((Button)sender).Parent;
            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control groupItems in item.Controls)
                    {
                        if (groupItems is TextBox && groupItems.Parent == groupBox)
                            (groupItems as TextBox).Clear();
                    }
                }
            }
        }
    }
}
