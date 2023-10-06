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

    public partial class frmBlocoNotas : Form
    {
        private string selectedPath = "";
        public frmBlocoNotas()
        {
            InitializeComponent();
        }
        
        private void btnSelecionarDiretorio_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //folderBrowserDialog.Description = "Selecione um diretório";
            //DialogResult result = folderBrowserDialog.ShowDialog();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione um diretório";
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.ValidateNames = false;

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Obtém o caminho da pasta selecionada
                    selectedPath = Path.GetDirectoryName(openFileDialog.FileName);

                    // Faça o que precisa fazer com o caminho do diretório selecionado
                    lblDiretorio.Text = "Diretório selecionado: " + selectedPath;
                }
                //if (result == DialogResult.OK)
                //{
                //    selectedPath = folderBrowserDialog.SelectedPath;
                //    lblDiretorio.Text = "Diretório selecionado: " + selectedPath;
                //}
            }
        }

        private string CreateTempScriptFile(string[] commandLines)
        {
            string tempScriptPath = Path.Combine(Path.GetTempPath(), "temp_script.bat");

            try
            {
                // Write command lines to the temporary script file
                File.WriteAllLines(tempScriptPath, commandLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o arquivo de script temporário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return tempScriptPath;
        }
        private void ExecuteCommand(string[] commandLines)
        {
            string tempScriptPath = CreateTempScriptFile(commandLines);

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
                    string output = process.StandardOutput.ReadToEnd();  // Read the output from the command
                    process.WaitForExit();

                    MessageBox.Show("Output:\n" + output, "Command Execution Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing the command: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Delete the temporary script file after execution
                    File.Delete(tempScriptPath);
                }
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"cd {selectedPath}");
            string[] commandLines = {
                $"cd {selectedPath}",
                "echo Olá, mundo! > exemplo.txt"
            };

            ExecuteCommand(commandLines);
        }
    }
}
