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
    public partial class frmCodigoMorse : Form
    {
        public frmCodigoMorse()
        {
            InitializeComponent();
        }

        private string TextoParaMorse(string texto)
        {
            Dictionary<char, string> morseCode = new Dictionary<char, string>
            {
                { 'A', ".- "    }, { 'B', "-... "  }, { 'C', "-.-. "  }, 
                { 'D', "-.. "   }, { 'E', ". "     }, { 'F', "..-. "  }, 
                { 'G', "--. "   }, { 'H', ".... "  }, { 'I', ".. "    }, 
                { 'J', ".--- "  }, { 'K', "-.- "   }, { 'L', ".-.. "  }, 
                { 'M', "-- "    }, { 'N', "-. "    }, { 'O', "--- "   }, 
                { 'P', ".--. "  }, { 'Q', "--.- "  }, { 'R', ".-. "   }, 
                { 'S', "... "   }, { 'T', "- "     }, { 'U', "..- "   }, 
                { 'V', "...- "  }, { 'W', ".-- "   }, { 'X', "-..- "  }, 
                { 'Y', "-.-- "  }, { 'Z', "--.. "  }, { '0', "----- " }, 
                { '1', ".---- " }, { '2', "..--- " }, { '3', "...-- " }, 
                { '4', "....- " }, { '5', "..... " }, { '6', "-.... " }, 
                { '7', "--... " }, { '8', "---.. " }, { '9', "----. " }
            };

            StringBuilder morseText = new StringBuilder();

            foreach (char c in texto)
            {
                if (morseCode.ContainsKey(c))
                {
                    morseText.Append(morseCode[c]);
                }
                else if (c == ' ')
                {
                    morseText.Append(" ");
                }
            }

            return morseText.ToString();
        }

        private string MorseParaTexto(string morseText)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>
            {
                { ".-",   'A'  }, { "-...",  'B' }, { "-.-.",  'C' }, 
                { "-..",  'D'  }, { ".",     'E' }, { "..-.",  'F' }, 
                { "--.",  'G'  }, { "....",  'H' }, { "..",    'I' }, 
                { ".---", 'J'  }, { "-.-",   'K' }, { ".-..",  'L' }, 
                { "--",   'M'  }, { "-.",    'N' }, { "---",   'O' },
                { ".--.", 'P'  }, { "--.-",  'Q' }, { ".-.",   'R' }, 
                { "...",  'S'  }, { "-",     'T' }, { "..-",   'U' }, 
                { "...-", 'V'  }, { ".--",   'W' }, { "-..-",  'X' }, 
                { "-.--", 'Y'  }, { "--..",  'Z' }, { "-----", '0' },
                { ".----", '1' }, { "..---", '2' }, { "...--", '3' }, 
                { "....-", '4' }, { ".....", '5' }, { "-....", '6' }, 
                { "--...", '7' }, { "---..", '8' }, { "----.", '9' }
            };

            StringBuilder texto = new StringBuilder();
            string[] palavras = morseText.Split(' ');

            foreach (string palavra in palavras)
            {
                if (morseCode.ContainsKey(palavra))
                {
                    texto.Append(morseCode[palavra]);
                }
                else
                {
                    texto.Append(' ');
                }
            }

            return texto.ToString();
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            string morseText = rtxtCriptografado.Text;
            string textoDecifrado = MorseParaTexto(morseText);
            rtxtTexto.Text = textoDecifrado;
        }
        private void btnCifrar_Click(object sender, EventArgs e)
        {
            string texto = rtxtTexto.Text.ToUpper(); 
            string textoCifrado = TextoParaMorse(texto);
            rtxtCriptografado.Text = textoCifrado;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            frmVisualizarDescricao visualizarDescricao = new frmVisualizarDescricao(Properties.Resources.Codigo_Morse);
            visualizarDescricao.ShowDialog();
        }
    }
}
