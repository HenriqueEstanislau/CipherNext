using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherNext
{
    public partial class frmCifraCesar : Form
    {
        public frmCifraCesar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            if (txtChave.Text == "")
            {
                MessageBox.Show("Insira uma chave!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(txtChave.Text) < 1 || int.Parse(txtChave.Text) > 26)
            {
                MessageBox.Show("A chave deve ser um valor entre 1 e 26!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string textoOriginal = rtxtTexto.Text;
            int chave = int.Parse(txtChave.Text) % 26; // Garante que a chave seja um número entre 0 e 25

            string textoCriptografado = "";

            foreach (char caractere in textoOriginal)
            {
                char novoCaractere = caractere;

                if (char.IsLetter(caractere))
                {
                    int baseAlfabeto = char.IsUpper(caractere) ? 'A' : 'a';
                    novoCaractere = (char)(baseAlfabeto + ((caractere - baseAlfabeto + chave) % 26));
                }

                textoCriptografado += novoCaractere;
            }

            rtxtCriptografado.Text = textoCriptografado;
        }

        private void txtChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            if (txtChave.Text == "")
            {
                MessageBox.Show("Insira uma chave!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(txtChave.Text) < 1 || int.Parse(txtChave.Text) > 26)
            {
                MessageBox.Show("A chave deve ser um valor entre 1 e 26!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string textoCriptografado = rtxtCriptografado.Text;
            int chave = int.Parse(txtChave.Text) % 26; // Garante que a chave seja um número entre 0 e 25
            string textoDecifrado = "";

            foreach (char caractere in textoCriptografado)
            {
                char novoCaractere = caractere;

                if (char.IsLetter(caractere))
                {
                    int baseAlfabeto = char.IsUpper(caractere) ? 'A' : 'a';
                    novoCaractere = (char)(baseAlfabeto + ((caractere - baseAlfabeto - chave + 26) % 26));
                }

                textoDecifrado += novoCaractere;
            }

            rtxtTexto.Text = textoDecifrado;
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            frmVisualizarDescricao visualizarDescricao = new frmVisualizarDescricao();
            visualizarDescricao.ShowDialog();
        }
    }
}
