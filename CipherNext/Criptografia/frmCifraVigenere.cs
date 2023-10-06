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
    public partial class frmCifraVigenere : Form
    {
        public frmCifraVigenere()
        {
            InitializeComponent();
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
            if (txtChave.Text == "")
            {
                MessageBox.Show("Insira uma chave!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rtxtCriptografado.Text = EncryptVigenere(rtxtTexto.Text.ToUpper(), txtChave.Text.ToUpper());
            
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            if (txtChave.Text == "")
            {
                MessageBox.Show("Insira uma chave!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rtxtTexto.Text = DecryptVigenere(rtxtCriptografado.Text.ToUpper(), txtChave.Text.ToUpper());
        }

        private string EncryptVigenere(string plaintext, string key)
        {
            StringBuilder encryptedText = new StringBuilder();
            int keyLength = key.Length;

            for (int i = 0; i < plaintext.Length; i++)
            {
                char plainChar = plaintext[i];
                char keyChar = key[i % keyLength];
                if (char.IsLetter(plainChar))
                {
                    char encryptedChar = (char)((plainChar + keyChar - 2 * 'A') % 26 + 'A');
                    encryptedText.Append(encryptedChar);
                }
                else
                {
                    encryptedText.Append(plainChar);
                }
            }

            return encryptedText.ToString();
        }

        private string DecryptVigenere(string encryptedText, string key)
        {
            StringBuilder decryptedText = new StringBuilder();
            int keyLength = key.Length;

            for (int i = 0; i < encryptedText.Length; i++)
            {
                char encryptedChar = encryptedText[i];
                char keyChar = key[i % keyLength];

                if (char.IsLetter(encryptedChar))
                {
                    char decryptedChar = (char)(((encryptedChar - keyChar + 26) % 26) + 'A');
                    decryptedText.Append(decryptedChar);
                }
                else
                {
                    decryptedText.Append(encryptedChar);
                }
            }

            return decryptedText.ToString();
        }
    }
}
