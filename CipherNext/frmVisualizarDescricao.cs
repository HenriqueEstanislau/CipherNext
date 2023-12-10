using Patagames.Pdf.Net.Controls.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CipherNext
{
    public partial class frmVisualizarDescricao : Form
    {
        private PdfViewer pdfViewer;
        public frmVisualizarDescricao(byte[] nomeArtigo)
        {
            InitializeComponent();
            ExibirDescricao(nomeArtigo);
        }
        private void ExibirDescricao(byte[] artigo)
        {
            pdfViewer = new PdfViewer();
            Controls.Add(pdfViewer);
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.LoadDocument(artigo);
        }
    }
}
