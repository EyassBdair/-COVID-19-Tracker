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
    public partial class Search :home_screen
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SystemManager.Persons.Count != 0)
            {
                var q = from c in SystemManager.Persons
                        where c._SSN.Equals(int.Parse(PersonSearch_Box1.Text))
                        select c;
                string s = "";
                foreach (Person item in q)
                {
                    s += item + "\n";
                }
                if (s != "")
                    MessageBox.Show($"{s}");
                else
                    MessageBox.Show($"there is no person with this SSN ");

            }
           /* if (SystemManager.Vaccines.Count != 0)
            {
                var q = from c in SystemManager.Vaccines
                        where c.s  Equals(int.Parse(textBox1.Text))
                        select c;
                string s = "";
                foreach (Person item in q)
                {
                    s += item + "\n";
                }
                if (s != "")
                    MessageBox.Show($"{s}");
                else
                    MessageBox.Show($"there is no person with this SSN ");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_screen f = new home_screen();
            f.Show();
        }
    }
}
