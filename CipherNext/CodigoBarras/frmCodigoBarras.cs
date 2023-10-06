using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace CipherNext.CodigoBarras
{
    public partial class frmCodigoBarras : Form
    {
        public frmCodigoBarras()
        {
            InitializeComponent();
        }

        private void btnCodigoBarras_Click(object sender, EventArgs e)
        {
            string texto = rtxtTexto.Text; // Obtém o texto da TextBox

            if (!string.IsNullOrWhiteSpace(texto))
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.CODE_128; // Escolha o formato desejado

                // Gera o código de barras a partir do texto
                pboxImagem.Image = barcodeWriter.Write(texto);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
