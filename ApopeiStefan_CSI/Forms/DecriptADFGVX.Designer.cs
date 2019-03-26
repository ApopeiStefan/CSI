namespace ApopeiStefan_CSI.Forms
{
    partial class DecriptADFGVX
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCheie2 = new System.Windows.Forms.TextBox();
            this.Criptare = new System.Windows.Forms.Button();
            this.textBoxTextDecriptat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxCheie1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cheie2";
            // 
            // textBoxCheie2
            // 
            this.textBoxCheie2.Location = new System.Drawing.Point(52, 53);
            this.textBoxCheie2.Name = "textBoxCheie2";
            this.textBoxCheie2.Size = new System.Drawing.Size(341, 20);
            this.textBoxCheie2.TabIndex = 23;
            // 
            // Criptare
            // 
            this.Criptare.Location = new System.Drawing.Point(52, 385);
            this.Criptare.Name = "Criptare";
            this.Criptare.Size = new System.Drawing.Size(118, 33);
            this.Criptare.TabIndex = 22;
            this.Criptare.Text = "Decriptare";
            this.Criptare.UseVisualStyleBackColor = true;
            this.Criptare.Click += new System.EventHandler(this.OnDecriptareADFGVX);
            // 
            // textBoxTextDecriptat
            // 
            this.textBoxTextDecriptat.Location = new System.Drawing.Point(420, 97);
            this.textBoxTextDecriptat.Multiline = true;
            this.textBoxTextDecriptat.Name = "textBoxTextDecriptat";
            this.textBoxTextDecriptat.ReadOnly = true;
            this.textBoxTextDecriptat.Size = new System.Drawing.Size(352, 282);
            this.textBoxTextDecriptat.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Text criptat";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 97);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 19;
            this.labelText.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cheie1";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(52, 94);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(341, 282);
            this.textBoxText.TabIndex = 17;
            // 
            // textBoxCheie1
            // 
            this.textBoxCheie1.Location = new System.Drawing.Point(52, 24);
            this.textBoxCheie1.Name = "textBoxCheie1";
            this.textBoxCheie1.Size = new System.Drawing.Size(341, 20);
            this.textBoxCheie1.TabIndex = 16;
            // 
            // DecriptADFGVX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCheie2);
            this.Controls.Add(this.Criptare);
            this.Controls.Add(this.textBoxTextDecriptat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxCheie1);
            this.Name = "DecriptADFGVX";
            this.Text = "DecriptADFGVX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCheie2;
        private System.Windows.Forms.Button Criptare;
        private System.Windows.Forms.TextBox textBoxTextDecriptat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxCheie1;
    }
}