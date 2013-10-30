using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    class CaesarChipher
    {
        private string chipherText;
        public CaesarChipher() 
        {
            chipherText = null;
        }
        public string Chipher(int shift, string plainText) 
        {
            for (int i = 0; i < plainText.Length; i++) 
            {
                chipherText = chipherText + Convert.ToChar((plainText[i] + shift) % 127);
            }
            return chipherText;
        }
    }
}
