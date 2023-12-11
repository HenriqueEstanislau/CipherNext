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
    public partial class frmCodigoBinario : Form
    {
        public frmCodigoBinario()
        {
            InitializeComponent();
        }
        private string CriptografarTexto(string texto)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(texto);
            StringBuilder binaryText = new StringBuilder();
            foreach (byte b in bytes)
            {
                binaryText.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                binaryText.Append(" ");
            }
            return binaryText.ToString();
        }

        private string DescriptografarTexto(string textoBinario)
        {
            string[] partes = textoBinario.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] bytes = new byte[partes.Length];
            for (int i = 0; i < partes.Length; i++)
            {
                bytes[i] = Convert.ToByte(partes[i], 2);
            }
            return Encoding.ASCII.GetString(bytes);
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            string textoOriginal = rtxtTexto.Text;
            string textoCriptografado = CriptografarTexto(textoOriginal);
            rtxtCriptografado.Text = textoCriptografado;
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            string textoBinario = rtxtCriptografado.Text;
            string textoDescriptografado = DescriptografarTexto(textoBinario);
            rtxtTexto.Text = textoDescriptografado;
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            frmVisualizarDescricao visualizarDescricao = new frmVisualizarDescricao(Properties.Resources.Codigo_Binario);
            visualizarDescricao.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
