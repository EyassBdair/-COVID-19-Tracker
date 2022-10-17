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
    public partial class SearchCenter : home_screen
    {
        public SearchCenter()
        {
            InitializeComponent();
        }

        private void SearchCenter_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //nada
        {
           
            int id = Convert.ToInt32(textBox3.Text);
            foreach (Center c in SystemManager.Centers)
            {
                if (c._ID == id)
                    MessageBox.Show(c.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //nada
        {
            this.Close();

        }
    }
}
