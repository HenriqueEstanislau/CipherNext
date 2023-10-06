namespace CipherNext.Esteganografia
{
    partial class frmBlocoNotas
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDescricao = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionarDiretorio = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDescricao);
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 187);
            this.panel3.TabIndex = 14;
            // 
            // btnDescricao
            // 
            this.btnDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDescricao.Location = new System.Drawing.Point(822, 120);
            this.btnDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescricao.Name = "btnDescricao";
            this.btnDescricao.Size = new System.Drawing.Size(111, 28);
            this.btnDescricao.TabIndex = 5;
            this.btnDescricao.Text = "Descrição";
            this.btnDescricao.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Location = new System.Drawing.Point(71, 21);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 28);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "←";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esteganografia com Bloco de Notas";
            // 
            // btnSelecionarDiretorio
            // 
            this.btnSelecionarDiretorio.Location = new System.Drawing.Point(113, 193);
            this.btnSelecionarDiretorio.Name = "btnSelecionarDiretorio";
            this.btnSelecionarDiretorio.Size = new System.Drawing.Size(155, 37);
            this.btnSelecionarDiretorio.TabIndex = 15;
            this.btnSelecionarDiretorio.Text = "Selecione o Diretorio";
            this.btnSelecionarDiretorio.UseVisualStyleBackColor = true;
            this.btnSelecionarDiretorio.Click += new System.EventHandler(this.btnSelecionarDiretorio_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(484, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 156);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(113, 249);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(155, 37);
            this.btnExecutar.TabIndex = 17;
            this.btnExecutar.Text = "Teste Terminal";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Location = new System.Drawing.Point(120, 233);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(0, 13);
            this.lblDiretorio.TabIndex = 18;
            // 
            // openFileDialog
            // 
            this.openFileDialog.CheckFileExists = false;
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.ValidateNames = false;
            // 
            // frmBlocoNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.lblDiretorio);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSelecionarDiretorio);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBlocoNotas";
            this.Text = "frmBlocoNotas";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDescricao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionarDiretorio;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}