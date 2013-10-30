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
            this.chipherText = new System.Windows.Forms.TextBox();
            this.Shift = new System.Windows.Forms.Button();
            this.shiftText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(12, 7);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(347, 20);
            this.plainText.TabIndex = 0;
            // 
            // chipherText
            // 
            this.chipherText.Location = new System.Drawing.Point(12, 33);
            this.chipherText.Name = "chipherText";
            this.chipherText.Size = new System.Drawing.Size(347, 20);
            this.chipherText.TabIndex = 0;
            // 
            // Shift
            // 
            this.Shift.Location = new System.Drawing.Point(85, 59);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(274, 20);
            this.Shift.TabIndex = 1;
            this.Shift.Text = "Shift";
            this.Shift.UseVisualStyleBackColor = true;
            this.Shift.Click += new System.EventHandler(this.Shift_Click);
            // 
            // shiftText
            // 
            this.shiftText.Location = new System.Drawing.Point(12, 59);
            this.shiftText.Name = "shiftText";
            this.shiftText.Size = new System.Drawing.Size(67, 20);
            this.shiftText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 87);
            this.Controls.Add(this.Shift);
            this.Controls.Add(this.shiftText);
            this.Controls.Add(this.chipherText);
            this.Controls.Add(this.plainText);
            this.Name = "Form1";
            this.Text = "Caesar Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.TextBox chipherText;
        private System.Windows.Forms.Button Shift;
        private System.Windows.Forms.TextBox shiftText;
    }
}

