namespace CipherNext
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlEsteganografiaSubMenu = new System.Windows.Forms.Panel();
            this.btnLSB = new System.Windows.Forms.Button();
            this.btnEspacoEmBranco = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBlocoNotas = new System.Windows.Forms.Button();
            this.btnEsteganografia = new System.Windows.Forms.Button();
            this.pnlCriptografiaSubMenu = new System.Windows.Forms.Panel();
            this.btnSHA512 = new System.Windows.Forms.Button();
            this.btnSHA384 = new System.Windows.Forms.Button();
            this.btnSHA256 = new System.Windows.Forms.Button();
            this.btnSHA1 = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnCifraVigenere = new System.Windows.Forms.Button();
            this.btnA1Z26 = new System.Windows.Forms.Button();
            this.btnAtbash = new System.Windows.Forms.Button();
            this.btnCifraCesar = new System.Windows.Forms.Button();
            this.btnCriptografia = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCodigoMorse = new System.Windows.Forms.Button();
            this.btnCodigoBinario = new System.Windows.Forms.Button();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlEsteganografiaSubMenu.SuspendLayout();
            this.pnlCriptografiaSubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlMenuLateral.Controls.Add(this.pnlEsteganografiaSubMenu);
            this.pnlMenuLateral.Controls.Add(this.btnEsteganografia);
            this.pnlMenuLateral.Controls.Add(this.pnlCriptografiaSubMenu);
            this.pnlMenuLateral.Controls.Add(this.btnCriptografia);
            this.pnlMenuLateral.Controls.Add(this.btnPrincipal);
            this.pnlMenuLateral.Controls.Add(this.pnlLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(256, 643);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // pnlEsteganografiaSubMenu
            // 
            this.pnlEsteganografiaSubMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlEsteganografiaSubMenu.Controls.Add(this.btnLSB);
            this.pnlEsteganografiaSubMenu.Controls.Add(this.btnEspacoEmBranco);
            this.pnlEsteganografiaSubMenu.Controls.Add(this.button4);
            this.pnlEsteganografiaSubMenu.Controls.Add(this.btnBlocoNotas);
            this.pnlEsteganografiaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEsteganografiaSubMenu.Location = new System.Drawing.Point(0, 783);
            this.pnlEsteganografiaSubMenu.Name = "pnlEsteganografiaSubMenu";
            this.pnlEsteganografiaSubMenu.Size = new System.Drawing.Size(239, 163);
            this.pnlEsteganografiaSubMenu.TabIndex = 4;
            // 
            // btnLSB
            // 
            this.btnLSB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLSB.FlatAppearance.BorderSize = 0;
            this.btnLSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLSB.Location = new System.Drawing.Point(0, 120);
            this.btnLSB.Name = "btnLSB";
            this.btnLSB.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLSB.Size = new System.Drawing.Size(239, 40);
            this.btnLSB.TabIndex = 4;
            this.btnLSB.Text = "Least Significant Bit - LSB";
            this.btnLSB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLSB.UseVisualStyleBackColor = true;
            // 
            // btnEspacoEmBranco
            // 
            this.btnEspacoEmBranco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspacoEmBranco.FlatAppearance.BorderSize = 0;
            this.btnEspacoEmBranco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspacoEmBranco.Location = new System.Drawing.Point(0, 80);
            this.btnEspacoEmBranco.Name = "btnEspacoEmBranco";
            this.btnEspacoEmBranco.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEspacoEmBranco.Size = new System.Drawing.Size(239, 40);
            this.btnEspacoEmBranco.TabIndex = 3;
            this.btnEspacoEmBranco.Text = "Espaço em branco";
            this.btnEspacoEmBranco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspacoEmBranco.UseVisualStyleBackColor = true;
            this.btnEspacoEmBranco.Click += new System.EventHandler(this.btnEspacoEmBranco_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 40);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(239, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Winrar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnBlocoNotas
            // 
            this.btnBlocoNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlocoNotas.FlatAppearance.BorderSize = 0;
            this.btnBlocoNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlocoNotas.Location = new System.Drawing.Point(0, 0);
            this.btnBlocoNotas.Name = "btnBlocoNotas";
            this.btnBlocoNotas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBlocoNotas.Size = new System.Drawing.Size(239, 40);
            this.btnBlocoNotas.TabIndex = 1;
            this.btnBlocoNotas.Text = "Bloco de Notas";
            this.btnBlocoNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlocoNotas.UseVisualStyleBackColor = true;
            this.btnBlocoNotas.Click += new System.EventHandler(this.btnBlocoNotas_Click);
            // 
            // btnEsteganografia
            // 
            this.btnEsteganografia.BackColor = System.Drawing.Color.MistyRose;
            this.btnEsteganografia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEsteganografia.FlatAppearance.BorderSize = 0;
            this.btnEsteganografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteganografia.Location = new System.Drawing.Point(0, 738);
            this.btnEsteganografia.Name = "btnEsteganografia";
            this.btnEsteganografia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEsteganografia.Size = new System.Drawing.Size(239, 45);
            this.btnEsteganografia.TabIndex = 5;
            this.btnEsteganografia.Text = "Esteganografia";
            this.btnEsteganografia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsteganografia.UseVisualStyleBackColor = false;
            this.btnEsteganografia.Click += new System.EventHandler(this.btnEsteganografia_Click);
            // 
            // pnlCriptografiaSubMenu
            // 
            this.pnlCriptografiaSubMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnCodigoBinario);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnCodigoMorse);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnSHA512);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnSHA384);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnSHA256);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnSHA1);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnMD5);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnCifraVigenere);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnA1Z26);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnAtbash);
            this.pnlCriptografiaSubMenu.Controls.Add(this.btnCifraCesar);
            this.pnlCriptografiaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCriptografiaSubMenu.Location = new System.Drawing.Point(0, 295);
            this.pnlCriptografiaSubMenu.Name = "pnlCriptografiaSubMenu";
            this.pnlCriptografiaSubMenu.Size = new System.Drawing.Size(239, 443);
            this.pnlCriptografiaSubMenu.TabIndex = 2;
            // 
            // btnSHA512
            // 
            this.btnSHA512.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSHA512.FlatAppearance.BorderSize = 0;
            this.btnSHA512.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHA512.Location = new System.Drawing.Point(0, 320);
            this.btnSHA512.Name = "btnSHA512";
            this.btnSHA512.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSHA512.Size = new System.Drawing.Size(239, 40);
            this.btnSHA512.TabIndex = 9;
            this.btnSHA512.Text = "SHA 512";
            this.btnSHA512.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHA512.UseVisualStyleBackColor = true;
            this.btnSHA512.Click += new System.EventHandler(this.btnSHA512_Click);
            // 
            // btnSHA384
            // 
            this.btnSHA384.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSHA384.FlatAppearance.BorderSize = 0;
            this.btnSHA384.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHA384.Location = new System.Drawing.Point(0, 280);
            this.btnSHA384.Name = "btnSHA384";
            this.btnSHA384.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSHA384.Size = new System.Drawing.Size(239, 40);
            this.btnSHA384.TabIndex = 8;
            this.btnSHA384.Text = "SHA 384";
            this.btnSHA384.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHA384.UseVisualStyleBackColor = true;
            this.btnSHA384.Click += new System.EventHandler(this.btnSHA384_Click);
            // 
            // btnSHA256
            // 
            this.btnSHA256.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSHA256.FlatAppearance.BorderSize = 0;
            this.btnSHA256.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHA256.Location = new System.Drawing.Point(0, 240);
            this.btnSHA256.Name = "btnSHA256";
            this.btnSHA256.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSHA256.Size = new System.Drawing.Size(239, 40);
            this.btnSHA256.TabIndex = 7;
            this.btnSHA256.Text = "SHA 256";
            this.btnSHA256.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHA256.UseVisualStyleBackColor = true;
            this.btnSHA256.Click += new System.EventHandler(this.btnSHA256_Click);
            // 
            // btnSHA1
            // 
            this.btnSHA1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSHA1.FlatAppearance.BorderSize = 0;
            this.btnSHA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHA1.Location = new System.Drawing.Point(0, 200);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSHA1.Size = new System.Drawing.Size(239, 40);
            this.btnSHA1.TabIndex = 6;
            this.btnSHA1.Text = "SHA 1";
            this.btnSHA1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHA1.UseVisualStyleBackColor = true;
            this.btnSHA1.Click += new System.EventHandler(this.btnSHA1_Click);
            // 
            // btnMD5
            // 
            this.btnMD5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMD5.FlatAppearance.BorderSize = 0;
            this.btnMD5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMD5.Location = new System.Drawing.Point(0, 160);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMD5.Size = new System.Drawing.Size(239, 40);
            this.btnMD5.TabIndex = 5;
            this.btnMD5.Text = "MD5";
            this.btnMD5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnCifraVigenere
            // 
            this.btnCifraVigenere.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCifraVigenere.FlatAppearance.BorderSize = 0;
            this.btnCifraVigenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCifraVigenere.Location = new System.Drawing.Point(0, 120);
            this.btnCifraVigenere.Name = "btnCifraVigenere";
            this.btnCifraVigenere.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCifraVigenere.Size = new System.Drawing.Size(239, 40);
            this.btnCifraVigenere.TabIndex = 4;
            this.btnCifraVigenere.Text = "Cifra de Vigenere";
            this.btnCifraVigenere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCifraVigenere.UseVisualStyleBackColor = true;
            this.btnCifraVigenere.Click += new System.EventHandler(this.btnCifraVigenere_Click);
            // 
            // btnA1Z26
            // 
            this.btnA1Z26.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnA1Z26.FlatAppearance.BorderSize = 0;
            this.btnA1Z26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA1Z26.Location = new System.Drawing.Point(0, 80);
            this.btnA1Z26.Name = "btnA1Z26";
            this.btnA1Z26.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnA1Z26.Size = new System.Drawing.Size(239, 40);
            this.btnA1Z26.TabIndex = 3;
            this.btnA1Z26.Text = "A1Z26";
            this.btnA1Z26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA1Z26.UseVisualStyleBackColor = true;
            this.btnA1Z26.Click += new System.EventHandler(this.btnA1Z26_Click);
            // 
            // btnAtbash
            // 
            this.btnAtbash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtbash.FlatAppearance.BorderSize = 0;
            this.btnAtbash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtbash.Location = new System.Drawing.Point(0, 40);
            this.btnAtbash.Name = "btnAtbash";
            this.btnAtbash.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAtbash.Size = new System.Drawing.Size(239, 40);
            this.btnAtbash.TabIndex = 2;
            this.btnAtbash.Text = "Atbash";
            this.btnAtbash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtbash.UseVisualStyleBackColor = true;
            this.btnAtbash.Click += new System.EventHandler(this.btnAtbash_Click);
            // 
            // btnCifraCesar
            // 
            this.btnCifraCesar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCifraCesar.FlatAppearance.BorderSize = 0;
            this.btnCifraCesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCifraCesar.Location = new System.Drawing.Point(0, 0);
            this.btnCifraCesar.Name = "btnCifraCesar";
            this.btnCifraCesar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCifraCesar.Size = new System.Drawing.Size(239, 40);
            this.btnCifraCesar.TabIndex = 1;
            this.btnCifraCesar.Text = "Cifra de César";
            this.btnCifraCesar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCifraCesar.UseVisualStyleBackColor = true;
            this.btnCifraCesar.Click += new System.EventHandler(this.btnCifraCesar_Click);
            // 
            // btnCriptografia
            // 
            this.btnCriptografia.BackColor = System.Drawing.Color.MistyRose;
            this.btnCriptografia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCriptografia.FlatAppearance.BorderSize = 0;
            this.btnCriptografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptografia.Location = new System.Drawing.Point(0, 250);
            this.btnCriptografia.Name = "btnCriptografia";
            this.btnCriptografia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCriptografia.Size = new System.Drawing.Size(239, 45);
            this.btnCriptografia.TabIndex = 3;
            this.btnCriptografia.Text = "Criptografia";
            this.btnCriptografia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriptografia.UseVisualStyleBackColor = false;
            this.btnCriptografia.Click += new System.EventHandler(this.btnCriptografia_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.MistyRose;
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 205);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrincipal.Size = new System.Drawing.Size(239, 45);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(239, 205);
            this.pnlLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(30, 85);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(172, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "CipherNext";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(256, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1008, 643);
            this.pnlContainer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "CipherNext";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 643);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 38);
            this.panel1.TabIndex = 2;
            // 
            // btnCodigoMorse
            // 
            this.btnCodigoMorse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodigoMorse.FlatAppearance.BorderSize = 0;
            this.btnCodigoMorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigoMorse.Location = new System.Drawing.Point(0, 360);
            this.btnCodigoMorse.Name = "btnCodigoMorse";
            this.btnCodigoMorse.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCodigoMorse.Size = new System.Drawing.Size(239, 40);
            this.btnCodigoMorse.TabIndex = 10;
            this.btnCodigoMorse.Text = "Código Morse";
            this.btnCodigoMorse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodigoMorse.UseVisualStyleBackColor = true;
            this.btnCodigoMorse.Click += new System.EventHandler(this.btnCodigoMorse_Click);
            // 
            // btnCodigoBinario
            // 
            this.btnCodigoBinario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodigoBinario.FlatAppearance.BorderSize = 0;
            this.btnCodigoBinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigoBinario.Location = new System.Drawing.Point(0, 400);
            this.btnCodigoBinario.Name = "btnCodigoBinario";
            this.btnCodigoBinario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCodigoBinario.Size = new System.Drawing.Size(239, 40);
            this.btnCodigoBinario.TabIndex = 11;
            this.btnCodigoBinario.Text = "Código Binário";
            this.btnCodigoBinario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodigoBinario.UseVisualStyleBackColor = true;
            this.btnCodigoBinario.Click += new System.EventHandler(this.btnCodigoBinario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CipherNext";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlEsteganografiaSubMenu.ResumeLayout(false);
            this.pnlCriptografiaSubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlEsteganografiaSubMenu;
        private System.Windows.Forms.Button btnLSB;
        private System.Windows.Forms.Button btnEspacoEmBranco;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBlocoNotas;
        private System.Windows.Forms.Button btnEsteganografia;
        private System.Windows.Forms.Panel pnlCriptografiaSubMenu;
        private System.Windows.Forms.Button btnCifraVigenere;
        private System.Windows.Forms.Button btnA1Z26;
        private System.Windows.Forms.Button btnAtbash;
        private System.Windows.Forms.Button btnCifraCesar;
        private System.Windows.Forms.Button btnCriptografia;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnSHA1;
        private System.Windows.Forms.Button btnSHA256;
        private System.Windows.Forms.Button btnSHA384;
        private System.Windows.Forms.Button btnSHA512;
        private System.Windows.Forms.Button btnCodigoMorse;
        private System.Windows.Forms.Button btnCodigoBinario;
    }
}

