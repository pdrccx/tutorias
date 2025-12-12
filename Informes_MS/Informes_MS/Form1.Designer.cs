namespace Informes_MS
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.DgvTutores = new System.Windows.Forms.DataGridView();
            this.BtnVerInformes = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTutores
            // 
            this.DgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTutores.Location = new System.Drawing.Point(12, 12);
            this.DgvTutores.Name = "DgvTutores";
            this.DgvTutores.Size = new System.Drawing.Size(260, 199);
            this.DgvTutores.TabIndex = 0;
            // 
            // BtnVerInformes
            // 
            this.BtnVerInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerInformes.Location = new System.Drawing.Point(41, 226);
            this.BtnVerInformes.Name = "BtnVerInformes";
            this.BtnVerInformes.Size = new System.Drawing.Size(100, 23);
            this.BtnVerInformes.TabIndex = 1;
            this.BtnVerInformes.Text = "Ver Informes";
            this.BtnVerInformes.UseVisualStyleBackColor = true;
            this.BtnVerInformes.Click += new System.EventHandler(this.BtnVerInformes_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(183, 226);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnVerInformes);
            this.Controls.Add(this.DgvTutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTutores;
        private System.Windows.Forms.Button BtnVerInformes;
        private System.Windows.Forms.Button BtnSalir;
    }
}

