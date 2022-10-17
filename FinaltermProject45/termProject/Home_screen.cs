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
    public partial class home_screen : Form
    {
       
            public home_screen()
        {
            InitializeComponent();
        }

        private void personShot1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = from w in SystemManager.Persons
                    where w._Takeshot1
                    select w._Fname + " " + w._Lname + " " + w._SSN ;  //***
            string p = "";
            foreach (string s in q)
            {
                p += s + "\n";

            }
             if(SystemManager.Persons.Count!=0)
            MessageBox.Show(p);
            else
                MessageBox.Show("Sorry,there are not any pepole in the database, please Enter a new person");
        }

        private void vaccineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person_Screen f = new Person_Screen();
           this.Hide();
            f.Show();
            
        }

        private void personsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search f2 = new Search();
            this.Hide();
            f2.Show();
        }

        private void newLotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaccineS V = new VaccineS();
            this.Hide();
            V.Show();
        }

        private void allPersonsToolStripMenuItem_Click(object sender, EventArgs e)//ALL Persons 
        {
            var q = from w in SystemManager.Persons
                    select w._Fname + " " + w._Lname + " " + w._SSN;  //***
            string p = "";
            foreach (string s in q)
            {
                p += s + "\n";

            }
            if(SystemManager.Persons.Count!=0)
            MessageBox.Show(p);
            else
                MessageBox.Show("Sorry,there are not any pepole in the database, please Enter a new person");

        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchVaccine s = new SearchVaccine();
            this.Hide();
            s.Show();
        }

        private void newCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterS c = new CenterS();
            this.Hide();
            c.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCenter s = new SearchCenter();
            this.Hide();
            s.Show();
        }

        private void personsPerCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var q = from w in SystemManager.Persons
                    select w.ToString(); //***
            string p = "";
            foreach (string s in q)
            {
                p += s + "\n\n";

            }
            if (SystemManager.Centers.Count != 0)
                MessageBox.Show(p);
            else
                MessageBox.Show("Sorry,there are not any Centers in the database, please Enter a new Center");
        }

        private void immunedPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            immunedPeople f4 = new immunedPeople();
            f4.Show();


        }

        private void availableVaccinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Available Vaccines :{SystemManager.Remaining()} ");
        }

        private void vaccineByTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "";
            Dictionary<VACCINE, int> numOfVac = new Dictionary<VACCINE, int>();
            numOfVac.Add(VACCINE.Sinopharm, ImportedVaccine.GetNumOfType(VACCINE.Sinopharm));
            numOfVac.Add(VACCINE.Astrazeneca, ImportedVaccine.GetNumOfType(VACCINE.Astrazeneca));
            numOfVac.Add(VACCINE.Fizer, ImportedVaccine.GetNumOfType(VACCINE.Fizer));
            numOfVac.Add(VACCINE.Moderna, ImportedVaccine.GetNumOfType(VACCINE.Moderna));
            numOfVac.Add(VACCINE.jj, ImportedVaccine.GetNumOfType(VACCINE.jj));
            foreach (var v in numOfVac)
            {
                s += string.Format($"{v.Key}") + " : " + string.Format($"{v.Value}      ");//edit 
            }
            MessageBox.Show(s);
        }

        private void personsPerVaccineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = from w in SystemManager.Persons
                    select w._Fname + " "+w._Lname+ " " + w._ShotOneType+ " " + w._ShotSeondType; //***
            string p = "";

            foreach (string s in q)
            {
                p += s + "\n\n";

            }
            if (SystemManager.Persons.Count != 0)
                MessageBox.Show(p);
            else
                MessageBox.Show("Sorry,there are not any pepole in the database, please Enter a new person");
        }

        private void personShot2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = from w in SystemManager.Persons
                    where w._Takeshot2
                    select w._Fname + " " + w._Lname + " " + w._SSN;  //***
            string p = "";
            foreach (string s in q)
            {
                p += s + "\n";

            }
            if (SystemManager.Persons.Count != 0)
                MessageBox.Show(p);
            else
                MessageBox.Show("Sorry,there are not any pepole who took Shot 2in the database, please Enter a new person");

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notImmunedPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
