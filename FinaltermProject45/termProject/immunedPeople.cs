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
    public partial class immunedPeople : home_screen

    {
        public immunedPeople()
        {
            InitializeComponent();
            

            dataGridView1.DataSource = Person.PersonNotDone;


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
    }
}
