using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class MainWindow : Form
    {
        double calc1, calc2;
        char symb;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            calc1 = Convert.ToDouble(mainLbl.Text);
            mainLbl.Text = "";
            symb = '/';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            mainLbl.Text += ".";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            calc1 = Convert.ToDouble(mainLbl.Text);
            mainLbl.Text = "";
            symb = '*';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mainLbl.Text += "1";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calc1 = Convert.ToDouble(mainLbl.Text);
            mainLbl.Text = "";
            symb = '-';
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calc1 = Convert.ToDouble(mainLbl.Text);
            mainLbl.Text = "";
            symb = '+';
        }

        private void btnEntr_Click(object sender, EventArgs e)
        {
            calc2 = Convert.ToDouble(mainLbl.Text);

            switch (symb)
            {
                case '+':
                    mainLbl.Text = (calc1 + calc2).ToString();
                    break;
                case '-':
                    mainLbl.Text = (calc1 - calc2).ToString();
                    break;
                case '*':
                    mainLbl.Text = (calc1 * calc2).ToString();
                    break;
                case '/':
                    mainLbl.Text = (calc1 / calc2).ToString();
                    break;
            }
        }
    }
}
