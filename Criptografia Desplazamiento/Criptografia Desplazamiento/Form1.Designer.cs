namespace Criptografia_Desplazamiento
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblmensajecifrardescifrar = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsjProcesado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCifrar
            // 
            this.btnCifrar.BackColor = System.Drawing.Color.Lime;
            this.btnCifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCifrar.Location = new System.Drawing.Point(591, 170);
            this.btnCifrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(116, 53);
            this.btnCifrar.TabIndex = 3;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = false;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDescifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescifrar.Location = new System.Drawing.Point(591, 261);
            this.btnDescifrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(116, 53);
            this.btnDescifrar.TabIndex = 4;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = false;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(137, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(384, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Criptografía Desplazamiento";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblmensajecifrardescifrar
            // 
            this.lblmensajecifrardescifrar.AutoSize = true;
            this.lblmensajecifrardescifrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblmensajecifrardescifrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblmensajecifrardescifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensajecifrardescifrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblmensajecifrardescifrar.Location = new System.Drawing.Point(33, 94);
            this.lblmensajecifrardescifrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmensajecifrardescifrar.Name = "lblmensajecifrardescifrar";
            this.lblmensajecifrardescifrar.Size = new System.Drawing.Size(343, 24);
            this.lblmensajecifrardescifrar.TabIndex = 0;
            this.lblmensajecifrardescifrar.Text = "Ingrese el mensaje a cifrar/descifrar";
            // 
            // txtMensaje
            // 
            this.txtMensaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(39, 149);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(451, 26);
            this.txtMensaje.TabIndex = 1;
            this.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(16, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese las unidades de desplazamiento";
            // 
            // txtLlave
            // 
            this.txtLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlave.Location = new System.Drawing.Point(203, 261);
            this.txtLlave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(117, 26);
            this.txtLlave.TabIndex = 2;
            this.txtLlave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(96, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mensaje cifrado/descifrado";
            // 
            // txtMsjProcesado
            // 
            this.txtMsjProcesado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMsjProcesado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsjProcesado.Location = new System.Drawing.Point(39, 383);
            this.txtMsjProcesado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMsjProcesado.Name = "txtMsjProcesado";
            this.txtMsjProcesado.ReadOnly = true;
            this.txtMsjProcesado.Size = new System.Drawing.Size(451, 26);
            this.txtMsjProcesado.TabIndex = 4;
            this.txtMsjProcesado.TabStop = false;
            this.txtMsjProcesado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(769, 465);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.txtMsjProcesado);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmensajecifrardescifrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.btnCifrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(785, 504);
            this.MinimumSize = new System.Drawing.Size(785, 504);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criptografía Desplazamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblmensajecifrardescifrar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsjProcesado;
    }
}

