using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherNext.Esteganografia
{
    public partial class frmEspacoEmBranco : Form
    {
        Dictionary<char, string> whiteSpaceCodeDict = new Dictionary<char, string>()
        {
            {'A', " \t"},
            {'B', "\t   "}
        };
        public frmEspacoEmBranco()
        {
            InitializeComponent();
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            string inputText = rtxtTexto.Text.ToUpper();
            string whiteSpaceCode = TranslateToWhiteSpace(inputText);
            rtxtTextoOculto.Text = whiteSpaceCode;
        }
        private string TranslateToWhiteSpace(string inputText)
        {
            string whiteSpaceCode = "";
            foreach (char c in inputText)
            {
                if (whiteSpaceCodeDict.ContainsKey(c))
                {
                    whiteSpaceCode += whiteSpaceCodeDict[c] + "\n";
                }
                else if (c == '\t')
                {
                    whiteSpaceCode += "~\n"; // Use "~" para representar "\t"
                }
                else
                {
                    whiteSpaceCode += " ";
                }
            }
            return whiteSpaceCode;
        }

        private string TranslateToText(string tabbedText)
        {
            StringBuilder text = new StringBuilder();
            string[] lines = tabbedText.Split('\n');

            foreach (string line in lines)
            {
                string[] tokens = line.Split('\t');

                foreach (string token in tokens)
                {
                    if (string.IsNullOrEmpty(token))
                    {
                        text.Append(' ');
                    }
                    else if (token == "~")
                    {
                        text.Append('\t');
                    }
                    else
                    {
                        foreach (var pair in whiteSpaceCodeDict)
                        {
                            if (token == pair.Value)
                            {
                                text.Append(pair.Key);
                                break;
                            }
                        }
                    }
                }

                text.AppendLine(); 
            }

            return text.ToString().TrimEnd(); 
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            string whiteSpaceText = rtxtTextoOculto.Text;
            string text = TranslateToText(whiteSpaceText);
            rtxtTexto.Text = text;
        }
    }
}
