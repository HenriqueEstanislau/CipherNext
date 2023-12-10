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
    public partial class frmAtbash : Form
    {
        public frmAtbash()
        {
            InitializeComponent();
        }
        public static string Encrypt(string plainText)
        {
            string upperCaseText = plainText.ToUpper();
            StringBuilder encryptedText = new StringBuilder();

            foreach (char character in upperCaseText)
            {
                if (char.IsLetter(character))
                {
                    char encryptedChar = (char)('Z' - (character - 'A'));
                    encryptedText.Append(encryptedChar);
                }
                else
                {
                    encryptedText.Append(character);
                }
            }

            return encryptedText.ToString();
        }

        public static string Decrypt(string encryptedText)
        {
            string upperCaseText = encryptedText.ToUpper();
            StringBuilder decryptedText = new StringBuilder();

            foreach (char character in upperCaseText)
            {
                if (char.IsLetter(character))
                {
                    char decryptedChar = (char)('Z' - (character - 'A'));
                    decryptedText.Append(decryptedChar);
                }
                else
                {
                    decryptedText.Append(character);
                }
            }

            return decryptedText.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            frmVisualizarDescricao visualizarDescricao = new frmVisualizarDescricao(Properties.Resources.Atbash);
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
