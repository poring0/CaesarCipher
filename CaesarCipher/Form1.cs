using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        private bool mode;
        public Form1()
        {
            InitializeComponent();
            mode = true;
            AllCharacter.Enabled = false;
        }

        private void Shift_Click(object sender, EventArgs e)
        {
            CaesarCipher plainToCipher = new CaesarCipher();
            if (mode == true)
            {
                try
                {
                    cipherText.Text = plainToCipher.CipherAllCharacter(Convert.ToInt16(shiftText.Text), plainText.Text);
                }
                catch (Exception execeptionOne)
                {
                    MessageBox.Show("Please fill in all blanks.\n-----------------------\n" + execeptionOne.ToString());
                }
            }
            else
            {
                try
                {
                    cipherText.Text = plainToCipher.CipherAlphabetOnly(Convert.ToInt16(shiftText.Text), plainText.Text);

                }
                catch (Exception execeptionTwo)
                {
                    MessageBox.Show("Please fill in all blanks.\n-----------------------\n" + execeptionTwo.ToString());
                }
            }
        }

        private void AlphabetOnly_Click(object sender, EventArgs e)
        {
            if (mode == true)
            {
                AllCharacter.Enabled = true;
                AlphabetOnly.Enabled = false;
                mode = false;
            }
        }

        private void AllCharacter_Click(object sender, EventArgs e)
        {
            if (mode == false) 
            {
                AllCharacter.Enabled = false;
                AlphabetOnly.Enabled = true;
                mode = true;
            }
        }

        
    }
}
