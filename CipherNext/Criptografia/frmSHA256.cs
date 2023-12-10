using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherNext.Criptografia
{
    public partial class frmSHA256 : Form
    {
        public frmSHA256()
        {
            InitializeComponent();
        }
        private string CalcularSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            txtHash.Text = CalcularSHA256(rtxtTexto.Text);
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            frmVisualizarDescricao visualizarDescricao = new frmVisualizarDescricao(Properties.Resources.SHA_256);
            visualizarDescricao.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
