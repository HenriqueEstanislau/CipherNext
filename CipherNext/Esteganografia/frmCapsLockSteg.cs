using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CipherNext.Esteganografia
{
    public partial class frmCapsLockSteg : Form
    {
        public frmCapsLockSteg()
        {
            InitializeComponent();
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            string frase = rtxtTexto.Text.ToLower();
            string primeirasLetras = IdentificarPrimeirasLetras(frase, txtMensagem.Text.ToString().ToLower());
            rtxtAnaliseLetras.Text = primeirasLetras;
            rtxtEscondido.Text = JuntarFraseComPrimeirasMaiusculas(frase, primeirasLetras);
            
            if (string.IsNullOrWhiteSpace(rtxtTexto.Text) || string.IsNullOrWhiteSpace(txtMensagem.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de entrada.");
                return;
            }
            
            lblLetrasEscondidas.Text = ExtrairLetrasMaiusculas(rtxtAnaliseLetras.Text);
            if (lblLetrasEscondidas.Text.ToUpper() == txtMensagem.Text.ToUpper())
            {
                lblStatus.Text = "SUCESSO: \nFoi possível fazer a conversão";
                MessageBox.Show("Mensagem convertida com sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlStatus.BackColor = Color.DarkGreen;
            }
            else
            {
                double porcentagemFalta = ((Double.Parse(lblLetrasEscondidas.Text.Length.ToString()) / Double.Parse(txtMensagem.Text.Length.ToString())) * 100);
                int letrasFalta = txtMensagem.Text.Length - lblLetrasEscondidas.Text.Length;
                lblStatus.Text = $"ALERTA: \nNão foi possível fazer a conversão completa! \n{porcentagemFalta:F2}% concluido; \nFaltam {letrasFalta} letras.";
                MessageBox.Show("Não foi possivel realizar a conversão da mensagem completa!\nConfira a aba 'Diagnóstico' para mais detalhes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlStatus.BackColor = Color.DarkOrange;
            }
            lblTotalLetra.Text = rtxtAnaliseLetras.Text.Length.ToString();
        }

        private string ExtrairLetrasMaiusculas(string input)
        {
            string maiusculas = "";
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    maiusculas += c;
                }
            }
            return maiusculas;
        }
        private string IdentificarPrimeirasLetras(string frase, string mensagem)
        {
            int tamanhoMaximoContador = mensagem.Length;
            char[] letrasMensagem = mensagem.ToCharArray();
            string[] palavras = frase.Split(' ');
            string primeirasLetras = "";
            int contador = 0;
            bool verificar = true;
            try
            {
                foreach (string palavra in palavras)
                {
                    if (!string.IsNullOrEmpty(palavra))
                    {
                        char primeiraLetra = palavra[0];
                        if (primeiraLetra == letrasMensagem[contador] && verificar)
                        {
                            primeirasLetras += primeiraLetra.ToString().ToUpper();
                            if (contador < tamanhoMaximoContador - 1)
                            {
                                contador++;
                            }
                            else
                            {
                                verificar = false;
                            }
                        }
                        else
                        {
                            primeirasLetras += primeiraLetra.ToString().ToLower();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex}");
            }


            return primeirasLetras;
        }

        private string JuntarFraseComPrimeirasMaiusculas(string frase, string primeirasLetras)
        {
            string[] palavras = frase.Split(' ');
            string fraseResultante = "";

            try
            {
                for (int i = 0; i < palavras.Length; i++)
                {
                    string palavra = palavras[i];

                    if (!string.IsNullOrEmpty(palavra))
                    {
                        if (i > 0)
                        {
                            fraseResultante += " ";
                        }

                        fraseResultante += primeirasLetras[i] + palavra.Substring(1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex}");
            }

            return fraseResultante;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            lblTotalTexto.Text = rtxtTexto.Text.Length.ToString();
        }

        private void rtxtAnaliseLetras_TextChanged(object sender, EventArgs e)
        {
            lblTotalLetra.Text = rtxtAnaliseLetras.Text.Length.ToString();
        }
    }
}
