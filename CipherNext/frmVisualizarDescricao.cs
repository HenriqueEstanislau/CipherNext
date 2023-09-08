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
        public frmVisualizarDescricao()
        {
            InitializeComponent();
        }

        private async void frmVisualizarDescricao_Load(object sender, EventArgs e)
        {
            StringBuilder htmlText = new StringBuilder();
            htmlText.Clear();
            htmlText.Append("");
            htmlText.Append("<!DOCTYPE html> ");
            htmlText.Append("<html lang='en'> ");
            htmlText.Append("<head> ");
            htmlText.Append("    <meta charset='UTF-8' > ");
            htmlText.Append("    <meta http-equiv='X-UA-Compatible' content ='IE =edge' > ");
            htmlText.Append("    <meta name='viewport' content='width =device-width, initial-scale=1.0'> ");
            htmlText.Append("    <title>View</title> ");
            htmlText.Append("    <style>  ");
            htmlText.Append("        section{ ");
            htmlText.Append("            margin: 80px; ");
            htmlText.Append("        } ");
            htmlText.Append("        h1{ ");
            htmlText.Append("            font-family: Verdana, sans-serif; ");
            htmlText.Append("            font: 400; ");
            htmlText.Append("            font-size: 40px; ");
            htmlText.Append("        } ");
            htmlText.Append("        h2{ ");
            htmlText.Append("            font-family: Verdana, sans-serif; ");
            htmlText.Append("            font: 400; ");
            htmlText.Append("        } ");
            htmlText.Append("        p{ ");
            htmlText.Append("            font-family: Verdana, sans-serif; ");
            htmlText.Append("            font: 400; ");
            htmlText.Append("            font-size: 14px; ");
            htmlText.Append("        } ");
            htmlText.Append("    </style> ");
            htmlText.Append("</head> ");
            htmlText.Append("<body> ");
            htmlText.Append("    <section> ");
            htmlText.Append("        <div class='title' > ");
            htmlText.Append("            <h1>Titulo</h1> ");
            htmlText.Append("        </div> ");
            htmlText.Append("        <div class='subtitle'> ");
            htmlText.Append("            <h2>Informações<h2> ");
            htmlText.Append("        </div> ");
            htmlText.Append("        <div class='text' > ");
            htmlText.Append("            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni minus fugit exercitationem nam fugiat porro aliquam mollitia, reiciendis veritatis a! Quisquam unde et nulla voluptatum optio magnam autem hic obcaecati illo asperiores, expedita error iusto. Fugiat inventore rem excepturi ipsam dignissimos, deserunt molestias incidunt iste asperiores! Facere accusamus dolor molestiae.</p> ");
            htmlText.Append("            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem minus modi impedit explicabo quisquam distinctio, odit accusantium tempora dolores rem in eos voluptates aspernatur nihil, facere sint quas saepe sed dolor? Quaerat?</p> ");
            htmlText.Append("        </div> ");
            htmlText.Append("        <div class='subtitle' > ");
            htmlText.Append("            <h2>Informações<h2> ");
            htmlText.Append("        </div> ");
            htmlText.Append("        <div class='text'> ");
            htmlText.Append("            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni minus fugit exercitationem nam fugiat porro aliquam mollitia, reiciendis veritatis a! Quisquam unde et nulla voluptatum optio magnam autem hic obcaecati illo asperiores, expedita error iusto. Fugiat inventore rem excepturi ipsam dignissimos, deserunt molestias incidunt iste asperiores! Facere accusamus dolor molestiae.</p> ");
            htmlText.Append("            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Doloribus hic eos ex, omnis quae quam at minima rem impedit dolore provident in porro? Sapiente asperiores nemo voluptate architecto blanditiis rem, temporibus voluptatem soluta? Modi, laudantium! Alias unde ipsam suscipit architecto, amet qui iure, dolorem sapiente inventore eaque ducimus iste nihil commodi sed sunt quae impedit repellendus esse. Dicta, sapiente dolorem!</p> ");
            htmlText.Append("            <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Velit voluptatem minima voluptates, incidunt aperiam voluptatibus, ea quis quaerat dolore veritatis eaque illo fugiat a ut? Id provident quisquam quaerat excepturi.</p> ");
            htmlText.Append("        </div> ");
            htmlText.Append("    </section> ");
            htmlText.Append("</body> ");
            htmlText.Append("</html> ");
            await wvVisualizador.EnsureCoreWebView2Async();
            wvVisualizador.NavigateToString(htmlText.ToString());
        }
    }
}
