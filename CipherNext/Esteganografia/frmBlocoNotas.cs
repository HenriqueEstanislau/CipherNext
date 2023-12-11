using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherNext.Esteganografia
{

    public partial class frmBlocoNotas : Form
    {
        private string selectedPath = "", pathImage = "", extensionImage = "";
        public frmBlocoNotas()
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

        private string CriarArquivoTextoTemporario(string[] commandLines)
        {
            string tempTexttPath = Path.Combine(Path.GetTempPath(), "CipherNext-TempText.txt");

            try
            {
                File.WriteAllLines(tempTexttPath, commandLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o arquivo de script temporário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return tempTexttPath;
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

                    MessageBox.Show("Arquivo gerado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            string[] userText = { "\n\n\n" + rtxtTexto.Text };
            string tempScriptPath = CriarArquivoTextoTemporario(userText); 
            string[] commandLines = { $"copy /b {selectedPath} + {tempScriptPath} {pathImage}\\documento{extensionImage}" };

            ExecutarComando(commandLines);
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione um diretório";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.ValidateNames = true;

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathImage = Path.GetDirectoryName(openFileDialog.FileName);
                    extensionImage = Path.GetExtension(openFileDialog.FileName);
                    selectedPath = Path.GetFullPath(openFileDialog.FileName);
                    txtDiretorioImagem.Text = selectedPath;
                    pbImgEsconder.ImageLocation = openFileDialog.FileName;
                }
            }
        }
    }
}
