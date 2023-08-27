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
            this.ClearInputs();
        }

        private void ClearInputs()
        {
            displayTextBox.Text = "";
            this.currentOperand = "";
            this.firstNumber = null;
        }
        private void Operand_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(displayTextBox.Text))
            {
                return;
            }

            Button button = (Button)sender;
            this.currentOperand = button.Text;

            if(firstNumber == null)
            {
                ToggleOperands();
            }

            this.firstNumber = Convert.ToDecimal(displayTextBox.Text);
            this.displayTextBox.Text = "";
        }

        private void ToggleOperands()
        {
            plusBtn.Enabled = !plusBtn.Enabled;
            minusBtn.Enabled = !minusBtn.Enabled;
            multiplyBtn.Enabled = !multiplyBtn.Enabled;
            divisionBtn.Enabled = !divisionBtn.Enabled;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            Calculate();
            this.firstNumber = null;
        }
        
        private void Calculate()
        {
            try
            {
                switch (this.currentOperand)
                {
                    case "+":
                        this.displayTextBox.Text = (this.firstNumber + Convert.ToDecimal(displayTextBox.Text)).ToString();
                        break;
                    case "-":
                        this.displayTextBox.Text = (this.firstNumber - Convert.ToDecimal(displayTextBox.Text)).ToString();
                        break;
                    case "X":
                        this.displayTextBox.Text = (this.firstNumber * Convert.ToDecimal(displayTextBox.Text)).ToString();
                        break;
                    case "/":
                        this.displayTextBox.Text = (this.firstNumber / Convert.ToDecimal(displayTextBox.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception) {
                MessageBox.Show("Error!");
                this.ClearInputs();
            } finally {
                ToggleOperands();
            }
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.displayTextBox.Text))
            {
                return;
            }

            this.displayTextBox.Text = this.displayTextBox.Text.Remove(this.displayTextBox.Text.Length - 1);
        }
    }
}
