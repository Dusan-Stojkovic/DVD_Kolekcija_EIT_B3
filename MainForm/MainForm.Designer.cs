﻿namespace MainForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glumciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poZanrovimaIGlumcimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poTipuUlogeIProducentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazAltIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podaciToolStripMenuItem,
            this.upitiToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glumciToolStripMenuItem,
            this.producentiToolStripMenuItem});
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.podaciToolStripMenuItem.Text = "Podaci";
            // 
            // glumciToolStripMenuItem
            // 
            this.glumciToolStripMenuItem.Name = "glumciToolStripMenuItem";
            this.glumciToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.glumciToolStripMenuItem.Text = "Glumci";
            this.glumciToolStripMenuItem.Click += new System.EventHandler(this.glumciToolStripMenuItem_Click);
            // 
            // producentiToolStripMenuItem
            // 
            this.producentiToolStripMenuItem.Name = "producentiToolStripMenuItem";
            this.producentiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.producentiToolStripMenuItem.Text = "Producenti";
            this.producentiToolStripMenuItem.Click += new System.EventHandler(this.producentiToolStripMenuItem_Click);
            // 
            // upitiToolStripMenuItem
            // 
            this.upitiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poZanrovimaIGlumcimaToolStripMenuItem,
            this.poTipuUlogeIProducentuToolStripMenuItem});
            this.upitiToolStripMenuItem.Name = "upitiToolStripMenuItem";
            this.upitiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.upitiToolStripMenuItem.Text = "Upiti";
            // 
            // poZanrovimaIGlumcimaToolStripMenuItem
            // 
            this.poZanrovimaIGlumcimaToolStripMenuItem.Name = "poZanrovimaIGlumcimaToolStripMenuItem";
            this.poZanrovimaIGlumcimaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.poZanrovimaIGlumcimaToolStripMenuItem.Text = "Po zanrovima i glumcima";
            this.poZanrovimaIGlumcimaToolStripMenuItem.Click += new System.EventHandler(this.poZanrovimaIGlumcimaToolStripMenuItem_Click);
            // 
            // poTipuUlogeIProducentuToolStripMenuItem
            // 
            this.poTipuUlogeIProducentuToolStripMenuItem.Name = "poTipuUlogeIProducentuToolStripMenuItem";
            this.poTipuUlogeIProducentuToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.poTipuUlogeIProducentuToolStripMenuItem.Text = "Po tipu uloge i producentu";
            this.poTipuUlogeIProducentuToolStripMenuItem.Click += new System.EventHandler(this.poTipuUlogeIProducentuToolStripMenuItem_Click);
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazAltIToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // izlazAltIToolStripMenuItem
            // 
            this.izlazAltIToolStripMenuItem.Name = "izlazAltIToolStripMenuItem";
            this.izlazAltIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazAltIToolStripMenuItem.Text = "Izlaz Alt + I";
            this.izlazAltIToolStripMenuItem.Click += new System.EventHandler(this.izlazAltIToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 269);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glumciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poZanrovimaIGlumcimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poTipuUlogeIProducentuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazAltIToolStripMenuItem;
    }
}

