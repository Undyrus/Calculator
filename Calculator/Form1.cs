using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Autor: Ramiro Diego González
namespace Calculator
{
    public partial class Form1 : Form
    {


        double result = 0;
        double operator1 = 0;
        double operator2 = 0;
        string operation = "";

        Boolean operationDone = false;
        Boolean checkOp1 = false;
        Boolean remove0 = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void operator1Button(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
            if (label1.Text == "0"&& checkOp1 == false)
            {
                label1.Text = button.Text;
               
                result = Convert.ToDouble(label1.Text);
            }
             else if(operationDone == true&&checkOp1==false)
            {
                result = 0;
                operator1 = 0;
                operator2 = 0;
                operation = "";
                operationDone = false;
                checkOp1 = false;
                remove0 = false;
                label1.Text = button.Text;
                operationDone = false;
            }
            
            else if (remove0 == true)
            {
                label1.Text = button.Text;
                operator2 = Convert.ToDouble(label1.Text);
                remove0 = false;
            }

            else
            {
                label1.Text = label1.Text + button.Text;
                result = Convert.ToDouble(label1.Text);
                
                if (checkOp1 == true)
                {
                    operator2 = Convert.ToDouble(label1.Text);
                }
                operationDone = false;
            }
        }

        private void operationButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            
            operator1 = Convert.ToDouble(label1.Text);
            
            
            checkOp1 = true;
            remove0 = true;
        }

        private void doOperationButton(object sender, EventArgs e)
        {
  
             if (operation == "+")
             {
                if (operationDone == false)
                {
                    result = operator1 + operator2;
                }
                if(operationDone == true)
                {
                    result = result + operator2;
                }  

             }

            else if (operation == "-")
            {
                if (operationDone == false)
                {
                    result = operator1 - operator2;
                }
                if (operationDone == true)
                {
                    result = result - operator2;
                }
 
            }
            else if (operation == "*")
            {
                if (operationDone == false)
                {
                    result = operator1 * operator2;
                }
                if (operationDone == true)
                {
                    result = result * operator2;
                }
            }
            else if (operation == "/")
            {
                if (operationDone == false)
                {
                    result = operator1 / operator2;
                }
                if (operationDone == true)
                {
                    result = result / operator2;
                }
            }
            else if (operation == "^")
            {
                if (operationDone == false)
                {
                    result = Math.Pow(operator1, operator2);
                }
                if (operationDone == true)
                {
                    result = Math.Pow(result, operator2);
                }

            }
            else if (operation == "√")
            {
                if (operationDone == false)
                {
                    result = Math.Pow(operator1, 1/operator2);
                }
                if (operationDone == true)
                {
                    result = Math.Pow(result, 1/operator2);
                }
            }

            label1.Text = Convert.ToString(result);
            operator1 = result;
            operationDone = true;
            checkOp1 = false;
            if (result >= 999999999999)
            {
                label1.Text = "Math Error";

            }
        }

        private void resetButton(object sender, EventArgs e)
        {
            result = 0;
            operator1 = 0;
            operator2 = 0;
            operation = "";
            operationDone = false;
            checkOp1 = false;
            remove0 = false;
            label1.Text = "0";
        }
    }
}
