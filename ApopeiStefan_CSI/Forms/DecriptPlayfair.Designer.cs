namespace ApopeiStefan_CSI.Forms
{
    partial class DecriptPlayfair
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
            this.textBoxCheie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Criptare
            // 
            this.Criptare.Location = new System.Drawing.Point(50, 344);
            this.Criptare.Name = "Criptare";
            this.Criptare.Size = new System.Drawing.Size(118, 33);
            this.Criptare.TabIndex = 20;
            this.Criptare.Text = "Decriptare";
            this.Criptare.UseVisualStyleBackColor = true;
            this.Criptare.Click += new System.EventHandler(this.OnClickDecriptPlayfaire);
            // 
            // textBoxTextCriptat
            // 
            this.textBoxTextCriptat.Location = new System.Drawing.Point(418, 55);
            this.textBoxTextCriptat.Multiline = true;
            this.textBoxTextCriptat.Name = "textBoxTextCriptat";
            this.textBoxTextCriptat.ReadOnly = true;
            this.textBoxTextCriptat.Size = new System.Drawing.Size(352, 282);
            this.textBoxTextCriptat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Text criptat";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(9, 62);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 17;
            this.labelText.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cheie";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(50, 55);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(341, 282);
            this.textBoxText.TabIndex = 15;
            // 
            // textBoxCheie
            // 
            this.textBoxCheie.Location = new System.Drawing.Point(50, 23);
            this.textBoxCheie.Name = "textBoxCheie";
            this.textBoxCheie.Size = new System.Drawing.Size(341, 20);
            this.textBoxCheie.TabIndex = 14;
            // 
            // DecriptPlayfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 432);
            this.Controls.Add(this.Criptare);
            this.Controls.Add(this.textBoxTextCriptat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxCheie);
            this.Name = "DecriptPlayfair";
            this.Text = "DecriptPlayfair";
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
        private System.Windows.Forms.TextBox textBoxCheie;
    }
}