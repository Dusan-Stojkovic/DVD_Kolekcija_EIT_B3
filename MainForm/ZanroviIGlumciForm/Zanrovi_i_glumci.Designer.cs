namespace MainForm.ZanroviIGlumciForm
{
    partial class Zanrovi_i_glumci
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PrikaziButton = new System.Windows.Forms.Button();
            this.IzadjiButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv zanra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime glumca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime glumca";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 5;
            // 
            // PrikaziButton
            // 
            this.PrikaziButton.Location = new System.Drawing.Point(281, 32);
            this.PrikaziButton.Name = "PrikaziButton";
            this.PrikaziButton.Size = new System.Drawing.Size(75, 23);
            this.PrikaziButton.TabIndex = 6;
            this.PrikaziButton.Text = "Prikazi";
            this.PrikaziButton.UseVisualStyleBackColor = true;
            this.PrikaziButton.Click += new System.EventHandler(this.PrikaziButton_Click);
            // 
            // IzadjiButton
            // 
            this.IzadjiButton.Location = new System.Drawing.Point(281, 90);
            this.IzadjiButton.Name = "IzadjiButton";
            this.IzadjiButton.Size = new System.Drawing.Size(75, 23);
            this.IzadjiButton.TabIndex = 7;
            this.IzadjiButton.Text = "Izadji";
            this.IzadjiButton.UseVisualStyleBackColor = true;
            this.IzadjiButton.Click += new System.EventHandler(this.IzadjiButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(21, 165);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(335, 118);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Zanrovi_i_glumci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 309);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IzadjiButton);
            this.Controls.Add(this.PrikaziButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Zanrovi_i_glumci";
            this.Text = "Zanrovi i glumci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button PrikaziButton;
        private System.Windows.Forms.Button IzadjiButton;
        private System.Windows.Forms.ListView listView1;
    }
}