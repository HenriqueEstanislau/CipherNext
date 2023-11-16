namespace CipherNext.Esteganografia
{
    partial class frmArquivoZip
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelecionarDiretorioImg = new System.Windows.Forms.Button();
            this.txtDiretorioImagem = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelecionarDiretorioZip = new System.Windows.Forms.Button();
            this.txtDiretorioZip = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnDescricao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImgEsconder = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgEsconder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnDescricao);
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 117);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esteganografia com arquivos Zip";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(235)))));
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.Color.White;
            this.btnExecutar.Location = new System.Drawing.Point(56, 445);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(368, 47);
            this.btnExecutar.TabIndex = 17;
            this.btnExecutar.Text = "Esconder";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 526);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbImgEsconder);
            this.panel2.Controls.Add(this.btnSelecionarDiretorioImg);
            this.panel2.Controls.Add(this.txtDiretorioImagem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 520);
            this.panel2.TabIndex = 24;
            // 
            // btnSelecionarDiretorioImg
            // 
            this.btnSelecionarDiretorioImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarDiretorioImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(235)))));
            this.btnSelecionarDiretorioImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarDiretorioImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarDiretorioImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarDiretorioImg.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarDiretorioImg.Location = new System.Drawing.Point(68, 444);
            this.btnSelecionarDiretorioImg.Name = "btnSelecionarDiretorioImg";
            this.btnSelecionarDiretorioImg.Size = new System.Drawing.Size(368, 48);
            this.btnSelecionarDiretorioImg.TabIndex = 15;
            this.btnSelecionarDiretorioImg.Text = "Selecione a Imagem";
            this.btnSelecionarDiretorioImg.UseVisualStyleBackColor = false;
            this.btnSelecionarDiretorioImg.Click += new System.EventHandler(this.btnSelecionarDiretorioImg_Click);
            // 
            // txtDiretorioImagem
            // 
            this.txtDiretorioImagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiretorioImagem.Enabled = false;
            this.txtDiretorioImagem.Location = new System.Drawing.Point(68, 405);
            this.txtDiretorioImagem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtDiretorioImagem.Multiline = true;
            this.txtDiretorioImagem.Name = "txtDiretorioImagem";
            this.txtDiretorioImagem.Size = new System.Drawing.Size(368, 31);
            this.txtDiretorioImagem.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Controls.Add(this.btnExecutar);
            this.panel4.Controls.Add(this.btnSelecionarDiretorioZip);
            this.panel4.Controls.Add(this.txtDiretorioZip);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(507, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 520);
            this.panel4.TabIndex = 25;
            // 
            // btnSelecionarDiretorioZip
            // 
            this.btnSelecionarDiretorioZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarDiretorioZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(235)))));
            this.btnSelecionarDiretorioZip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarDiretorioZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarDiretorioZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarDiretorioZip.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarDiretorioZip.Location = new System.Drawing.Point(56, 384);
            this.btnSelecionarDiretorioZip.Name = "btnSelecionarDiretorioZip";
            this.btnSelecionarDiretorioZip.Size = new System.Drawing.Size(368, 48);
            this.btnSelecionarDiretorioZip.TabIndex = 23;
            this.btnSelecionarDiretorioZip.Text = "Selecione o Zip";
            this.btnSelecionarDiretorioZip.UseVisualStyleBackColor = false;
            this.btnSelecionarDiretorioZip.Click += new System.EventHandler(this.btnSelecionarDiretorioZip_Click);
            // 
            // txtDiretorioZip
            // 
            this.txtDiretorioZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiretorioZip.Enabled = false;
            this.txtDiretorioZip.Location = new System.Drawing.Point(56, 345);
            this.txtDiretorioZip.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtDiretorioZip.Multiline = true;
            this.txtDiretorioZip.Name = "txtDiretorioZip";
            this.txtDiretorioZip.Size = new System.Drawing.Size(368, 31);
            this.txtDiretorioZip.TabIndex = 22;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(53, 22);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 35);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "←";
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnDescricao
            // 
            this.btnDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.btnDescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescricao.FlatAppearance.BorderSize = 0;
            this.btnDescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescricao.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescricao.ForeColor = System.Drawing.Color.White;
            this.btnDescricao.Location = new System.Drawing.Point(832, 73);
            this.btnDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescricao.Name = "btnDescricao";
            this.btnDescricao.Size = new System.Drawing.Size(111, 28);
            this.btnDescricao.TabIndex = 8;
            this.btnDescricao.Text = "Descrição";
            this.btnDescricao.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Arquivo Zip selecionado:";
            // 
            // pbImgEsconder
            // 
            this.pbImgEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImgEsconder.BackColor = System.Drawing.Color.AliceBlue;
            this.pbImgEsconder.Location = new System.Drawing.Point(68, 50);
            this.pbImgEsconder.Name = "pbImgEsconder";
            this.pbImgEsconder.Size = new System.Drawing.Size(368, 347);
            this.pbImgEsconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgEsconder.TabIndex = 20;
            this.pbImgEsconder.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Imagem:";
            // 
            // frmArquivoZip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArquivoZip";
            this.Text = "frmArquivoZip";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgEsconder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelecionarDiretorioImg;
        private System.Windows.Forms.TextBox txtDiretorioImagem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelecionarDiretorioZip;
        private System.Windows.Forms.TextBox txtDiretorioZip;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImgEsconder;
        private System.Windows.Forms.Label label2;
    }
}