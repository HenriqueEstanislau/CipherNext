using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherNext.Esteganografia
{
    public partial class frmArquivoZip : Form
    {
        private string selectedPathImg = "", pathImage = "", extensionImage = "", selectedPathZip = "", pathZip = "", extensionZip = "";
        public frmArquivoZip()
        {
            InitializeComponent();
        }
        private string CriarArquivoScriptTemporario(string[] textUser)
        {
            string tempScriptPath = Path.Combine(Path.GetTempPath(), "CipherNext-TempScript.bat");

            try
            {
                File.WriteAllLines(tempScriptPath, textUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o arquivo de texto temporário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return tempScriptPath;
        }

        private void btnSelecionarDiretorioImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione uma imagem";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.ValidateNames = true;

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathImage = Path.GetDirectoryName(openFileDialog.FileName);
                    extensionImage = Path.GetExtension(openFileDialog.FileName);
                    selectedPathImg = Path.GetFullPath(openFileDialog.FileName);
                    txtDiretorioImagem.Text = selectedPathImg;
                }
            }
        }

        private void btnSelecionarDiretorioZip_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione um arquivo Zip";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.ValidateNames = true;

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathZip = Path.GetDirectoryName(openFileDialog.FileName);
                    extensionZip = Path.GetExtension(openFileDialog.FileName);
                    MessageBox.Show("EXTENSAO ZIP PARA VERIFICAR: " + extensionZip);
                    selectedPathZip = Path.GetFullPath(openFileDialog.FileName);
                    txtDiretorioZip.Text = selectedPathZip;
                }
            }
        }
        private void ExecutarComando(string[] commandLines)
        {
            string tempScriptPath = CriarArquivoScriptTemporario(commandLines);

            if (tempScriptPath != null)
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = tempScriptPath;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    MessageBox.Show("Output:\n" + output, "Command Execution Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro occoreu enquanto tentava executar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (File.Exists(tempScriptPath))
                        File.Delete(tempScriptPath);
                }
            }
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {

            //string[] userText = { "\n\n\n" + rtxtTexto.Text };
            //string tempScriptPath = CriarArquivoTextoTemporario(userText);
            //MessageBox.Show("MESAGEM: " + tempScriptPath);
            string[] commandLines = { $"copy /b {selectedPathImg} + {selectedPathZip} {pathImage}\\documento{extensionImage}" };

            ExecutarComando(commandLines);
        }
    }
}
