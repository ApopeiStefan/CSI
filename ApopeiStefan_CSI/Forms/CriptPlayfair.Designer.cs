namespace ApopeiStefan_CSI.Forms
{
    partial class CriptPlayfair
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
            this.textBoxCheie = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTextCriptat = new System.Windows.Forms.TextBox();
            this.Criptare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCheie
            // 
            this.textBoxCheie.Location = new System.Drawing.Point(52, 16);
            this.textBoxCheie.Name = "textBoxCheie";
            this.textBoxCheie.Size = new System.Drawing.Size(341, 20);
            this.textBoxCheie.TabIndex = 0;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(52, 48);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(341, 282);
            this.textBoxText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cheie";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(11, 55);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text criptat";
            // 
            // textBoxTextCriptat
            // 
            this.textBoxTextCriptat.Location = new System.Drawing.Point(420, 48);
            this.textBoxTextCriptat.Multiline = true;
            this.textBoxTextCriptat.Name = "textBoxTextCriptat";
            this.textBoxTextCriptat.ReadOnly = true;
            this.textBoxTextCriptat.Size = new System.Drawing.Size(352, 282);
            this.textBoxTextCriptat.TabIndex = 5;
            // 
            // Criptare
            // 
            this.Criptare.Location = new System.Drawing.Point(52, 337);
            this.Criptare.Name = "Criptare";
            this.Criptare.Size = new System.Drawing.Size(118, 33);
            this.Criptare.TabIndex = 6;
            this.Criptare.Text = "Criptare";
            this.Criptare.UseVisualStyleBackColor = true;
            this.Criptare.Click += new System.EventHandler(this.OnCriptare);
            // 
            // CriptPlayfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Criptare);
            this.Controls.Add(this.textBoxTextCriptat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxCheie);
            this.Name = "CriptPlayfair";
            this.Text = "Criptare Playfair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCheie;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTextCriptat;
        private System.Windows.Forms.Button Criptare;
    }
}