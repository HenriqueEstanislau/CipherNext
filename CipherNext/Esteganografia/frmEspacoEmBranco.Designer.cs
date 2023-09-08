namespace CipherNext.Esteganografia
{
    partial class frmEspacoEmBranco
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.rtxtTextoOculto = new System.Windows.Forms.RichTextBox();
            this.btnEsconder = new System.Windows.Forms.Button();
            this.btnDecifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(113, 221);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(285, 238);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // rtxtTextoOculto
            // 
            this.rtxtTextoOculto.Location = new System.Drawing.Point(534, 221);
            this.rtxtTextoOculto.Name = "rtxtTextoOculto";
            this.rtxtTextoOculto.Size = new System.Drawing.Size(285, 238);
            this.rtxtTextoOculto.TabIndex = 1;
            this.rtxtTextoOculto.Text = "";
            // 
            // btnEsconder
            // 
            this.btnEsconder.Location = new System.Drawing.Point(113, 481);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.Size = new System.Drawing.Size(285, 34);
            this.btnEsconder.TabIndex = 2;
            this.btnEsconder.Text = "Esconder";
            this.btnEsconder.UseVisualStyleBackColor = true;
            this.btnEsconder.Click += new System.EventHandler(this.btnEsconder_Click);
            // 
            // btnDecifrar
            // 
            this.btnDecifrar.Location = new System.Drawing.Point(534, 481);
            this.btnDecifrar.Name = "btnDecifrar";
            this.btnDecifrar.Size = new System.Drawing.Size(285, 34);
            this.btnDecifrar.TabIndex = 3;
            this.btnDecifrar.Text = "Decifrar";
            this.btnDecifrar.UseVisualStyleBackColor = true;
            this.btnDecifrar.Click += new System.EventHandler(this.btnDecifrar_Click);
            // 
            // frmEspacoEmBranco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.btnDecifrar);
            this.Controls.Add(this.btnEsconder);
            this.Controls.Add(this.rtxtTextoOculto);
            this.Controls.Add(this.rtxtTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1008, 643);
            this.Name = "frmEspacoEmBranco";
            this.Text = "Espaco em branco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.RichTextBox rtxtTextoOculto;
        private System.Windows.Forms.Button btnEsconder;
        private System.Windows.Forms.Button btnDecifrar;
    }
}