﻿namespace ApopeiStefan_CSI
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.Cript = new System.Windows.Forms.ToolStripMenuItem();
            this.CriptPlayfair = new System.Windows.Forms.ToolStripMenuItem();
            this.Decript = new System.Windows.Forms.ToolStripMenuItem();
            this.DecriptPlayfair = new System.Windows.Forms.ToolStripMenuItem();
            this.aDFGVXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cript,
            this.Decript});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // Cript
            // 
            this.Cript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CriptPlayfair,
            this.aDFGVXToolStripMenuItem});
            this.Cript.Name = "Cript";
            this.Cript.Size = new System.Drawing.Size(58, 20);
            this.Cript.Text = "Criptari";
            // 
            // CriptPlayfair
            // 
            this.CriptPlayfair.Name = "CriptPlayfair";
            this.CriptPlayfair.Size = new System.Drawing.Size(180, 22);
            this.CriptPlayfair.Text = "Playfair";
            this.CriptPlayfair.Click += new System.EventHandler(this.OnCriptPlayfair);
            // 
            // Decript
            // 
            this.Decript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DecriptPlayfair});
            this.Decript.Name = "Decript";
            this.Decript.Size = new System.Drawing.Size(70, 20);
            this.Decript.Text = "Decriptari";
            // 
            // DecriptPlayfair
            // 
            this.DecriptPlayfair.Name = "DecriptPlayfair";
            this.DecriptPlayfair.Size = new System.Drawing.Size(113, 22);
            this.DecriptPlayfair.Text = "Playfair";
            // 
            // aDFGVXToolStripMenuItem
            // 
            this.aDFGVXToolStripMenuItem.Name = "aDFGVXToolStripMenuItem";
            this.aDFGVXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDFGVXToolStripMenuItem.Text = "ADFGVX";
            this.aDFGVXToolStripMenuItem.Click += new System.EventHandler(this.OnClickCriptareADFGVX);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem Cript;
        private System.Windows.Forms.ToolStripMenuItem CriptPlayfair;
        private System.Windows.Forms.ToolStripMenuItem Decript;
        private System.Windows.Forms.ToolStripMenuItem DecriptPlayfair;
        private System.Windows.Forms.ToolStripMenuItem aDFGVXToolStripMenuItem;
    }
}
