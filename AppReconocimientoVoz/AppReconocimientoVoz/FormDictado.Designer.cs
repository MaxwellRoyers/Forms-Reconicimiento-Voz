namespace AppReconocimientoVoz
{
    partial class FormDictado
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
            this.lblDictado = new System.Windows.Forms.Label();
            this.txtDictado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDictado
            // 
            this.lblDictado.AutoSize = true;
            this.lblDictado.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDictado.Location = new System.Drawing.Point(272, 72);
            this.lblDictado.Name = "lblDictado";
            this.lblDictado.Size = new System.Drawing.Size(250, 73);
            this.lblDictado.TabIndex = 1;
            this.lblDictado.Text = "Dictado";
            // 
            // txtDictado
            // 
            this.txtDictado.Location = new System.Drawing.Point(40, 169);
            this.txtDictado.Name = "txtDictado";
            this.txtDictado.Size = new System.Drawing.Size(717, 255);
            this.txtDictado.TabIndex = 2;
            this.txtDictado.Text = "";
            // 
            // FormDictado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDictado);
            this.Controls.Add(this.lblDictado);
            this.Name = "FormDictado";
            this.Text = "FormDictado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDictado;
        private System.Windows.Forms.RichTextBox txtDictado;
    }
}