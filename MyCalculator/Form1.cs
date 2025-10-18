using System;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class PinkCalculator : Form
    {

        private Double result = 0;
        private String operation_performed = "";
        private bool isOperationPerformed = false;

        public PinkCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" || isOperationPerformed == true)
                textBox1.Clear();

            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;


            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {

                textBox1.Text = textBox1.Text + button.Text;
            }

            isOperationPerformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string new_operation = button.Text;
            if (operation_performed != "")
            {
                perform_calculation(Double.Parse(textBox1.Text));
                textBox1.Text = result.ToString();
            }
            else
            {

                result = Double.Parse(textBox1.Text);
            }
            operation_performed = new_operation;
            labelCurrentOperation.Text = result.ToString() + " " + operation_performed;
            isOperationPerformed = true;
        }


        private void perform_calculation(double currentValue)
        {

            switch (operation_performed)
            {
                case "+":
                    result = result + currentValue;
                    break;
                case "-":
                    result = result - currentValue;
                    break;
                case "*":
                    result = result * currentValue;
                    break;
                case "/":

                    if (currentValue != 0)
                    {
                        result = result / currentValue;
                    }
                    else
                    {
                        textBox1.Text = "ERR: Div/0";
                        result = 0;
                        operation_performed = "";
                    }
                    break;
            }
        }

        private void equal_click(object sender, EventArgs e)
        {

            if (operation_performed != "")
            {
                double second_operand = Double.Parse(textBox1.Text);
                perform_calculation(second_operand);
                labelCurrentOperation.Text = labelCurrentOperation.Text + " " + second_operand.ToString() + " = ";
                textBox1.Text = result.ToString();
                operation_performed = "";
                isOperationPerformed = true;
            }
        }

        private void clear_click(object sender, EventArgs e) // CE (Clear Entry)
        {

            textBox1.Text = "0";
        }

        private void clear_click_simple(object sender, EventArgs e) // C (Clear All)
        {
            textBox1.Text = "0";
            result = 0;
            labelCurrentOperation.Text = "";
            operation_performed = "";
            isOperationPerformed = false;
        }
    }
}