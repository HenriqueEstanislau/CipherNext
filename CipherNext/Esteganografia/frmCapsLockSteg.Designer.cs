namespace CipherNext.Esteganografia
{
    partial class frmCapsLockSteg
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.pnlFundoLayoutTable = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLetrasEscondidas = new System.Windows.Forms.Label();
            this.lblTotalLetra = new System.Windows.Forms.Label();
            this.rtxtAnaliseLetras = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEsconder = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rtxtEscondido = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.pnlFundoLayoutTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtMensagem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 187);
            this.panel3.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(822, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Descrição";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mensagem:";
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
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esteganografia com CapsLock";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(71, 140);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(382, 26);
            this.txtMensagem.TabIndex = 1;
            // 
            // pnlFundoLayoutTable
            // 
            this.pnlFundoLayoutTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundoLayoutTable.BackColor = System.Drawing.Color.White;
            this.pnlFundoLayoutTable.Controls.Add(this.tableLayoutPanel1);
            this.pnlFundoLayoutTable.Location = new System.Drawing.Point(47, 193);
            this.pnlFundoLayoutTable.Name = "pnlFundoLayoutTable";
            this.pnlFundoLayoutTable.Size = new System.Drawing.Size(893, 438);
            this.pnlFundoLayoutTable.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 438);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(595, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(295, 432);
            this.panel7.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Diagnóstico:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lblStatus);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lblLetrasEscondidas);
            this.panel6.Controls.Add(this.lblTotalLetra);
            this.panel6.Controls.Add(this.rtxtAnaliseLetras);
            this.panel6.Location = new System.Drawing.Point(3, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 361);
            this.panel6.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Letras Escondidas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AllowDrop = true;
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(11, 310);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(267, 48);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Análise das letras:";
            // 
            // lblLetrasEscondidas
            // 
            this.lblLetrasEscondidas.AllowDrop = true;
            this.lblLetrasEscondidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetrasEscondidas.Location = new System.Drawing.Point(17, 245);
            this.lblLetrasEscondidas.Name = "lblLetrasEscondidas";
            this.lblLetrasEscondidas.Size = new System.Drawing.Size(267, 38);
            this.lblLetrasEscondidas.TabIndex = 11;
            this.lblLetrasEscondidas.Text = "null";
            // 
            // lblTotalLetra
            // 
            this.lblTotalLetra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLetra.Location = new System.Drawing.Point(55, 12);
            this.lblTotalLetra.Name = "lblTotalLetra";
            this.lblTotalLetra.Size = new System.Drawing.Size(226, 13);
            this.lblTotalLetra.TabIndex = 12;
            this.lblTotalLetra.Text = "0";
            this.lblTotalLetra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtxtAnaliseLetras
            // 
            this.rtxtAnaliseLetras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtAnaliseLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtAnaliseLetras.Location = new System.Drawing.Point(14, 27);
            this.rtxtAnaliseLetras.Name = "rtxtAnaliseLetras";
            this.rtxtAnaliseLetras.Size = new System.Drawing.Size(267, 199);
            this.rtxtAnaliseLetras.TabIndex = 3;
            this.rtxtAnaliseLetras.Text = "";
            this.rtxtAnaliseLetras.TextChanged += new System.EventHandler(this.rtxtAnaliseLetras_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalTexto);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnEsconder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 432);
            this.panel2.TabIndex = 24;
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTexto.Location = new System.Drawing.Point(125, 24);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(153, 13);
            this.lblTotalTexto.TabIndex = 13;
            this.lblTotalTexto.Text = "0";
            this.lblTotalTexto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rtxtTexto);
            this.panel4.Location = new System.Drawing.Point(23, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 307);
            this.panel4.TabIndex = 6;
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtTexto.BackColor = System.Drawing.Color.Snow;
            this.rtxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTexto.Location = new System.Drawing.Point(15, 12);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(223, 282);
            this.rtxtTexto.TabIndex = 1;
            this.rtxtTexto.Text = "";
            this.rtxtTexto.TextChanged += new System.EventHandler(this.rtxtTexto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Texto:";
            // 
            // btnEsconder
            // 
            this.btnEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsconder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(235)))));
            this.btnEsconder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsconder.FlatAppearance.BorderSize = 0;
            this.btnEsconder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsconder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsconder.ForeColor = System.Drawing.Color.White;
            this.btnEsconder.Location = new System.Drawing.Point(23, 356);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.Size = new System.Drawing.Size(255, 48);
            this.btnEsconder.TabIndex = 4;
            this.btnEsconder.Text = "Esconder";
            this.btnEsconder.UseVisualStyleBackColor = false;
            this.btnEsconder.Click += new System.EventHandler(this.btnEsconder_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(299, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 432);
            this.panel5.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Texto Escondido:";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Snow;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.rtxtEscondido);
            this.panel8.Location = new System.Drawing.Point(7, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 361);
            this.panel8.TabIndex = 9;
            // 
            // rtxtEscondido
            // 
            this.rtxtEscondido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEscondido.BackColor = System.Drawing.Color.Snow;
            this.rtxtEscondido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtEscondido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtEscondido.Location = new System.Drawing.Point(14, 16);
            this.rtxtEscondido.Name = "rtxtEscondido";
            this.rtxtEscondido.Size = new System.Drawing.Size(248, 328);
            this.rtxtEscondido.TabIndex = 1;
            this.rtxtEscondido.Text = "";
            // 
            // frmCapsLockSteg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.pnlFundoLayoutTable);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapsLockSteg";
            this.Text = "frmCapsLockSteg";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFundoLayoutTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlFundoLayoutTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLetrasEscondidas;
        private System.Windows.Forms.Label lblTotalLetra;
        private System.Windows.Forms.RichTextBox rtxtAnaliseLetras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEsconder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RichTextBox rtxtEscondido;
    }
}