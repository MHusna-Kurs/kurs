﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_10_2022_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            tbxYazi.Text = "Butona tıklandı.";
        }

        private void tbxYazi_TextChanged(object sender, EventArgs e)
        {
            if (tbxYazi.Text == "Son")
                btnDegistir.Visible = false;

            else
                btnDegistir.Visible = true;
        }

        private void tbxYazi_Validated(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(tbxYazi.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            btnRed.Visible = true;
            btnBlue.Visible = false;
            btnOrange.Visible = false;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            btnRed.Visible = false;
            btnBlue.Visible = true;
            btnOrange.Visible = false;
        }

        private void radOrange_CheckedChanged(object sender, EventArgs e)
        {
            btnRed.Visible = false;
            btnBlue.Visible = false;
            btnOrange.Visible = true;
        }
    }
}
