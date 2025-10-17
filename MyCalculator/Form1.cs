using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyCalculator
{
    public partial class PinkCalculator : Form
    {
        
        private Double result = 0;
        private String operation_performed = "";
        private bool isOperationPerformed = false;
        private string operation_perfomed;

        public PinkCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed==true)
                textBox1.Clear();//Daca la inceput am 0, il sterg
            
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            isOperationPerformed = false;
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            operation_performed = button.Text;
            result = Double.Parse(textBox1.Text);//convertesc textul butonului in numar si il adun la rezultat
            labelCurrentOperation.Text = labelCurrentOperation.Text + " " + result + " " + operation_performed;
            isOperationPerformed = true;

        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void clear_click_simple(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            labelCurrentOperation.Text = "";
        }

        private void equal_click(object sender, EventArgs e)
        {
            labelCurrentOperation.Text = labelCurrentOperation.Text + "" + textBox1.Text + " = ";
            switch (operation_performed) {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                
            }
        }
    }
}
