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
    public partial class frmBase64 : Form
    {
        public frmBase64()
        {
            InitializeComponent();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            string textToEncrypt = rtxtTexto.Text;
            byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);
            string encryptedText = Convert.ToBase64String(bytesToEncrypt);
            rtxtCriptografado.Text = encryptedText;
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            string encryptedText = rtxtCriptografado.Text;
            try
            {
                byte[] bytesToDecrypt = Convert.FromBase64String(encryptedText);
                string decryptedText = Encoding.UTF8.GetString(bytesToDecrypt);
                rtxtTexto.Text = decryptedText;
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro ao descriptografar o texto.");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            frmVisualizarDescricao visualizarDescricao = new frmVisualizarDescricao(Properties.Resources.Base_64);
            visualizarDescricao.ShowDialog();
        }
    }
}
