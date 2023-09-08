using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;

namespace CipherNext.Criptografia
{
    public partial class frmMD5 : Form
    {
        public frmMD5()
        {
            InitializeComponent();
        }

        private string CalcularMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input); // Converte a entrada em bytes
                byte[] hashBytes = md5.ComputeHash(inputBytes); // Calcula o hash MD5

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // Converte o hash em uma representação hexadecimal
                }

                return builder.ToString();
            }
        }
        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            txtHash.Text = CalcularMD5Hash(rtxtTexto.Text);
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
    }
}
