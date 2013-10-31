namespace CaesarCipher
{
    partial class Form1
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
            this.plainText = new System.Windows.Forms.TextBox();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.Shift = new System.Windows.Forms.Button();
            this.shiftText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AlphabetOnly = new System.Windows.Forms.Button();
            this.AllCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(80, 37);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(347, 20);
            this.plainText.TabIndex = 0;
            this.plainText.Text = "your text here";
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(80, 63);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(347, 20);
            this.cipherText.TabIndex = 0;
            this.cipherText.Text = "---";
            // 
            // Shift
            // 
            this.Shift.Location = new System.Drawing.Point(153, 89);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(274, 20);
            this.Shift.TabIndex = 1;
            this.Shift.Text = "Shift";
            this.Shift.UseVisualStyleBackColor = true;
            this.Shift.Click += new System.EventHandler(this.Shift_Click);
            // 
            // shiftText
            // 
            this.shiftText.Location = new System.Drawing.Point(80, 89);
            this.shiftText.Name = "shiftText";
            this.shiftText.Size = new System.Drawing.Size(67, 20);
            this.shiftText.TabIndex = 0;
            this.shiftText.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plain text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cipher text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "No. of shift";
            // 
            // AlphabetOnly
            // 
            this.AlphabetOnly.Location = new System.Drawing.Point(80, 5);
            this.AlphabetOnly.Name = "AlphabetOnly";
            this.AlphabetOnly.Size = new System.Drawing.Size(169, 26);
            this.AlphabetOnly.TabIndex = 6;
            this.AlphabetOnly.Text = "Alphabet only";
            this.AlphabetOnly.UseVisualStyleBackColor = true;
            this.AlphabetOnly.Click += new System.EventHandler(this.AlphabetOnly_Click);
            // 
            // AllCharacter
            // 
            this.AllCharacter.Location = new System.Drawing.Point(255, 5);
            this.AllCharacter.Name = "AllCharacter";
            this.AllCharacter.Size = new System.Drawing.Size(172, 26);
            this.AllCharacter.TabIndex = 7;
            this.AllCharacter.Text = "All character";
            this.AllCharacter.UseVisualStyleBackColor = true;
            this.AllCharacter.Click += new System.EventHandler(this.AllCharacter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 121);
            this.Controls.Add(this.AllCharacter);
            this.Controls.Add(this.AlphabetOnly);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shift);
            this.Controls.Add(this.shiftText);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.plainText);
            this.Name = "Form1";
            this.Text = "Caesar Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.Button Shift;
        private System.Windows.Forms.TextBox shiftText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AlphabetOnly;
        private System.Windows.Forms.Button AllCharacter;
    }
}

