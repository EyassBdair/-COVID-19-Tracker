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
    public partial class SearchVaccine : home_screen
    {
        public SearchVaccine()
        {
            InitializeComponent();
        }

        private void SearchVaccine_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new home_screen();
            f.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //HashSet<ImportedVaccine> Imported_Data =new HashSet<ImportedVaccine>();
            /*foreach(ImportedVaccine v in SystemManager.ImportedVaccines)
                  Imported_Data.Add(v);*/

            var Q = from l in SystemManager.ImportedVaccines where l.GetLotNum() == int.Parse(textBox3.Text) select l;
            var s = "";
            HashSet<VACCINE> types1 = new HashSet<VACCINE>();
            foreach (ImportedVaccine v in Q)
                types1.Add(v.GetVACCINE());
            HashSet<string> types2 = new HashSet<string>();
            foreach (VACCINE v in types1)
                types2.Add(v.ToString());
            foreach (string s2 in types2)
                s += s2 + "  ";

            MessageBox.Show($"   {s}   ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" there are {SystemManager.ImportedVaccines.Count} Imported Vaccines");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" there are {VaccineShot.GetCount()} Used doses Vaccines");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" there are {SystemManager.Remaining()} Remainig doses Vaccines");
        }
    }
}
