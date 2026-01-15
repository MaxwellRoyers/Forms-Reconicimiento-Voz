namespace AppReconocimientoVoz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblComando = new System.Windows.Forms.Label();
            this.lblEscuchando = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 326);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(159, 31);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar reconocimiento";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(200, 326);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(159, 31);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "Detener reconocimiento";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblComando
            // 
            this.lblComando.AutoSize = true;
            this.lblComando.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComando.Location = new System.Drawing.Point(37, 98);
            this.lblComando.Name = "lblComando";
            this.lblComando.Size = new System.Drawing.Size(187, 42);
            this.lblComando.TabIndex = 2;
            this.lblComando.Text = "Comando";
            // 
            // lblEscuchando
            // 
            this.lblEscuchando.AutoSize = true;
            this.lblEscuchando.Location = new System.Drawing.Point(41, 149);
            this.lblEscuchando.Name = "lblEscuchando";
            this.lblEscuchando.Size = new System.Drawing.Size(76, 13);
            this.lblEscuchando.TabIndex = 3;
            this.lblEscuchando.Text = "Escuchando...";
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(576, 2);
            this.lstHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(141, 82);
            this.lstHistorial.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 381);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblEscuchando);
            this.Controls.Add(this.lblComando);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FormPrincipal";
            this.Text = "Reconocimiento de voz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblComando;
        private System.Windows.Forms.Label lblEscuchando;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}

