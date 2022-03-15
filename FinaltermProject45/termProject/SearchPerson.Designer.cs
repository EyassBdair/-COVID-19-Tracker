
namespace termProject
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.PersonSearch_Box1 = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Cancel_button2 = new System.Windows.Forms.Button();
            this.Search_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonSearch_Box1
            // 
            this.PersonSearch_Box1.Location = new System.Drawing.Point(254, 329);
            this.PersonSearch_Box1.Name = "PersonSearch_Box1";
            this.PersonSearch_Box1.Size = new System.Drawing.Size(487, 24);
            this.PersonSearch_Box1.TabIndex = 1;
            this.PersonSearch_Box1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Search_button.Location = new System.Drawing.Point(268, 388);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(151, 43);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel_button2
            // 
            this.Cancel_button2.BackColor = System.Drawing.Color.Salmon;
            this.Cancel_button2.Location = new System.Drawing.Point(590, 388);
            this.Cancel_button2.Name = "Cancel_button2";
            this.Cancel_button2.Size = new System.Drawing.Size(151, 43);
            this.Cancel_button2.TabIndex = 3;
            this.Cancel_button2.Text = "Cancel";
            this.Cancel_button2.UseVisualStyleBackColor = false;
            this.Cancel_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search_Label
            // 
            this.Search_Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_Label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search_Label.Location = new System.Drawing.Point(271, 238);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(450, 69);
            this.Search_Label.TabIndex = 4;
            this.Search_Label.Text = "Search ";
            this.Search_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::termProject.Properties.Resources.eee;
            this.ClientSize = new System.Drawing.Size(1059, 620);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.Cancel_button2);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.PersonSearch_Box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Search";
            this.Text = "Search ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.PersonSearch_Box1, 0);
            this.Controls.SetChildIndex(this.Search_button, 0);
            this.Controls.SetChildIndex(this.Cancel_button2, 0);
            this.Controls.SetChildIndex(this.Search_Label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PersonSearch_Box1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Cancel_button2;
        private System.Windows.Forms.Label Search_Label;
    }
}