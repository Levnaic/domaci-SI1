namespace domaci1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblYearOfStudy = new System.Windows.Forms.Label();
            this.cbxYearOfStudy = new System.Windows.Forms.ComboBox();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(154, 354);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 36);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Prikazi";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(194, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(74, 33);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(77, 15);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Ime Studenta";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(74, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(49, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Prezime";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(193, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 23);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(74, 123);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(34, 15);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Smer";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(193, 123);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(200, 23);
            this.txtCourse.TabIndex = 5;
            // 
            // lblYearOfStudy
            // 
            this.lblYearOfStudy.AutoSize = true;
            this.lblYearOfStudy.Location = new System.Drawing.Point(74, 173);
            this.lblYearOfStudy.Name = "lblYearOfStudy";
            this.lblYearOfStudy.Size = new System.Drawing.Size(84, 15);
            this.lblYearOfStudy.TabIndex = 7;
            this.lblYearOfStudy.Text = "Godine Ucenja";
            this.lblYearOfStudy.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbxYearOfStudy
            // 
            this.cbxYearOfStudy.FormattingEnabled = true;
            this.cbxYearOfStudy.Location = new System.Drawing.Point(194, 168);
            this.cbxYearOfStudy.Name = "cbxYearOfStudy";
            this.cbxYearOfStudy.Size = new System.Drawing.Size(199, 23);
            this.cbxYearOfStudy.TabIndex = 8;
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.CustomFormat = "dd.MM.yyyy.";
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfBirth.Location = new System.Drawing.Point(193, 213);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtDateOfBirth.TabIndex = 9;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(74, 216);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(92, 15);
            this.lblDateOfBirth.TabIndex = 10;
            this.lblDateOfBirth.Text = "Datum Rodjenja";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(74, 265);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(24, 15);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Pol";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(194, 254);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 19);
            this.rbMale.TabIndex = 12;
            this.rbMale.Text = "Muski";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(194, 279);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(59, 19);
            this.rbWoman.TabIndex = 13;
            this.rbWoman.Text = "Zenski";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.cbxYearOfStudy);
            this.Controls.Add(this.lblYearOfStudy);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Podaci o studentu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnShow;
        private TextBox txtFirstName;
        private Label lblStudentName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblCourse;
        private TextBox txtCourse;
        private Label lblYearOfStudy;
        private ComboBox cbxYearOfStudy;
        private DateTimePicker dtDateOfBirth;
        private Label lblDateOfBirth;
        private Label lblGender;
        private RadioButton rbMale;
        private RadioButton rbWoman;
    }
}