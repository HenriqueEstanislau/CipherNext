namespace CipherNext
{
    partial class frmVisualizarDescricao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wvVisualizador = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wvVisualizador)).BeginInit();
            this.SuspendLayout();
            // 
            // wvVisualizador
            // 
            this.wvVisualizador.AllowExternalDrop = true;
            this.wvVisualizador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wvVisualizador.CreationProperties = null;
            this.wvVisualizador.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvVisualizador.Location = new System.Drawing.Point(12, 64);
            this.wvVisualizador.Name = "wvVisualizador";
            this.wvVisualizador.Size = new System.Drawing.Size(893, 648);
            this.wvVisualizador.TabIndex = 0;
            this.wvVisualizador.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Cifra";
            // 
            // frmVisualizarDescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wvVisualizador);
            this.MinimumSize = new System.Drawing.Size(933, 763);
            this.Name = "frmVisualizarDescricao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CipherNext | Descrição da Cifra";
            this.Load += new System.EventHandler(this.frmVisualizarDescricao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvVisualizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvVisualizador;
        private System.Windows.Forms.Label label1;
    }
}