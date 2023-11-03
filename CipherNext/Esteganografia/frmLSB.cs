using System;
using System.Collections;
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
    public partial class frmLSB : Form
    {
        public frmLSB()
        {
            InitializeComponent();
        }

        byte[] data;
        Bitmap mainImage;
        Bitmap EncryptedImage;
        OpenFileDialog ofd = new OpenFileDialog();
        string[] type = new string[3];



        private byte[] getStringBits(string data)
        {
            byte[] text = System.Text.ASCIIEncoding.ASCII.GetBytes(data);
            BitArray bits = new BitArray(text);
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }
        private byte getByte(byte[] bits)
        {
            String bitString = "";
            for (int i = 0; i < 8; i++)
                bitString += bits[i];
            byte newpix = Convert.ToByte(bitString, 2);
            int dePix = (int)newpix;
            return (byte)dePix;
        }
        private byte[] getBits(byte simplepixel)
        {
            int pixel = 0;
            pixel = (int)simplepixel;
            BitArray bits = new BitArray(new byte[] { (byte)pixel });
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }
        public Color embed(Color pixel, byte[] bits)
        {

            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);

            /*LSB substition of RGB values is done as following:
            Red: Last 3 bits, Green: Last 3 bits, Blue: Last 2 bits
            This process lets us embed 1 byte in each pixel*/

            RedBits[5] = bits[0];
            GreenBits[5] = bits[1];
            RedBits[6] = bits[2];
            RedBits[7] = bits[3];
            GreenBits[6] = bits[4];
            GreenBits[7] = bits[5];
            BlueBits[6] = bits[6];
            BlueBits[7] = bits[7];

            byte newRed = getByte(RedBits);
            byte newGreen = getByte(GreenBits);
            byte newBlue = getByte(BlueBits);

            return Color.FromArgb(newRed, newGreen, newBlue);

        }
        public byte extract(Color pixel)
        {
            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);
            byte[] BitsToDecrypt = new byte[8];

            BitsToDecrypt[0] = RedBits[5];
            BitsToDecrypt[1] = GreenBits[5];
            BitsToDecrypt[2] = RedBits[6];
            BitsToDecrypt[3] = RedBits[7];
            BitsToDecrypt[4] = GreenBits[6];
            BitsToDecrypt[5] = GreenBits[7];
            BitsToDecrypt[6] = BlueBits[6];
            BitsToDecrypt[7] = BlueBits[7];

            return getByte(BitsToDecrypt);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarImagemEsconder_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|PNG (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImgEsconder.ImageLocation = ofd.FileName;
                txtCaminhoImgEsconder.Text = ofd.FileName;
                Bitmap img = new Bitmap(ofd.FileName);
                //labelImageSize.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);

                if (string.IsNullOrEmpty(rtxtTexto.Text) == false)
                {
                    btnEsconder.Enabled = true;
                }
            }
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            string textbox = rtxtTexto.Text;
            char[] textarray = rtxtTexto.Text.ToArray();

            mainImage = new Bitmap(pbImgEsconder.Image);
            //labelProgress.Text = "";
            //labelText.Text = "Text length: " + Convert.ToString(textbox.Length) + " characters";

            /* Encoding process */

            //Embed type of data into last 3 pixels.
            // "tt1" is the code to define hidden data is a text message. (type:text:1)
            string[] type = new string[] { "t", "t", "1" };

            for (int j = 0; j < 3; j++)
            {
                Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                pixel = embed(pixel, getStringBits(type[j]));
                mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
            }


            // Embed length of message into 13 pixels in reverse [3:15]

            string a = Convert.ToString((rtxtTexto.Text).Length);
            a = a.PadLeft(13, '0'); //Zero-padding
            char[] b = a.ToArray();

            for (int j = 3; j < 16; j++)
            {
                string aString = Convert.ToString(b[j - 3]);
                Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                pixel = embed(pixel, getStringBits(aString));
                mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
            }


            int k = 0;
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = textbox.Length - 1;
            //
            //labelProgress.Text = "Processing...";

            for (int i = 0; i < mainImage.Height; i++)
            {
                for (int j = 0; j < mainImage.Width; j++)
                {
                    if (k < textbox.Length)
                    {
                        string msg = Convert.ToString(textarray[i + j]);
                        Color pixel = mainImage.GetPixel(j, i);
                        pixel = embed(pixel, getStringBits(msg));
                        mainImage.SetPixel(j, i, pixel);
                        //progressBar1.Value = k;
                        k++;
                    }

                }
            }

            //labelProgress.Text = "Completed!";
            MessageBox.Show("A imagem foi modificada com sucesso");
            btnDownload.Enabled = true;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveEncoded = new SaveFileDialog();
            saveEncoded.Filter = "Bitmap files (*.bmp)|*.bmp";

            string pathEncoded = "";

            if (saveEncoded.ShowDialog() == DialogResult.OK)
            {
                pathEncoded = saveEncoded.FileName;
            }

            try
            {
                mainImage.Save(pathEncoded);

                MessageBox.Show("A imagem foi salva com sucesso!\n Caminho: " + pathEncoded);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error while writing file!" + ioe.Message);
            }
        }

        //
        // Extrair mensagem da imagem
        //
        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|PNG (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImgExtrair.ImageLocation = ofd.FileName;
                txtCaminhoImgExtrair.Text = ofd.FileName;


                EncryptedImage = new Bitmap(ofd.FileName);
                lblAuxiliar.Show();
                lblAuxiliar.Text = "";

                for (int j = 0; j < 3; j++)
                {
                    Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                    byte detype = extract(pixelToDecode);
                    type[j] = Encoding.ASCII.GetString(BitConverter.GetBytes(detype));
                    lblAuxiliar.Text += type[j];
                }
                char[] typex = (lblAuxiliar.Text).ToCharArray();


                if (typex[0] == 't' && typex[1] == 't' && typex[2] == '1')
                {
                    //buttonDeText.Enabled = true;
                    Bitmap img = new Bitmap(ofd.FileName);
                    //labelImageSize2.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);
                }
                else if (typex[0] == 't' && typex[1] == 'b' && typex[2] == '1')
                {

                    if (string.IsNullOrEmpty(txtCaminhoImgExtrair.Text) == false)
                    {
                        btnExtrair.Enabled = true;
                    }
                    else
                    {
                        btnExtrair.Enabled = false;
                    }

                    Bitmap img = new Bitmap(ofd.FileName);
                    //labelImageSize2.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);
                }
                else
                {
                    MessageBox.Show("No stego data has been found in selected picture!\nChoose another stego image to continue!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lblAuxiliar.Hide();
            }
        }

        private void btnExtrair_Click(object sender, EventArgs e)
        {
            EncryptedImage = new Bitmap(pbImgExtrair.Image);
            rtxtTextoEscondido.Text = "";


            int k = 0;
            string tlength = "";


            for (int j = 3; j < 16; j++)
            {
                Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                byte delength = extract(pixelToDecode);
                tlength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(delength)));
            }

            int length = Convert.ToInt32(tlength);
            //label_Text2.Text = "Text length: " + Convert.ToString(length) + " characters";


            k = 0;
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = length - 1;

            for (int i = 0; i < EncryptedImage.Height; i++)
            {
                for (int j = 0; j < EncryptedImage.Width; j++)
                {
                    if (k < length)
                    {
                        Color pixelToDecode = EncryptedImage.GetPixel(j, i);
                        byte demsg = extract(pixelToDecode);
                        rtxtTextoEscondido.Text += Encoding.ASCII.GetString(BitConverter.GetBytes(demsg));
                        //progressBar2.Value = k;
                        k++;
                    }
                }
            }
        }
    }
}
