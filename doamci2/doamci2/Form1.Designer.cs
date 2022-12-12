namespace doamci2
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbRaznostranicni = new System.Windows.Forms.RadioButton();
            this.rbJednakostranicni = new System.Windows.Forms.RadioButton();
            this.rbJendakokraki = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnRacunaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oblik";
            // 
            // rbRaznostranicni
            // 
            this.rbRaznostranicni.AutoSize = true;
            this.rbRaznostranicni.Location = new System.Drawing.Point(117, 40);
            this.rbRaznostranicni.Name = "rbRaznostranicni";
            this.rbRaznostranicni.Size = new System.Drawing.Size(102, 19);
            this.rbRaznostranicni.TabIndex = 1;
            this.rbRaznostranicni.TabStop = true;
            this.rbRaznostranicni.Text = "Raznostranicni";
            this.rbRaznostranicni.UseVisualStyleBackColor = true;
            this.rbRaznostranicni.CheckedChanged += new System.EventHandler(this.rbRaznostranicni_CheckedChanged);
            // 
            // rbJednakostranicni
            // 
            this.rbJednakostranicni.AutoSize = true;
            this.rbJednakostranicni.Location = new System.Drawing.Point(117, 81);
            this.rbJednakostranicni.Name = "rbJednakostranicni";
            this.rbJednakostranicni.Size = new System.Drawing.Size(113, 19);
            this.rbJednakostranicni.TabIndex = 2;
            this.rbJednakostranicni.TabStop = true;
            this.rbJednakostranicni.Text = "Jednakostranicni";
            this.rbJednakostranicni.UseVisualStyleBackColor = true;
            this.rbJednakostranicni.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbJendakokraki
            // 
            this.rbJendakokraki.AutoSize = true;
            this.rbJendakokraki.Location = new System.Drawing.Point(117, 118);
            this.rbJendakokraki.Name = "rbJendakokraki";
            this.rbJendakokraki.Size = new System.Drawing.Size(93, 19);
            this.rbJendakokraki.TabIndex = 3;
            this.rbJendakokraki.TabStop = true;
            this.rbJendakokraki.Text = "Jednakokraki";
            this.rbJendakokraki.UseVisualStyleBackColor = true;
            this.rbJendakokraki.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(117, 179);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 23);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(117, 226);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 23);
            this.txtB.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(117, 268);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 23);
            this.txtC.TabIndex = 6;
            // 
            // btnRacunaj
            // 
            this.btnRacunaj.Location = new System.Drawing.Point(85, 391);
            this.btnRacunaj.Name = "btnRacunaj";
            this.btnRacunaj.Size = new System.Drawing.Size(111, 47);
            this.btnRacunaj.TabIndex = 7;
            this.btnRacunaj.Text = "Rezultat";
            this.btnRacunaj.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "C";
            // 
            // txtHa
            // 
            this.txtHa.Location = new System.Drawing.Point(117, 313);
            this.txtHa.Name = "txtHa";
            this.txtHa.Size = new System.Drawing.Size(100, 23);
            this.txtHa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "hA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRacunaj);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rbJendakokraki);
            this.Controls.Add(this.rbJednakostranicni);
            this.Controls.Add(this.rbRaznostranicni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rbRaznostranicni;
        private RadioButton rbJednakostranicni;
        private RadioButton rbJendakokraki;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Button btnRacunaj;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHa;
        private Label label5;
    }
}