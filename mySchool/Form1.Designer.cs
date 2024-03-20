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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.studentidlabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.registerbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.Location = new System.Drawing.Point(44, 36);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(131, 29);
            this.firstnamelabel.TabIndex = 0;
            this.firstnamelabel.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(49, 78);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(314, 30);
            this.FirstName.TabIndex = 1;
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(49, 188);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(314, 30);
            this.StudentID.TabIndex = 3;
            // 
            // studentidlabel
            // 
            this.studentidlabel.AutoSize = true;
            this.studentidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentidlabel.Location = new System.Drawing.Point(44, 146);
            this.studentidlabel.Name = "studentidlabel";
            this.studentidlabel.Size = new System.Drawing.Size(124, 29);
            this.studentidlabel.TabIndex = 2;
            this.studentidlabel.Text = "Student ID";
            this.studentidlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(458, 78);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(314, 30);
            this.LastName.TabIndex = 5;
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.Location = new System.Drawing.Point(453, 36);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(128, 29);
            this.lastnamelabel.TabIndex = 4;
            this.lastnamelabel.Text = "Last Name";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(458, 188);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(314, 30);
            this.Password.TabIndex = 7;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(453, 146);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(176, 29);
            this.passwordlabel.TabIndex = 6;
            this.passwordlabel.Text = "New Password";
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerbutton.Location = new System.Drawing.Point(458, 295);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(219, 67);
            this.registerbutton.TabIndex = 8;
            this.registerbutton.Text = "Register";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearbutton.Location = new System.Drawing.Point(144, 295);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(219, 67);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.studentidlabel);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.firstnamelabel);
            this.Name = "Register";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label studentidlabel;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

