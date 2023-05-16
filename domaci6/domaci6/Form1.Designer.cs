namespace domaci6
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImePredmeta = new System.Windows.Forms.TextBox();
            this.txtBrojCasova = new System.Windows.Forms.TextBox();
            this.txtImeProfesora = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgPredmeti = new System.Windows.Forms.DataGridView();
            this.mnIzvestajPredmeti = new System.Windows.Forms.MenuStrip();
            this.mnIzvestaj = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPredmeti)).BeginInit();
            this.mnIzvestajPredmeti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime predmeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj casova";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ime profesora";
            // 
            // txtImePredmeta
            // 
            this.txtImePredmeta.Location = new System.Drawing.Point(338, 153);
            this.txtImePredmeta.Name = "txtImePredmeta";
            this.txtImePredmeta.Size = new System.Drawing.Size(188, 23);
            this.txtImePredmeta.TabIndex = 4;
            // 
            // txtBrojCasova
            // 
            this.txtBrojCasova.Location = new System.Drawing.Point(338, 182);
            this.txtBrojCasova.Name = "txtBrojCasova";
            this.txtBrojCasova.Size = new System.Drawing.Size(188, 23);
            this.txtBrojCasova.TabIndex = 5;
            // 
            // txtImeProfesora
            // 
            this.txtImeProfesora.Location = new System.Drawing.Point(337, 211);
            this.txtImeProfesora.Name = "txtImeProfesora";
            this.txtImeProfesora.Size = new System.Drawing.Size(189, 23);
            this.txtImeProfesora.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(203, 265);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(284, 265);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 8;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(365, 265);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(446, 265);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 10;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(527, 265);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // dgPredmeti
            // 
            this.dgPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPredmeti.Location = new System.Drawing.Point(12, 319);
            this.dgPredmeti.Name = "dgPredmeti";
            this.dgPredmeti.RowTemplate.Height = 25;
            this.dgPredmeti.Size = new System.Drawing.Size(776, 246);
            this.dgPredmeti.TabIndex = 12;
            // 
            // mnIzvestajPredmeti
            // 
            this.mnIzvestajPredmeti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnIzvestaj});
            this.mnIzvestajPredmeti.Location = new System.Drawing.Point(0, 0);
            this.mnIzvestajPredmeti.Name = "mnIzvestajPredmeti";
            this.mnIzvestajPredmeti.Size = new System.Drawing.Size(800, 24);
            this.mnIzvestajPredmeti.TabIndex = 13;
            this.mnIzvestajPredmeti.Text = "meni";
            // 
            // mnIzvestaj
            // 
            this.mnIzvestaj.Name = "mnIzvestaj";
            this.mnIzvestaj.Size = new System.Drawing.Size(57, 20);
            this.mnIzvestaj.Text = "Izvestaj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.dgPredmeti);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtImeProfesora);
            this.Controls.Add(this.txtBrojCasova);
            this.Controls.Add(this.txtImePredmeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnIzvestajPredmeti);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgPredmeti)).EndInit();
            this.mnIzvestajPredmeti.ResumeLayout(false);
            this.mnIzvestajPredmeti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtImePredmeta;
        private TextBox txtBrojCasova;
        private TextBox txtImeProfesora;
        private Button btnDodaj;
        private Button btnPromeni;
        private Button btnObrisi;
        private Button btnPotvrdi;
        private Button btnOdustani;
        private DataGridView dgPredmeti;
        private MenuStrip mnIzvestajPredmeti;
        private ToolStripMenuItem mnIzvestaj;
    }
}