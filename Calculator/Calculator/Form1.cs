using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {   
            if((results.Text == "0")||(operation_pressed))
                results.Clear();

            operation_pressed = false;
            Button button = (Button)sender;
            results.Text = results.Text + button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            results.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(results.Text);
            operation_pressed = true;
            equations.Text = value + " " + operation;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            equations.Text = "";
            switch (operation)
            {
                case "+":
                    results.Text = (value + Double.Parse(results.Text)).ToString();
                    break;
                case "-":
                    results.Text = (value - Double.Parse(results.Text)).ToString();
                    break;
                case "÷":
                    results.Text = (value / Double.Parse(results.Text)).ToString();
                    break;
                case "x":
                    results.Text = (value * Double.Parse(results.Text)).ToString();
                    break;
            }
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            results.Text = "0";
            value = 0;
        }

        
    }
}
