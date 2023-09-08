using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CipherNext
{
    public partial class frmCarregar : Form
    {
        private System.Windows.Forms.Timer timer;
        public frmCarregar()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 3000 milissegundos = 3 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Pára o timer
            timer.Tick -= Timer_Tick; // Remove o manipulador de evento

            // Abre o formulário principal e fecha o formulário de apresentação
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.Show();
            this.Hide();
        }

        private void frmCarregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPrincipal>().Any())
            {
                // Se o formulário principal ainda está aberto, fecha-o
                Application.OpenForms.OfType<frmPrincipal>().First().Close();
            }
            // Encerra o aplicativo
            Application.Exit();
        }
    }
}
