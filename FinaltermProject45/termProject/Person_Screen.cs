using System;
using System.Windows.Forms;
using termProject;
using System.Linq;

namespace termProject
{
    public partial class Person_Screen : home_screen
    {
        private bool Takeshot1;

        private bool Takeshot2;
        /*public static  string name;
        public static string id;
        public static string add1;
        public static string add2;
        public static string phone;

        public string passingvalue
        {

            get { return name; }
            set { name = value; }
        }


        public string passingvalue1
        {

            get { return add1; }
            set { add1 = value; }


        }

        public string passingvalue2
        {

            get { return add2; }
            set { add2 = value; }

        }
        public string passingvalue3
        {

            get { return phone; }
            set { phone = value; }

        }
        public string passingvalue4
        {
            get { return id; }
            set { id = value; }

        }*/
        //Center c = new Center(Convert.ToInt32(id), name, add1, add2, phone);
        public Person_Screen()
        {
            InitializeComponent();

            for (int i = 0; i < SystemManager.Centers.Count; i++)
            {
                CenterShotOne.Items.Add(SystemManager.Centers[i].Name);
                CenterShotTwo.Items.Add(SystemManager.Centers[i].Name);
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SsnText_TextChanged(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void newPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DatePer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Save_TextChanged(object sender, EventArgs e)
        {


        }

        public void Save_Click(object sender, EventArgs e)
        {




            //  (DateTime ShotDate, VACCINE Type, int Lot, Center Vac, String Nurse)
           
            string s = "";

            /*if (SystemManager.Centers.Count != 0)
            {
                var q = from c in SystemManager.Centers

                        select c;


                CenterShotOne.DataSource = q;
                MessageBox.Show($"{q}");

            }
            */

            //int ID, string Name, String addl1, String addl2, string Phone





          /*  if (comboBox1.SelectedItem != null)
            {
                Takeshot1 = true;
                // MessageBox.Show($"******");

            }
            if (comboBox2.SelectedItem != null)
            {
                Takeshot2 = true;
                //   MessageBox.Show($"******");

            }
          */

          //*******************************eyass*******************
            string[] str = {"Fizer" ,
                                  "Sinopharm",
                                       "jj",
                                      "Moderna",
                                    "Astrazeneca"  };
            string stringOne= "";
            string stringTwo = "";
            int count = 0;
            for (int i = 0; i <5; i++)
              {
                  if (VaccType1_Box1.SelectedItem.Equals(str[i]))
                  {
                      Takeshot1=true;
                    stringOne = str[i];
               //   MessageBox.Show($"******");

                  }


                if (VaccType2_Box2.SelectedItem.Equals(str[i]))
                {
                    Takeshot2 = true;
                    stringTwo = str[i];

                }
                else
                    count++;
            }
            if (count == 5)
                stringTwo = "NULL";

            //**************************mahmoud*************************************

            if (int.Parse(Person_SSN.Text) <= 0 || Person_SSN.Text == "" || Person_SSN.Text.Length == 0)
                MessageBox.Show($"SSN value is not valid please enter it again ");
            else if (FirstName_Box.Text == null || FirstName_Box.Text == "" || FirstName_Box.Text.Length < 2)
            {
                MessageBox.Show($"First name value is not valid please enter it again ");

            }

            else if (LastName_Box1.Text == null || LastName_Box1.Text == "" || LastName_Box1.Text.Length < 2)
            {
                MessageBox.Show($"Last name value is not valid please enter it again ");

            }
            else if (Birthdate_Person.Value == null || Birthdate_Person.Value >= DateTime.Today)
                MessageBox.Show($"Birthdate value is not valid please enter it again ");

            else
            {
                Person P = new Person(int.Parse(Person_SSN.Text), FirstName_Box.Text, LastName_Box1.Text, Birthdate_Person.Value, CenterShotOne.Text,
                                        CenterShotTwo.Text, Takeshot1, Takeshot2, stringOne, stringTwo);
                SystemManager.AddPersone(P);

                MessageBox.Show($"A new person has been added to the database. there are {SystemManager.Persons.Count}");
                if (P.Islmmune())  //nada

                    Person.PersonDone.Add(P);
                else

                    Person.PersonNotDone.Add(P); //nada

                Save.Enabled = false;

               // MessageBox.Show($"{P._centerNameShot1}");
              //  MessageBox.Show($"{P._centerNameShot2}");


                // DateTime.InfectionDates dateTimePicker1
                //Center C = new Center(int.Parse(ID), Name, addL1, addL2, Phone);
                VACCINE v = (VACCINE)Enum.Parse(typeof(VACCINE), VaccType1_Box1.SelectedItem.ToString());//try and caught
                VACCINE v2 = (VACCINE)Enum.Parse(typeof(VACCINE), VaccType2_Box2.SelectedItem.ToString());

               VaccineShot Shot1 = new VaccineShot(DateShotOne.Value, v, int.Parse(LOT2_Box3.Text), NameNurseShotOne.Text);
               VaccineShot Shot2 = new VaccineShot(DateShotTwo.Value, v2, int.Parse(LOT2_Box3.Text), NameNurseShotTwo.Text);


                SystemManager.VaccinePersoneShot1(P, Shot1);
                SystemManager.VaccinePersoneShot1(P, Shot2);
                Person_Screen form12 = new Person_Screen();
                form12.Show();
                Visible = false;

            }

        }
        

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            home_screen f = new home_screen();
            f.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TypeShotTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void DateShotOne_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CenterShotOne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CenterShotTwo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}