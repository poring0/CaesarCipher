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
        public Form1()
        {
            InitializeComponent();
        }

        private void Shift_Click(object sender, EventArgs e)
        {
            CaesarChipher plainToCipher = new CaesarChipher();
            chipherText.Text = plainToCipher.Chipher(Convert.ToInt16(shiftText.Text), plainText.Text);
        }
    }
}
