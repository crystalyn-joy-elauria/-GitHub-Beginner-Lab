namespace StudentProfile
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnteredName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEnteredContact = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblEnteredYearLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name of Student: ";
            // 
            // lblEnteredName
            // 
            this.lblEnteredName.AutoSize = true;
            this.lblEnteredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteredName.Location = new System.Drawing.Point(238, 111);
            this.lblEnteredName.Name = "lblEnteredName";
            this.lblEnteredName.Size = new System.Drawing.Size(307, 29);
            this.lblEnteredName.TabIndex = 1;
            this.lblEnteredName.Text = "Crystalyn Joy V. Elauria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "— GitHub Begginer Lab";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(14, 185);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(225, 29);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Student Contact: ";
            // 
            // lblEnteredContact
            // 
            this.lblEnteredContact.AutoSize = true;
            this.lblEnteredContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteredContact.Location = new System.Drawing.Point(238, 185);
            this.lblEnteredContact.Name = "lblEnteredContact";
            this.lblEnteredContact.Size = new System.Drawing.Size(178, 29);
            this.lblEnteredContact.TabIndex = 5;
            this.lblEnteredContact.Text = "09171234567";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.Location = new System.Drawing.Point(14, 248);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(151, 29);
            this.lblYearLevel.TabIndex = 6;
            this.lblYearLevel.Text = "Year Level:";
            // 
            // lblEnteredYearLevel
            // 
            this.lblEnteredYearLevel.AutoSize = true;
            this.lblEnteredYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteredYearLevel.Location = new System.Drawing.Point(171, 248);
            this.lblEnteredYearLevel.Name = "lblEnteredYearLevel";
            this.lblEnteredYearLevel.Size = new System.Drawing.Size(28, 29);
            this.lblEnteredYearLevel.TabIndex = 7;
            this.lblEnteredYearLevel.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 286);
            this.Controls.Add(this.lblEnteredYearLevel);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.lblEnteredContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnteredName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEnteredName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEnteredContact;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label lblEnteredYearLevel;
    }
}

