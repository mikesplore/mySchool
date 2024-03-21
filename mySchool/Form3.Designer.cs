namespace mySchool
{
    partial class StudentDetails
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
            this.namelabel = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtclass = new System.Windows.Forms.RichTextBox();
            this.classlabel = new System.Windows.Forms.Label();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.dobdate = new System.Windows.Forms.Label();
            this.dobpicker = new System.Windows.Forms.DateTimePicker();
            this.rbisex = new System.Windows.Forms.RadioButton();
            this.rcomplicated = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.namelabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.namelabel.Location = new System.Drawing.Point(117, 48);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(123, 25);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Student ID";
            this.namelabel.Click += new System.EventHandler(this.namelabel_Click);
            // 
            // txtstudentid
            // 
            this.txtstudentid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtstudentid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(38, 93);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(221, 31);
            this.txtstudentid.TabIndex = 1;
            this.txtstudentid.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(558, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gender";
            // 
            // txtclass
            // 
            this.txtclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtclass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclass.Location = new System.Drawing.Point(45, 208);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(221, 31);
            this.txtclass.TabIndex = 5;
            this.txtclass.Text = "";
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.BackColor = System.Drawing.Color.Transparent;
            this.classlabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.classlabel.Location = new System.Drawing.Point(124, 163);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(64, 25);
            this.classlabel.TabIndex = 4;
            this.classlabel.Text = "Class";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.BackColor = System.Drawing.Color.Transparent;
            this.rbfemale.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbfemale.Location = new System.Drawing.Point(603, 201);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(77, 21);
            this.rbfemale.TabIndex = 8;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = false;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.BackColor = System.Drawing.Color.Transparent;
            this.rbmale.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbmale.Location = new System.Drawing.Point(511, 201);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(63, 21);
            this.rbmale.TabIndex = 9;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = false;
            // 
            // dobdate
            // 
            this.dobdate.AutoSize = true;
            this.dobdate.BackColor = System.Drawing.Color.Transparent;
            this.dobdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dobdate.Location = new System.Drawing.Point(558, 48);
            this.dobdate.Name = "dobdate";
            this.dobdate.Size = new System.Drawing.Size(75, 25);
            this.dobdate.TabIndex = 11;
            this.dobdate.Text = "D.O.B";
            this.dobdate.Click += new System.EventHandler(this.dobdate_Click);
            // 
            // dobpicker
            // 
            this.dobpicker.Location = new System.Drawing.Point(490, 93);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(200, 22);
            this.dobpicker.TabIndex = 12;
            this.dobpicker.ValueChanged += new System.EventHandler(this.dobpicker_ValueChanged);
            // 
            // rbisex
            // 
            this.rbisex.AutoSize = true;
            this.rbisex.BackColor = System.Drawing.Color.Transparent;
            this.rbisex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbisex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbisex.Location = new System.Drawing.Point(511, 243);
            this.rbisex.Name = "rbisex";
            this.rbisex.Size = new System.Drawing.Size(86, 21);
            this.rbisex.TabIndex = 13;
            this.rbisex.TabStop = true;
            this.rbisex.Text = "Bisexual";
            this.rbisex.UseVisualStyleBackColor = false;
            this.rbisex.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rcomplicated
            // 
            this.rcomplicated.AutoSize = true;
            this.rcomplicated.BackColor = System.Drawing.Color.Transparent;
            this.rcomplicated.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcomplicated.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rcomplicated.Location = new System.Drawing.Point(603, 243);
            this.rcomplicated.Name = "rcomplicated";
            this.rcomplicated.Size = new System.Drawing.Size(111, 21);
            this.rcomplicated.TabIndex = 14;
            this.rcomplicated.TabStop = true;
            this.rcomplicated.Text = "Complicated";
            this.rcomplicated.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(338, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mySchool.Properties.Resources.v617batch2_bb_01_technology;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rcomplicated);
            this.Controls.Add(this.rbisex);
            this.Controls.Add(this.dobpicker);
            this.Controls.Add(this.dobdate);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.classlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.namelabel);
            this.Name = "StudentDetails";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.RichTextBox txtstudentid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtclass;
        private System.Windows.Forms.Label classlabel;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label dobdate;
        private System.Windows.Forms.DateTimePicker dobpicker;
        private System.Windows.Forms.RadioButton rbisex;
        private System.Windows.Forms.RadioButton rcomplicated;
        private System.Windows.Forms.Button button1;
    }
}