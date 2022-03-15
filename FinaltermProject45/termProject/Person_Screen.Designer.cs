
namespace termProject
{
    partial class Person_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Person_Screen));
            this.label1 = new System.Windows.Forms.Label();
            this.Person_SSN = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Birthdate_Person = new System.Windows.Forms.DateTimePicker();
            this.FirstName_Box = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.LastName_Box1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CenterShotTwo = new System.Windows.Forms.ComboBox();
            this.NameNurseShotTwo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DateShotTwo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CenterShotOne = new System.Windows.Forms.ComboBox();
            this.centerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateShotOne = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NameNurseShotOne = new System.Windows.Forms.TextBox();
            this.VaccType1_Box1 = new System.Windows.Forms.ComboBox();
            this.centerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOT2_Box3 = new System.Windows.Forms.ComboBox();
            this.LOT2_Box4 = new System.Windows.Forms.ComboBox();
            this.VaccType2_Box2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Person_SSN
            // 
            resources.ApplyResources(this.Person_SSN, "Person_SSN");
            this.Person_SSN.BackColor = System.Drawing.Color.Azure;
            this.Person_SSN.Name = "Person_SSN";
            this.Person_SSN.TextChanged += new System.EventHandler(this.SsnText_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::termProject.Properties.Resources.images__1_;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Azure;
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.BackColor = System.Drawing.Color.LightGreen;
            this.Save.Name = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.BackColor = System.Drawing.Color.Salmon;
            this.Cancel.Name = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Azure;
            this.label19.Name = "label19";
            this.label19.Click += new System.EventHandler(this.label19_Click_1);
            // 
            // Birthdate_Person
            // 
            resources.ApplyResources(this.Birthdate_Person, "Birthdate_Person");
            this.Birthdate_Person.CalendarForeColor = System.Drawing.Color.Azure;
            this.Birthdate_Person.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.Birthdate_Person.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.Birthdate_Person.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.Birthdate_Person.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.Birthdate_Person.Name = "Birthdate_Person";
            this.Birthdate_Person.ValueChanged += new System.EventHandler(this.DatePer_ValueChanged);
            // 
            // FirstName_Box
            // 
            resources.ApplyResources(this.FirstName_Box, "FirstName_Box");
            this.FirstName_Box.BackColor = System.Drawing.Color.Azure;
            this.FirstName_Box.Name = "FirstName_Box";
            this.FirstName_Box.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Azure;
            this.label18.Name = "label18";
            // 
            // LastName_Box1
            // 
            resources.ApplyResources(this.LastName_Box1, "LastName_Box1");
            this.LastName_Box1.BackColor = System.Drawing.Color.Azure;
            this.LastName_Box1.Name = "LastName_Box1";
            this.LastName_Box1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Name = "label2";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Azure;
            this.label11.Name = "label11";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Azure;
            this.label16.Name = "label16";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Azure;
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Azure;
            this.label14.Name = "label14";
            // 
            // CenterShotTwo
            // 
            resources.ApplyResources(this.CenterShotTwo, "CenterShotTwo");
            this.CenterShotTwo.BackColor = System.Drawing.Color.Azure;
            this.CenterShotTwo.FormattingEnabled = true;
            this.CenterShotTwo.Name = "CenterShotTwo";
            this.CenterShotTwo.SelectedIndexChanged += new System.EventHandler(this.CenterShotTwo_SelectedIndexChanged);
            // 
            // NameNurseShotTwo
            // 
            resources.ApplyResources(this.NameNurseShotTwo, "NameNurseShotTwo");
            this.NameNurseShotTwo.BackColor = System.Drawing.Color.Azure;
            this.NameNurseShotTwo.Name = "NameNurseShotTwo";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Azure;
            this.label15.Name = "label15";
            // 
            // DateShotTwo
            // 
            resources.ApplyResources(this.DateShotTwo, "DateShotTwo");
            this.DateShotTwo.CalendarForeColor = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.DateShotTwo.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.DateShotTwo.Name = "DateShotTwo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Name = "label6";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Azure;
            this.label17.Name = "label17";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Azure;
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Azure;
            this.label9.Name = "label9";
            // 
            // CenterShotOne
            // 
            resources.ApplyResources(this.CenterShotOne, "CenterShotOne");
            this.CenterShotOne.BackColor = System.Drawing.Color.Azure;
            this.CenterShotOne.FormattingEnabled = true;
            this.CenterShotOne.Name = "CenterShotOne";
            this.CenterShotOne.SelectedIndexChanged += new System.EventHandler(this.CenterShotOne_SelectedIndexChanged);
            // 
            // centerBindingSource
            // 
            this.centerBindingSource.DataSource = typeof(termProject.Center);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Azure;
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Azure;
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // DateShotOne
            // 
            resources.ApplyResources(this.DateShotOne, "DateShotOne");
            this.DateShotOne.CalendarForeColor = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.DateShotOne.CalendarTrailingForeColor = System.Drawing.Color.Azure;
            this.DateShotOne.Name = "DateShotOne";
            this.DateShotOne.ValueChanged += new System.EventHandler(this.DateShotOne_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Name = "label5";
            // 
            // NameNurseShotOne
            // 
            resources.ApplyResources(this.NameNurseShotOne, "NameNurseShotOne");
            this.NameNurseShotOne.BackColor = System.Drawing.Color.Azure;
            this.NameNurseShotOne.Name = "NameNurseShotOne";
            // 
            // VaccType1_Box1
            // 
            resources.ApplyResources(this.VaccType1_Box1, "VaccType1_Box1");
            this.VaccType1_Box1.BackColor = System.Drawing.Color.Azure;
            this.VaccType1_Box1.FormattingEnabled = true;
            this.VaccType1_Box1.Items.AddRange(new object[] {
            resources.GetString("VaccType1_Box1.Items"),
            resources.GetString("VaccType1_Box1.Items1"),
            resources.GetString("VaccType1_Box1.Items2"),
            resources.GetString("VaccType1_Box1.Items3"),
            resources.GetString("VaccType1_Box1.Items4")});
            this.VaccType1_Box1.Name = "VaccType1_Box1";
            this.VaccType1_Box1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // centerBindingSource1
            // 
            this.centerBindingSource1.DataSource = typeof(termProject.Center);
            // 
            // systemManagerBindingSource
            // 
            this.systemManagerBindingSource.DataSource = typeof(termProject.SystemManager);
            // 
            // LOT2_Box3
            // 
            resources.ApplyResources(this.LOT2_Box3, "LOT2_Box3");
            this.LOT2_Box3.BackColor = System.Drawing.Color.Azure;
            this.LOT2_Box3.FormattingEnabled = true;
            this.LOT2_Box3.Items.AddRange(new object[] {
            resources.GetString("LOT2_Box3.Items"),
            resources.GetString("LOT2_Box3.Items1")});
            this.LOT2_Box3.Name = "LOT2_Box3";
            this.LOT2_Box3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // LOT2_Box4
            // 
            resources.ApplyResources(this.LOT2_Box4, "LOT2_Box4");
            this.LOT2_Box4.BackColor = System.Drawing.Color.Azure;
            this.LOT2_Box4.FormattingEnabled = true;
            this.LOT2_Box4.Items.AddRange(new object[] {
            resources.GetString("LOT2_Box4.Items"),
            resources.GetString("LOT2_Box4.Items1")});
            this.LOT2_Box4.Name = "LOT2_Box4";
            // 
            // VaccType2_Box2
            // 
            resources.ApplyResources(this.VaccType2_Box2, "VaccType2_Box2");
            this.VaccType2_Box2.BackColor = System.Drawing.Color.Azure;
            this.VaccType2_Box2.FormattingEnabled = true;
            this.VaccType2_Box2.Items.AddRange(new object[] {
            resources.GetString("VaccType2_Box2.Items"),
            resources.GetString("VaccType2_Box2.Items1"),
            resources.GetString("VaccType2_Box2.Items2"),
            resources.GetString("VaccType2_Box2.Items3"),
            resources.GetString("VaccType2_Box2.Items4"),
            resources.GetString("VaccType2_Box2.Items5")});
            this.VaccType2_Box2.Name = "VaccType2_Box2";
            this.VaccType2_Box2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Person_Screen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::termProject.Properties.Resources.eee;
            this.Controls.Add(this.VaccType2_Box2);
            this.Controls.Add(this.LOT2_Box4);
            this.Controls.Add(this.LOT2_Box3);
            this.Controls.Add(this.VaccType1_Box1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CenterShotOne);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameNurseShotOne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateShotOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CenterShotTwo);
            this.Controls.Add(this.NameNurseShotTwo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DateShotTwo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastName_Box1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.FirstName_Box);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Birthdate_Person);
            this.Controls.Add(this.Person_SSN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Person_Screen";
            this.Tag = "";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Person_SSN, 0);
            this.Controls.SetChildIndex(this.Birthdate_Person, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.FirstName_Box, 0);
            this.Controls.SetChildIndex(this.Save, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.LastName_Box1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.DateShotTwo, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.NameNurseShotTwo, 0);
            this.Controls.SetChildIndex(this.CenterShotTwo, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.DateShotOne, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.NameNurseShotOne, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.CenterShotOne, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.VaccType1_Box1, 0);
            this.Controls.SetChildIndex(this.LOT2_Box3, 0);
            this.Controls.SetChildIndex(this.LOT2_Box4, 0);
            this.Controls.SetChildIndex(this.VaccType2_Box2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Person_SSN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.Label Cancel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker Birthdate_Person;
        private System.Windows.Forms.TextBox FirstName_Box;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox LastName_Box1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CenterShotTwo;
        private System.Windows.Forms.TextBox NameNurseShotTwo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DateShotTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CenterShotOne;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateShotOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameNurseShotOne;
        private System.Windows.Forms.ComboBox VaccType1_Box1;
        private System.Windows.Forms.BindingSource centerBindingSource;
        private System.Windows.Forms.BindingSource systemManagerBindingSource;
        private System.Windows.Forms.BindingSource centerBindingSource1;
        private System.Windows.Forms.ComboBox LOT2_Box3;
        private System.Windows.Forms.ComboBox LOT2_Box4;
        private System.Windows.Forms.ComboBox VaccType2_Box2;
    }
}