namespace Domaci2
{
    partial class racunanjeTrougla
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
            this.rbRaznostranicni = new System.Windows.Forms.RadioButton();
            this.rbJednakokraki = new System.Windows.Forms.RadioButton();
            this.rbJednakostranicni = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnRacunaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRaznostranicni
            // 
            this.rbRaznostranicni.AutoSize = true;
            this.rbRaznostranicni.Checked = true;
            this.rbRaznostranicni.Location = new System.Drawing.Point(20, 39);
            this.rbRaznostranicni.Name = "rbRaznostranicni";
            this.rbRaznostranicni.Size = new System.Drawing.Size(102, 19);
            this.rbRaznostranicni.TabIndex = 0;
            this.rbRaznostranicni.TabStop = true;
            this.rbRaznostranicni.Text = "Raznostranicni";
            this.rbRaznostranicni.UseVisualStyleBackColor = true;
            this.rbRaznostranicni.CheckedChanged += new System.EventHandler(this.rbRaznostranicni_CheckedChanged);
            // 
            // rbJednakokraki
            // 
            this.rbJednakokraki.AutoSize = true;
            this.rbJednakokraki.Location = new System.Drawing.Point(128, 39);
            this.rbJednakokraki.Name = "rbJednakokraki";
            this.rbJednakokraki.Size = new System.Drawing.Size(93, 19);
            this.rbJednakokraki.TabIndex = 1;
            this.rbJednakokraki.Text = "Jednakokraki";
            this.rbJednakokraki.UseVisualStyleBackColor = true;
            this.rbJednakokraki.CheckedChanged += new System.EventHandler(this.rbJednakokraki_CheckedChanged);
            // 
            // rbJednakostranicni
            // 
            this.rbJednakostranicni.AutoSize = true;
            this.rbJednakostranicni.Location = new System.Drawing.Point(227, 39);
            this.rbJednakostranicni.Name = "rbJednakostranicni";
            this.rbJednakostranicni.Size = new System.Drawing.Size(113, 19);
            this.rbJednakostranicni.TabIndex = 2;
            this.rbJednakostranicni.Text = "Jednakostranicni";
            this.rbJednakostranicni.UseVisualStyleBackColor = true;
            this.rbJednakostranicni.CheckedChanged += new System.EventHandler(this.rbJednakostranicni_CheckedChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(170, 106);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 23);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(170, 135);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 23);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(170, 164);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 23);
            this.txtC.TabIndex = 5;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(62, 109);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(60, 15);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "Stranica A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(62, 138);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(59, 15);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "Stranica B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(62, 167);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(60, 15);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "Stranica C";
            // 
            // btnRacunaj
            // 
            this.btnRacunaj.Location = new System.Drawing.Point(115, 224);
            this.btnRacunaj.Name = "btnRacunaj";
            this.btnRacunaj.Size = new System.Drawing.Size(113, 40);
            this.btnRacunaj.TabIndex = 9;
            this.btnRacunaj.Text = "Racunaj";
            this.btnRacunaj.UseVisualStyleBackColor = true;
            this.btnRacunaj.Click += new System.EventHandler(this.btnRacunaj_Click);
            // 
            // racunanjeTrougla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 316);
            this.Controls.Add(this.btnRacunaj);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rbJednakostranicni);
            this.Controls.Add(this.rbJednakokraki);
            this.Controls.Add(this.rbRaznostranicni);
            this.Name = "racunanjeTrougla";
            this.Text = "Racunanje Trougla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbRaznostranicni;
        private RadioButton rbJednakokraki;
        private RadioButton rbJednakostranicni;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Button btnRacunaj;
    }
}