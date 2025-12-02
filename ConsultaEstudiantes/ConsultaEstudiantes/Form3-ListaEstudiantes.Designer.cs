namespace ConsultaEstudiantes
{
    partial class Form3_ListaEstudiantes
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
            this.LblListaEstudiantes = new System.Windows.Forms.Label();
            this.DgvListaEstudiantes = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblEstudiantesAsignados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblListaEstudiantes
            // 
            this.LblListaEstudiantes.AutoSize = true;
            this.LblListaEstudiantes.Location = new System.Drawing.Point(73, 26);
            this.LblListaEstudiantes.Name = "LblListaEstudiantes";
            this.LblListaEstudiantes.Size = new System.Drawing.Size(134, 13);
            this.LblListaEstudiantes.TabIndex = 0;
            this.LblListaEstudiantes.Text = "LISTA DE ESTUDIANTES";
            // 
            // DgvListaEstudiantes
            // 
            this.DgvListaEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaEstudiantes.Location = new System.Drawing.Point(12, 67);
            this.DgvListaEstudiantes.Name = "DgvListaEstudiantes";
            this.DgvListaEstudiantes.Size = new System.Drawing.Size(335, 150);
            this.DgvListaEstudiantes.TabIndex = 1;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(177, 223);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(95, 26);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblEstudiantesAsignados
            // 
            this.LblEstudiantesAsignados.AutoSize = true;
            this.LblEstudiantesAsignados.Location = new System.Drawing.Point(24, 46);
            this.LblEstudiantesAsignados.Name = "LblEstudiantesAsignados";
            this.LblEstudiantesAsignados.Size = new System.Drawing.Size(151, 13);
            this.LblEstudiantesAsignados.TabIndex = 3;
            this.LblEstudiantesAsignados.Text = "Estudiantes asignados al tutor:";
            // 
            // Form3_ListaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.LblEstudiantesAsignados);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DgvListaEstudiantes);
            this.Controls.Add(this.LblListaEstudiantes);
            this.Name = "Form3_ListaEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3_ListaEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblListaEstudiantes;
        private System.Windows.Forms.DataGridView DgvListaEstudiantes;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblEstudiantesAsignados;
    }
}