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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(16, 401);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(212, 38);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar reconocimiento";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(267, 401);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(212, 38);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "Detener reconocimiento";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblComando
            // 
            this.lblComando.AutoSize = true;
            this.lblComando.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComando.Location = new System.Drawing.Point(49, 121);
            this.lblComando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComando.Name = "lblComando";
            this.lblComando.Size = new System.Drawing.Size(233, 54);
            this.lblComando.TabIndex = 2;
            this.lblComando.Text = "Comando";
            // 
            // lblEscuchando
            // 
            this.lblEscuchando.AutoSize = true;
            this.lblEscuchando.Location = new System.Drawing.Point(55, 183);
            this.lblEscuchando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscuchando.Name = "lblEscuchando";
            this.lblEscuchando.Size = new System.Drawing.Size(91, 16);
            this.lblEscuchando.TabIndex = 3;
            this.lblEscuchando.Text = "Escuchando...";
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 16;
            this.lstHistorial.Location = new System.Drawing.Point(768, 2);
            this.lstHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(187, 100);
            this.lstHistorial.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppReconocimientoVoz.Properties.Resources._7adc63b83fb54fe1164811db40e09864;
            this.pictureBox1.InitialImage = global::AppReconocimientoVoz.Properties.Resources._7adc63b83fb54fe1164811db40e09864;
            this.pictureBox1.Location = new System.Drawing.Point(522, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 344);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblEscuchando);
            this.Controls.Add(this.lblComando);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Reconocimiento de voz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblComando;
        private System.Windows.Forms.Label lblEscuchando;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

