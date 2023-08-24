using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string currentOperand = "";
        decimal? firstNumber = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "";
            this.currentOperand = "";
            this.firstNumber = null;
        }
        private void Operand_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.firstNumber = Convert.ToDecimal(displayTextBox.Text);
            this.currentOperand = button.Text;
            this.displayTextBox.Text = "";
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            switch(this.currentOperand)
            {
                case "+":
                    this.displayTextBox.Text = Convert.ToString(this.firstNumber + Convert.ToDecimal(displayTextBox.Text));
                    break;
                case "-":
                    this.displayTextBox.Text = Convert.ToString(this.firstNumber - Convert.ToDecimal(displayTextBox.Text));
                    break;
                default:
                    break;
            }
        }
    }
}
