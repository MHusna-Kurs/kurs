using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_10_2022_v4
{
    public partial class Form1 : Form
    {
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            tbxResult.Text += ""+((Button) sender).Text;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            string operand = ((Button)sender).Text;

            string stringTempNumber = "";
            double doubleTempNumber;
            double multiply = 1;
            int count = 1, count2 = 1;

            if(operand == "=")
            {
                string islem = tbxResult.Text;
                foreach (var item in islem)
                {
                    stringTempNumber += item;
                    switch (item)
                    {
                        case '+':
                            doubleTempNumber = Convert.ToDouble(stringTempNumber);
                            stringTempNumber = "";
                            result += doubleTempNumber;
                            break;

                        case '-':
                            doubleTempNumber = Convert.ToDouble(stringTempNumber);
                            stringTempNumber = "";
                            if (count != 2)
                                result = doubleTempNumber;
                            else
                                result -= doubleTempNumber;
                            count++;
                            break;

                        case '*':
                            doubleTempNumber = Convert.ToDouble(stringTempNumber);
                            stringTempNumber = "";
                            multiply *= doubleTempNumber;
                            result = multiply;
                            break;

                        case '/':
                            doubleTempNumber = Convert.ToDouble(stringTempNumber);
                            stringTempNumber = "";
                            if (count2 != 2)
                                result = doubleTempNumber;
                            else
                                result /= doubleTempNumber;
                            count++;
                            break;
                        default:
                            break;
                    }
                }
            }
            yazdir();
        }

        private void yazdir()
        {
            tbxResult.Text = Convert.ToString(result);
        }
    }
}
