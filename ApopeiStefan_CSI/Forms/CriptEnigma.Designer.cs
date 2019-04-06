namespace ApopeiStefan_CSI.Forms
{
    partial class CriptEnigma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxR1 = new System.Windows.Forms.ComboBox();
            this.comboBoxRf1 = new System.Windows.Forms.ComboBox();
            this.comboBoxR2 = new System.Windows.Forms.ComboBox();
            this.comboBoxR3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Criptare
            // 
            this.Criptare.Location = new System.Drawing.Point(60, 365);
            this.Criptare.Name = "Criptare";
            this.Criptare.Size = new System.Drawing.Size(118, 33);
            this.Criptare.TabIndex = 27;
            this.Criptare.Text = "Criptare";
            this.Criptare.UseVisualStyleBackColor = true;
            this.Criptare.Click += new System.EventHandler(this.OnClickCriptare);
            // 
            // textBoxTextDecriptat
            // 
            this.textBoxTextDecriptat.Location = new System.Drawing.Point(428, 77);
            this.textBoxTextDecriptat.Multiline = true;
            this.textBoxTextDecriptat.Name = "textBoxTextDecriptat";
            this.textBoxTextDecriptat.ReadOnly = true;
            this.textBoxTextDecriptat.Size = new System.Drawing.Size(352, 282);
            this.textBoxTextDecriptat.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Text criptat";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(20, 77);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 24;
            this.labelText.Text = "Text";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(60, 74);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(341, 282);
            this.textBoxText.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ordine rotoare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Reflectoare";
            // 
            // comboBoxR1
            // 
            this.comboBoxR1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxR1.FormattingEnabled = true;
            this.comboBoxR1.Items.AddRange(new object[] {
            "Rotor 1",
            "Rotor 2",
            "Rotor 3",
            "Rotor 4",
            "Rotor 5",
            "Rotor 6",
            "Rotor 7",
            "Rotor 8",
            "Rotor 9",
            "Rotor 10"});
            this.comboBoxR1.Location = new System.Drawing.Point(100, 7);
            this.comboBoxR1.Name = "comboBoxR1";
            this.comboBoxR1.Size = new System.Drawing.Size(78, 21);
            this.comboBoxR1.TabIndex = 30;
            // 
            // comboBoxRf1
            // 
            this.comboBoxRf1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRf1.FormattingEnabled = true;
            this.comboBoxRf1.Items.AddRange(new object[] {
            "Reflector B",
            "Reflector C"});
            this.comboBoxRf1.Location = new System.Drawing.Point(100, 35);
            this.comboBoxRf1.Name = "comboBoxRf1";
            this.comboBoxRf1.Size = new System.Drawing.Size(78, 21);
            this.comboBoxRf1.TabIndex = 36;
            // 
            // comboBoxR2
            // 
            this.comboBoxR2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxR2.FormattingEnabled = true;
            this.comboBoxR2.Items.AddRange(new object[] {
            "Rotor 1",
            "Rotor 2",
            "Rotor 3",
            "Rotor 4",
            "Rotor 5",
            "Rotor 6",
            "Rotor 7",
            "Rotor 8",
            "Rotor 9",
            "Rotor 10"});
            this.comboBoxR2.Location = new System.Drawing.Point(184, 8);
            this.comboBoxR2.Name = "comboBoxR2";
            this.comboBoxR2.Size = new System.Drawing.Size(78, 21);
            this.comboBoxR2.TabIndex = 38;
            // 
            // comboBoxR3
            // 
            this.comboBoxR3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxR3.FormattingEnabled = true;
            this.comboBoxR3.Items.AddRange(new object[] {
            "Rotor 1",
            "Rotor 2",
            "Rotor 3",
            "Rotor 4",
            "Rotor 5",
            "Rotor 6",
            "Rotor 7",
            "Rotor 8",
            "Rotor 9",
            "Rotor 10"});
            this.comboBoxR3.Location = new System.Drawing.Point(268, 8);
            this.comboBoxR3.Name = "comboBoxR3";
            this.comboBoxR3.Size = new System.Drawing.Size(78, 21);
            this.comboBoxR3.TabIndex = 39;
            // 
            // CriptEnigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.comboBoxR3);
            this.Controls.Add(this.comboBoxR2);
            this.Controls.Add(this.comboBoxRf1);
            this.Controls.Add(this.comboBoxR1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Criptare);
            this.Controls.Add(this.textBoxTextDecriptat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxText);
            this.Name = "CriptEnigma";
            this.Text = "CriptEnigma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Criptare;
        private System.Windows.Forms.TextBox textBoxTextDecriptat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxR1;
        private System.Windows.Forms.ComboBox comboBoxRf1;
        private System.Windows.Forms.ComboBox comboBoxR2;
        private System.Windows.Forms.ComboBox comboBoxR3;
    }
}