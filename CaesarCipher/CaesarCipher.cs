using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    class CaesarCipher
    {
        private string cipherText;
        public CaesarCipher() 
        {
            cipherText = null;
        }
        public string CipherAllCharacter(int shift, string plainText) 
        {
            for (int i = 0; i < plainText.Length; i++) 
            {
                cipherText = cipherText + Convert.ToChar((plainText[i] + shift) % 127);
            }
            return cipherText;
        }

        public string CipherAlphabetOnly(int shift, string plainText)
        {
            int convertForm = 0;
            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] >= 65 && plainText[i] <= 90) 
                {
                    convertForm = ((plainText[i] - 64) + shift) % 26;
                    if (convertForm == 0) 
                    {
                        convertForm = 26;
                    }
                    cipherText = cipherText + Convert.ToChar(convertForm + 64);
                }
                else if ((plainText[i] >= 97 && plainText[i] <= 122))
                {
                    convertForm = ((plainText[i] - 96) + shift) % 26;
                    if (convertForm == 0)
                    {
                        convertForm = 26;
                    }
                    cipherText = cipherText + Convert.ToChar(convertForm + 96);
                }
                else 
                {
                    cipherText = cipherText + plainText[i];
                }
            }
            return cipherText;
        }
    }
}
