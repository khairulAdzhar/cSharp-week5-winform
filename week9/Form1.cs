using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week9
{
    public partial class Form1 : Form
    {
        Account number = new Account();
        Account account1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                if (comboBox1.SelectedItem.Equals("Fixed"))
                {
                    account1 = new Account();
                    string bb = account1.BBalance.ToString();
                    label7.Text = bb;
                }
                else
                {
                    account1 = new Account(decimal.Parse(textBox2.Text),decimal.Parse(textBox4.Text));
                    label7.Text = account1.getBalance().ToString();
                }
                /////////////////////////
                number.FirstName = textBox1.Text;
                number.LastName = textBox3.Text;
                label6.Text = number.FirstName + " " + number.LastName;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                textBox2.Enabled = false;
                textBox4.Enabled = false;

            }
            else
            {
                textBox2.Enabled = true ;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = account1.getBalance().ToString();
            account1 = new Account(decimal.Parse(textBox2.Text), decimal.Parse(textBox4.Text));
            label7.Text = account1.getBalance().ToString(); 



        }
    }


    

}
