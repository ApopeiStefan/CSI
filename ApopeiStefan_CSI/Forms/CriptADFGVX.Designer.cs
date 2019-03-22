namespace ApopeiStefan_CSI.Forms
{
    partial class CriptADFGVX
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
            this.Criptare = new System.Windows.Forms.Button();
            this.textBoxTextCriptat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxCheie1 = new System.Windows.Forms.TextBox();
            this.textBoxCheie2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Criptare
            // 
            this.Criptare.Location = new System.Drawing.Point(52, 391);
            this.Criptare.Name = "Criptare";
            this.Criptare.Size = new System.Drawing.Size(118, 33);
            this.Criptare.TabIndex = 13;
            this.Criptare.Text = "Criptare";
            this.Criptare.UseVisualStyleBackColor = true;
            this.Criptare.Click += new System.EventHandler(this.OnClickCriptADFGVX);
            // 
            // textBoxTextCriptat
            // 
            this.textBoxTextCriptat.Location = new System.Drawing.Point(420, 103);
            this.textBoxTextCriptat.Multiline = true;
            this.textBoxTextCriptat.Name = "textBoxTextCriptat";
            this.textBoxTextCriptat.ReadOnly = true;
            this.textBoxTextCriptat.Size = new System.Drawing.Size(352, 282);
            this.textBoxTextCriptat.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Text criptat";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 103);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 10;
            this.labelText.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cheie1";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(52, 100);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(341, 282);
            this.textBoxText.TabIndex = 8;
            // 
            // textBoxCheie1
            // 
            this.textBoxCheie1.Location = new System.Drawing.Point(52, 30);
            this.textBoxCheie1.Name = "textBoxCheie1";
            this.textBoxCheie1.Size = new System.Drawing.Size(341, 20);
            this.textBoxCheie1.TabIndex = 7;
            // 
            // textBoxCheie2
            // 
            this.textBoxCheie2.Location = new System.Drawing.Point(52, 59);
            this.textBoxCheie2.Name = "textBoxCheie2";
            this.textBoxCheie2.Size = new System.Drawing.Size(341, 20);
            this.textBoxCheie2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cheie2";
            // 
            // CriptADFGVX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCheie2);
            this.Controls.Add(this.Criptare);
            this.Controls.Add(this.textBoxTextCriptat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxCheie1);
            this.Name = "CriptADFGVX";
            this.Text = "CriptADFGVX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Criptare;
        private System.Windows.Forms.TextBox textBoxTextCriptat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxCheie1;
        private System.Windows.Forms.TextBox textBoxCheie2;
        private System.Windows.Forms.Label label2;
    }
}