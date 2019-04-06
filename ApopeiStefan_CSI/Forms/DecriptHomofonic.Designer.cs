namespace ApopeiStefan_CSI.Forms
{
    partial class DecriptHomofonic
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
            this.textBoxTextDecriptat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Criptare
            // 
            this.Criptare.Location = new System.Drawing.Point(39, 344);
            this.Criptare.Name = "Criptare";
            this.Criptare.Size = new System.Drawing.Size(118, 33);
            this.Criptare.TabIndex = 32;
            this.Criptare.Text = "Decriptare";
            this.Criptare.UseVisualStyleBackColor = true;
            this.Criptare.Click += new System.EventHandler(this.OnClickDecriptare);
            // 
            // textBoxTextDecriptat
            // 
            this.textBoxTextDecriptat.Location = new System.Drawing.Point(407, 56);
            this.textBoxTextDecriptat.Multiline = true;
            this.textBoxTextDecriptat.Name = "textBoxTextDecriptat";
            this.textBoxTextDecriptat.ReadOnly = true;
            this.textBoxTextDecriptat.Size = new System.Drawing.Size(352, 282);
            this.textBoxTextDecriptat.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Text criptat";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(36, 31);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 29;
            this.labelText.Text = "Text";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(39, 53);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(341, 282);
            this.textBoxText.TabIndex = 28;
            // 
            // DecriptHomofonic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Criptare);
            this.Controls.Add(this.textBoxTextDecriptat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxText);
            this.Name = "DecriptHomofonic";
            this.Text = "DecriptHomofonic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Criptare;
        private System.Windows.Forms.TextBox textBoxTextDecriptat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxText;
    }
}