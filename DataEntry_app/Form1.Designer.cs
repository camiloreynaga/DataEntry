namespace DataEntry_app
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarBD
            // 
            this.btnGenerarBD.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarBD.Name = "btnGenerarBD";
            this.btnGenerarBD.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarBD.TabIndex = 0;
            this.btnGenerarBD.Text = "Generar BD";
            this.btnGenerarBD.UseVisualStyleBackColor = true;
            this.btnGenerarBD.Click += new System.EventHandler(this.btnGenerarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 148);
            this.Controls.Add(this.btnGenerarBD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarBD;
    }
}

