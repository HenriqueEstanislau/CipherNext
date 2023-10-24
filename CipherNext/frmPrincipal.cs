using CipherNext.Criptografia;
using CipherNext.Esteganografia;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnlCriptografiaSubMenu.Visible = false;
            pnlEsteganografiaSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if(pnlCriptografiaSubMenu.Visible == true)
            {
                pnlCriptografiaSubMenu.Visible = false;
            }
            if (pnlEsteganografiaSubMenu.Visible == true)
            {
                pnlEsteganografiaSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCriptografia_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCriptografiaSubMenu);
        }

        private void btnCifraCesar_Click(object sender, EventArgs e)
        {
            openContainer(new frmCifraCesar());
            hideSubMenu();
        }

        private void btnEsteganografia_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlEsteganografiaSubMenu);
        }

        private Form activeForm = null;
        private void openContainer(Form container)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = container;
            container.TopLevel = false;
            container.FormBorderStyle = FormBorderStyle.None;
            container.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(container);
            pnlContainer.Tag = container;
            container.BringToFront();
            container.Show();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            openContainer(new frmMD5());
            hideSubMenu();
        }

        private void btnSHA1_Click(object sender, EventArgs e)
        {
            openContainer(new frmSHA1());
            hideSubMenu();
        }

        private void btnSHA256_Click(object sender, EventArgs e)
        {
            openContainer(new frmSHA256());
            hideSubMenu();
        }

        private void btnSHA384_Click(object sender, EventArgs e)
        {
            openContainer(new frmSHA384());
            hideSubMenu();
        }

        private void btnSHA512_Click(object sender, EventArgs e)
        {
            openContainer(new frmSHA512());
            hideSubMenu();
        }
        private void btnEspacoEmBranco_Click(object sender, EventArgs e)
        {
            openContainer(new frmEspacoEmBranco());
            hideSubMenu();
        }

        private void btnAtbash_Click(object sender, EventArgs e)
        {
            openContainer(new frmAtbash());
            hideSubMenu();
        }

        private void btnA1Z26_Click(object sender, EventArgs e)
        {
            openContainer(new frmA1Z26());
            hideSubMenu();
        }

        private void btnCifraVigenere_Click(object sender, EventArgs e)
        {
            openContainer(new frmCifraVigenere());
            hideSubMenu();
        }

        private void btnBlocoNotas_Click(object sender, EventArgs e)
        {
            openContainer(new frmBlocoNotas());
            hideSubMenu();
        }

        private void btnCodigoMorse_Click(object sender, EventArgs e)
        {
            openContainer(new frmCodigoMorse());
            hideSubMenu();
        }
    }
}
