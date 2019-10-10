using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string a = string.Empty;
        string b = string.Empty;
        string c = string.Empty;
        double input_a = 0;
        double input_b = 0;
        double input_c = 0;
        double root = 0;
        double determinent=0;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void txtInputValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }


        private void a_val_TextChanged(object sender, EventArgs e)
        {
            validate_input(a_val);
            

        }
        private void b_val_TextChanged(object sender, EventArgs e)
        {
            validate_input(b_val);
            
        }
        private void c_val_TextChanged(object sender, EventArgs e)
        {
            validate_input(c_val);
            
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (a_val.Text != ""  && b_val.Text != "" && c_val.Text != "")
            {
                a = a_val.Text;
                b = b_val.Text;
                c = c_val.Text;
                input_a = Convert.ToDouble(a);
                input_b = Convert.ToDouble(b);
                input_c = Convert.ToDouble(c);


                if (input_a != 0 )
                {
                    determinent = Math.Pow(input_b, 2) - (4 * input_a * input_c);

                    if (determinent == 0)
                    {

                        root = -input_b / (2 * input_a);
                        double rounded_root = Math.Round(root, 3);
                        //Console.WriteLine("Root is " + root);
                        //MessageBox.Show("Root is " + root);
                        final_result.Text = Convert.ToString(rounded_root);


                    }
                    else if (determinent > 0)
                    {

                        double root1 = ((-1 * input_b) + (Math.Pow(determinent, 0.5))) / (2 * input_a);
                        double root2 = ((-1 * input_b) - (Math.Pow(determinent, 0.5))) / (2 * input_a);

                        double rounded_root1 = Math.Round(root1, 3);
                        double rounded_root2 = Math.Round(root2, 3);
                        //Console.WriteLine("Roots are " + root1 + " & " + root2);
                        //MessageBox.Show("Roots are " + root1 + " & " + root2);
                        string r1 = Convert.ToString(rounded_root1);
                        string r2 = Convert.ToString(rounded_root2);
                        final_result.Text = "Roots are " + r1 + " and " + r2;

                        //clear_final_result(final_result);
                        //final_result.Text = Convert.ToString(root2);
                    }
                    else
                    {

                        final_result.Text = "No Real Roots!";

                    }
                }
                else
                {

                    MessageBox.Show("Coeffcient A should not be null or zero!!!\n\tEnter again!");
                    clear_all(a_val, b_val, c_val);

                }

            }
            else {

                MessageBox.Show("Coeffcient A should not be null or zero!!!\nEnter again!");
            }
            
            
                
        }

        

     

        private void clear_Click(object sender, EventArgs e)
        {
            
            clear_all(a_val, b_val, c_val);
            
            
        }

        private void clear_all(TextBox a, TextBox b, TextBox c) {
            a.Text = "0";
            b.Text = "0";
            c.Text = "0";
            clear_final_result(final_result);
        }

        private void clear_final_result(TextBox a)
        {
            a.Text = "";
         
        }

        private void validate_input(TextBox input) {

            if (System.Text.RegularExpressions.Regex.IsMatch(input.Text, "[^-1000.0-9999.9]"))
            {

                MessageBox.Show("Please Enter Only Numbers!");
                input.Text = string.Empty;
            }
            
        }

        
    }
}
