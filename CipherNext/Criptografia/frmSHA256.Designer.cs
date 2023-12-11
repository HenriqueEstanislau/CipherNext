namespace CipherNext.Criptografia
{
    partial class frmSHA256
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(1008, 187);
            this.panel3.TabIndex = 14;
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
            this.btnDescricao.Location = new System.Drawing.Point(822, 120);
            this.btnDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescricao.Name = "btnDescricao";
            this.btnDescricao.Size = new System.Drawing.Size(111, 28);
            this.btnDescricao.TabIndex = 12;
            this.btnDescricao.Text = "Descrição";
            this.btnDescricao.UseVisualStyleBackColor = false;
            this.btnDescricao.Click += new System.EventHandler(this.btnDescricao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(71, 21);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 35);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "←";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hash SHA 256";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtHash);
            this.panel1.Controls.Add(this.rtxtTexto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 456);
            this.panel1.TabIndex = 15;
            // 
            // txtHash
            // 
            this.txtHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash.Location = new System.Drawing.Point(284, 360);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(475, 35);
            this.txtHash.TabIndex = 2;
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtTexto.Location = new System.Drawing.Point(284, 33);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(475, 306);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            this.rtxtTexto.TextChanged += new System.EventHandler(this.rtxtTexto_TextChanged);
            // 
            // frmSHA256
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSHA256";
            this.Text = "frmSHA256";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDescricao;
    }
}