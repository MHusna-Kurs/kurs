using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_10_2022_YasHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpTakvim_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime dtpPicker = dtpCalendar.Value;

            int year;
            int month;
            int day;

            if(dtpPicker.Month > now.Month) {
                year = (now.Year - dtpPicker.Year) -1;
                month = (now.Month - dtpPicker.Month) + 12;
            }
            else
            {
                year = (now.Year - dtpPicker.Year);
                month = (now.Month - dtpPicker.Month);
            }

            if (now.Day > dtpPicker.Day)
            {
                month = now.Month - dtpPicker.Month;
                day = now.Day - dtpPicker.Day;
            }
            else
            {
                month = (now.Month - dtpPicker.Month) - 1;
                day = (now.Day - dtpPicker.Day) + 30;
            }

            lblResult.Text = Convert.ToString("Yıl: "+year+
                                              " Ay: "+month+
                                              " Gün: "+ day);
        }
    }
}
