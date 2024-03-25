namespace mySchool
{
    partial class Login
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
            this.studentid = new System.Windows.Forms.Label();
            this.txtlstudentid = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentid
            // 
            this.studentid.AutoSize = true;
            this.studentid.BackColor = System.Drawing.Color.Transparent;
            this.studentid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentid.Location = new System.Drawing.Point(606, 143);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(123, 25);
            this.studentid.TabIndex = 0;
            this.studentid.Text = "Student ID";
            this.studentid.Click += new System.EventHandler(this.studentid_Click);
            // 
            // txtlstudentid
            // 
            this.txtlstudentid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtlstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlstudentid.Location = new System.Drawing.Point(575, 191);
            this.txtlstudentid.Multiline = false;
            this.txtlstudentid.Name = "txtlstudentid";
            this.txtlstudentid.Size = new System.Drawing.Size(189, 39);
            this.txtlstudentid.TabIndex = 1;
            this.txtlstudentid.Text = "";
            this.txtlstudentid.TextChanged += new System.EventHandler(this.txtlstudentid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(606, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(611, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 68);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOGIN";
            // 
            // txtlpassword
            // 
            this.txtlpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtlpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlpassword.Location = new System.Drawing.Point(575, 333);
            this.txtlpassword.MinimumSize = new System.Drawing.Size(189, 35);
            this.txtlpassword.Name = "txtlpassword";
            this.txtlpassword.PasswordChar = '*';
            this.txtlpassword.Size = new System.Drawing.Size(189, 22);
            this.txtlpassword.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mySchool.Properties.Resources.Cute_Blue_System_Background_Widescreen_And_HD_Background_Wallpaper;
            this.ClientSize = new System.Drawing.Size(1391, 653);
            this.Controls.Add(this.txtlpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlstudentid);
            this.Controls.Add(this.studentid);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentid;
        private System.Windows.Forms.RichTextBox txtlstudentid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlpassword;
    }
}