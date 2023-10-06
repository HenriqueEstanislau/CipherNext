using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherNext.Criptografia
{
    public partial class frmA1Z26 : Form
    {
        public frmA1Z26()
        {
            InitializeComponent();
        }

        public static string Encrypt(string plainText)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string encryptedText = "";

            foreach (char letter in plainText.ToUpper())
            {
                if (char.IsLetter(letter))
                {
                    int index = alphabet.IndexOf(letter) + 1;
                    encryptedText += index.ToString() + " ";
                }
                else if (letter == ' ')
                {
                    encryptedText += " ";
                }
            }

            return encryptedText.Trim();
        }

        public static string Decrypt(string cipherText)
        {
            string[] cipherArray = cipherText.Split(' ');
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string decryptedText = "";

            foreach (string cipherChar in cipherArray)
            {
                if (!string.IsNullOrWhiteSpace(cipherChar))
                {
                    int index;
                    if (int.TryParse(cipherChar, out index) && index >= 1 && index <= 26)
                    {
                        char decryptedChar = alphabet[index - 1];
                        decryptedText += decryptedChar;
                    }
                    else
                    {
                        decryptedText += "?";
                    }
                }
                else
                {
                    decryptedText += " ";
                }
            }

            return decryptedText;
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            frmVisualizarDescricao visualizarDescricao = new frmVisualizarDescricao();
            visualizarDescricao.ShowDialog();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            rtxtCriptografado.Text = Encrypt(rtxtTexto.Text);
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            rtxtTexto.Text = Decrypt(rtxtCriptografado.Text);
        }
    }
}
