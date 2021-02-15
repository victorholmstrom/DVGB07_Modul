using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGB07_Modul2.Modul2
{
    public partial class CalcForm : Form
    {
        private enum operand
        {
            NUL = ' ',
            ADD = '+',
            SUB = '-',
            MUL = '*',
            DIV = '/',
            EQU = '='
        }
        private enum delete
        {
            RESET = 0,
            CLEAR = 1,
            BACK = 2
        }
        private string input;
        private double sum;
        private operand op;
        private string log;
        private bool dec;
        private int n;

        public CalcForm()
        {
            input = "";
            sum = 0;
            op = operand.NUL;
            log = "";
            dec = false;
            n = 0;
            InitializeComponent();
        }

        private void opCalculate(operand calcOp)
        {
            switch (calcOp)
            {
                case operand.NUL:
                    dec = false;
                    break;
                case operand.ADD:
                    sum = sum + double.Parse(input);
                    dec = false;
                    break;
                case operand.SUB:
                    sum = sum - double.Parse(input);
                    dec = false;
                    break;
                case operand.MUL:
                    sum = sum * double.Parse(input);
                    dec = false;
                    break;
                case operand.DIV:
                    if (int.Parse(input) != 0)
                    {
                        sum = sum / double.Parse(input);
                        dec = false;
                    }
                    else
                        sum = 999999;
                    break;
                case operand.EQU:
                    n = 1;
                    dec = false;
                    break;
                default:
                    break;
            }
        }

        private void calculate(double buffer_sum, operand buffer_op)
        {
            if (string.IsNullOrEmpty(log))
            {
                sum = double.Parse(input);
            }
            if (n < 2)
            {
                log = $"{sum} {(char)op} ";
            }
            else
            {
                if ((char)op == '*' || (char)op == '/')
                    log = $"({buffer_sum} {(char)buffer_op} {double.Parse(input)}) {(char)op} ";
                else
                    log = $"{buffer_sum} {(char)buffer_op} {double.Parse(input)} {(char)op} ";
            }
            LogLabel.Text = log;
            input = "";
            InputLabel.Text = sum.ToString();
        }

        private void ValueButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (char.Parse(btn.Text) == ',')
            {
                if (!string.IsNullOrEmpty(input))
                {
                    if (!dec)
                    {
                        dec = true;
                        input = input + char.Parse(btn.Text);
                        InputLabel.Text = input;
                    }

                }
            }
            else
            {
                if (!string.IsNullOrEmpty(input))
                {
                    if (double.Parse(input) == 0 && !dec){
                    input = btn.Text;
                    }
                    else
                    {
                        input = input + char.Parse(btn.Text);
                    }
                }
                else
                {
                    input = input + char.Parse(btn.Text);
                }
                InputLabel.Text = input;
            }
        }

        private void OpButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input) || (char)op == '=')
            {
                operand buffer_op = op;
                double buffer_sum = sum;
                n++;

                Button btn = (Button)sender;
                op = (operand)char.Parse(btn.Text);
                
                opCalculate(buffer_op);
                calculate(buffer_sum, buffer_op);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            switch (int.Parse(btn.AccessibleDescription))
            {
                case (int)delete.RESET:
                    input = "";
                    sum = 0;
                    op = operand.NUL;
                    log = "";
                    dec = false;
                    n = 0;
                    LogLabel.Text = "";
                    InputLabel.Text = "0";
                    break;
                case (int)delete.CLEAR:
                    input = "";
                    InputLabel.Text = "0";
                    break;
                case (int)delete.BACK:
                    if (input.Length > 0)
                    {
                        input = input.Remove(input.Length - 1);
                        InputLabel.Text = input;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
