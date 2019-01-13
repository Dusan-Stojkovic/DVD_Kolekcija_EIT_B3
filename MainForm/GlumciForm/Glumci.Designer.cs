namespace MainForm.GlumciForm
{
    partial class Glumci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SifraTextBox = new System.Windows.Forms.TextBox();
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.PrezimeTextBox = new System.Windows.Forms.TextBox();
            this.DatumRodjenjaTextBox = new System.Windows.Forms.TextBox();
            this.MestoRodjenjaTextBox = new System.Windows.Forms.TextBox();
            this.UpisiButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.IzmeniButton = new System.Windows.Forms.Button();
            this.IzadjiButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodjenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesto rodjenja";
            // 
            // SifraTextBox
            // 
            this.SifraTextBox.Location = new System.Drawing.Point(62, 29);
            this.SifraTextBox.Name = "SifraTextBox";
            this.SifraTextBox.Size = new System.Drawing.Size(100, 20);
            this.SifraTextBox.TabIndex = 5;
            this.SifraTextBox.TextChanged += new System.EventHandler(this.SifraTextBox_TextChanged);
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(62, 59);
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImeTextBox.TabIndex = 6;
            // 
            // PrezimeTextBox
            // 
            this.PrezimeTextBox.Location = new System.Drawing.Point(266, 26);
            this.PrezimeTextBox.Name = "PrezimeTextBox";
            this.PrezimeTextBox.Size = new System.Drawing.Size(99, 20);
            this.PrezimeTextBox.TabIndex = 7;
            // 
            // DatumRodjenjaTextBox
            // 
            this.DatumRodjenjaTextBox.Location = new System.Drawing.Point(266, 56);
            this.DatumRodjenjaTextBox.Name = "DatumRodjenjaTextBox";
            this.DatumRodjenjaTextBox.Size = new System.Drawing.Size(167, 20);
            this.DatumRodjenjaTextBox.TabIndex = 8;
            // 
            // MestoRodjenjaTextBox
            // 
            this.MestoRodjenjaTextBox.Location = new System.Drawing.Point(266, 89);
            this.MestoRodjenjaTextBox.Name = "MestoRodjenjaTextBox";
            this.MestoRodjenjaTextBox.Size = new System.Drawing.Size(99, 20);
            this.MestoRodjenjaTextBox.TabIndex = 9;
            // 
            // UpisiButton
            // 
            this.UpisiButton.Location = new System.Drawing.Point(24, 131);
            this.UpisiButton.Name = "UpisiButton";
            this.UpisiButton.Size = new System.Drawing.Size(75, 23);
            this.UpisiButton.TabIndex = 10;
            this.UpisiButton.Text = "Upisi";
            this.UpisiButton.UseVisualStyleBackColor = true;
            this.UpisiButton.Click += new System.EventHandler(this.UpisiButton_Click);
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(147, 131);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(75, 23);
            this.ObrisiButton.TabIndex = 11;
            this.ObrisiButton.Text = "Obisi";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            this.ObrisiButton.Click += new System.EventHandler(this.ObrisiButton_Click);
            // 
            // IzmeniButton
            // 
            this.IzmeniButton.Location = new System.Drawing.Point(250, 131);
            this.IzmeniButton.Name = "IzmeniButton";
            this.IzmeniButton.Size = new System.Drawing.Size(75, 23);
            this.IzmeniButton.TabIndex = 12;
            this.IzmeniButton.Text = "Izmeni";
            this.IzmeniButton.UseVisualStyleBackColor = true;
            this.IzmeniButton.Click += new System.EventHandler(this.IzmeniButton_Click);
            // 
            // IzadjiButton
            // 
            this.IzadjiButton.Location = new System.Drawing.Point(358, 131);
            this.IzadjiButton.Name = "IzadjiButton";
            this.IzadjiButton.Size = new System.Drawing.Size(75, 23);
            this.IzadjiButton.TabIndex = 13;
            this.IzadjiButton.Text = "Izadji";
            this.IzadjiButton.UseVisualStyleBackColor = true;
            this.IzadjiButton.Click += new System.EventHandler(this.IzadjiButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(24, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(409, 183);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Glumci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 355);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IzadjiButton);
            this.Controls.Add(this.IzmeniButton);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.UpisiButton);
            this.Controls.Add(this.MestoRodjenjaTextBox);
            this.Controls.Add(this.DatumRodjenjaTextBox);
            this.Controls.Add(this.PrezimeTextBox);
            this.Controls.Add(this.ImeTextBox);
            this.Controls.Add(this.SifraTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Glumci";
            this.Text = "Glumci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SifraTextBox;
        private System.Windows.Forms.TextBox ImeTextBox;
        private System.Windows.Forms.TextBox PrezimeTextBox;
        private System.Windows.Forms.TextBox DatumRodjenjaTextBox;
        private System.Windows.Forms.TextBox MestoRodjenjaTextBox;
        private System.Windows.Forms.Button UpisiButton;
        private System.Windows.Forms.Button ObrisiButton;
        private System.Windows.Forms.Button IzmeniButton;
        private System.Windows.Forms.Button IzadjiButton;
        private System.Windows.Forms.ListView listView1;
    }
}