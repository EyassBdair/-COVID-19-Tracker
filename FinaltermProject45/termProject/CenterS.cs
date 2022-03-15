using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termProject
{
    public partial class CenterS : home_screen
    {
        public CenterS()
        {
            InitializeComponent();
        }

        private void CenterS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //nada
        {
          
            
            if (textBox3.Text == null || textBox3.Text.Length < 10 || textBox3.Text.Length == 0 || textBox3.Text.Length > 10)
            {
                MessageBox.Show("Sorry, the phone number should be ten digits ");

            }
            if(textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Sorry, Please enter address");
            }
            else if(textBox3.Text != null && textBox2.Text != "" && textBox1.Text != "")
            {
                Center c = new Center(Convert.ToInt32(textBox4.Text), textBox5.Text, textBox2.Text, textBox1.Text, textBox3.Text);

               
                SystemManager.Centers.Add(c);

                textBox4.Text = "";
                textBox5.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                MessageBox.Show("data saved ");

                Person_Screen frm2 = new Person_Screen();
                frm2.Show();
                Visible = false;
               /* frm2.passingvalue = textBox1.Text;
                frm2.passingvalue1 = textBox2.Text;
                frm2.passingvalue2 = textBox3.Text;
                frm2.passingvalue3 = textBox3.Text;
                frm2.passingvalue4 = textBox3.Text;
               */
              //  frm2.ShowDialog();
                
            }






        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            home_screen f1 = new home_screen();
            f1.Show();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
