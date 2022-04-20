namespace Criptografia_Cesar
{
    partial class frmPrincipal
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
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.txtMcla = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsjEncdecr = new System.Windows.Forms.Label();
            this.txtCriptograma = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCifrar
            // 
            this.btnCifrar.AutoSize = true;
            this.btnCifrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCifrar.Location = new System.Drawing.Point(96, 153);
            this.btnCifrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(112, 48);
            this.btnCifrar.TabIndex = 0;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = false;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.AutoSize = true;
            this.btnDescifrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDescifrar.Location = new System.Drawing.Point(225, 153);
            this.btnDescifrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(112, 48);
            this.btnDescifrar.TabIndex = 1;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = false;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // txtMcla
            // 
            this.txtMcla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMcla.Location = new System.Drawing.Point(26, 97);
            this.txtMcla.Margin = new System.Windows.Forms.Padding(4);
            this.txtMcla.Name = "txtMcla";
            this.txtMcla.Size = new System.Drawing.Size(384, 29);
            this.txtMcla.TabIndex = 2;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(22, 60);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(395, 24);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "Ingresa el mensaje que quieras cifrar/descifrar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(355, 35);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Método Criptográfico César";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblMsjEncdecr);
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnCifrar);
            this.panel1.Controls.Add(this.btnDescifrar);
            this.panel1.Controls.Add(this.txtCriptograma);
            this.panel1.Controls.Add(this.txtMcla);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 357);
            this.panel1.TabIndex = 5;
            // 
            // lblMsjEncdecr
            // 
            this.lblMsjEncdecr.AutoSize = true;
            this.lblMsjEncdecr.Location = new System.Drawing.Point(75, 225);
            this.lblMsjEncdecr.Name = "lblMsjEncdecr";
            this.lblMsjEncdecr.Size = new System.Drawing.Size(262, 24);
            this.lblMsjEncdecr.TabIndex = 5;
            this.lblMsjEncdecr.Text = "Criptograma/Mensaje en claro";
            // 
            // txtCriptograma
            // 
            this.txtCriptograma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCriptograma.Location = new System.Drawing.Point(26, 265);
            this.txtCriptograma.Margin = new System.Windows.Forms.Padding(4);
            this.txtCriptograma.Name = "txtCriptograma";
            this.txtCriptograma.ReadOnly = true;
            this.txtCriptograma.Size = new System.Drawing.Size(384, 29);
            this.txtCriptograma.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(445, 381);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(461, 420);
            this.MinimumSize = new System.Drawing.Size(461, 420);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo Cesar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.TextBox txtMcla;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsjEncdecr;
        private System.Windows.Forms.TextBox txtCriptograma;
    }
}

