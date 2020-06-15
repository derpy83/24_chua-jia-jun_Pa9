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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            
                    
            if (rb_US.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 0.74M;
                    txt_Converted.Text = "$" + converted_amount.ToString();
                    
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    
                }
            }
            else if (rb_Yen.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 81.97M;
                    txt_Converted.Text =  converted_amount.ToString() + " Yen";
                    
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    
                }
            }
           
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
        }

        private void rb_US_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Yen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
