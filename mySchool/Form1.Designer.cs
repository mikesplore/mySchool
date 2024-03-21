namespace mySchool
{
    partial class Register
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
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.studentidlabel = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.registerbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.firstnamelabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstnamelabel.Location = new System.Drawing.Point(650, 47);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(124, 25);
            this.firstnamelabel.TabIndex = 0;
            this.firstnamelabel.Text = "First Name";
            this.firstnamelabel.Click += new System.EventHandler(this.firstnamelabel_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(655, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(314, 30);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(655, 199);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(314, 30);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // studentidlabel
            // 
            this.studentidlabel.AutoSize = true;
            this.studentidlabel.BackColor = System.Drawing.Color.Transparent;
            this.studentidlabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentidlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentidlabel.Location = new System.Drawing.Point(650, 157);
            this.studentidlabel.Name = "studentidlabel";
            this.studentidlabel.Size = new System.Drawing.Size(123, 25);
            this.studentidlabel.TabIndex = 2;
            this.studentidlabel.Text = "Student ID";
            this.studentidlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(1064, 89);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(314, 30);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.lastnamelabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastnamelabel.Location = new System.Drawing.Point(1059, 47);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(121, 25);
            this.lastnamelabel.TabIndex = 4;
            this.lastnamelabel.Text = "Last Name";
            this.lastnamelabel.Click += new System.EventHandler(this.lastnamelabel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(1064, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(314, 30);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordlabel.Location = new System.Drawing.Point(1059, 157);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(160, 25);
            this.passwordlabel.TabIndex = 6;
            this.passwordlabel.Text = "New Password";
            this.passwordlabel.Click += new System.EventHandler(this.passwordlabel_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerbutton.Location = new System.Drawing.Point(1064, 394);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(146, 45);
            this.registerbutton.TabIndex = 8;
            this.registerbutton.Text = "Register";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearbutton.Location = new System.Drawing.Point(823, 394);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(146, 45);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::mySchool.Properties.Resources.v617batch2_bb_01_technology;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1837, 864);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.studentidlabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.firstnamelabel);
            this.Name = "Register";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label studentidlabel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

