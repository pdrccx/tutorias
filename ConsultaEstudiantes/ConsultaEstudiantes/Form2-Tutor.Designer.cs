namespace ConsultaEstudiantes
{
    partial class Form2_Tutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblPaneldelTutor = new System.Windows.Forms.Label();
            this.BtnListadeEstudiantes = new System.Windows.Forms.Button();
            this.CmbTutor = new System.Windows.Forms.ComboBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutor asignado:";
            // 
            // LblPaneldelTutor
            // 
            this.LblPaneldelTutor.AutoSize = true;
            this.LblPaneldelTutor.Location = new System.Drawing.Point(81, 36);
            this.LblPaneldelTutor.Name = "LblPaneldelTutor";
            this.LblPaneldelTutor.Size = new System.Drawing.Size(107, 13);
            this.LblPaneldelTutor.TabIndex = 1;
            this.LblPaneldelTutor.Text = "PANEL DEL TUTOR";
            // 
            // BtnListadeEstudiantes
            // 
            this.BtnListadeEstudiantes.Location = new System.Drawing.Point(97, 174);
            this.BtnListadeEstudiantes.Name = "BtnListadeEstudiantes";
            this.BtnListadeEstudiantes.Size = new System.Drawing.Size(91, 42);
            this.BtnListadeEstudiantes.TabIndex = 4;
            this.BtnListadeEstudiantes.Text = "Ver lista de estudiantes";
            this.BtnListadeEstudiantes.UseVisualStyleBackColor = true;
            this.BtnListadeEstudiantes.Click += new System.EventHandler(this.BtnListadeEstudiantes_Click);
            // 
            // CmbTutor
            // 
            this.CmbTutor.FormattingEnabled = true;
            this.CmbTutor.Location = new System.Drawing.Point(99, 98);
            this.CmbTutor.Name = "CmbTutor";
            this.CmbTutor.Size = new System.Drawing.Size(121, 21);
            this.CmbTutor.TabIndex = 5;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(12, 184);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegresar.TabIndex = 6;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(203, 194);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Form2_Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 238);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.CmbTutor);
            this.Controls.Add(this.BtnListadeEstudiantes);
            this.Controls.Add(this.LblPaneldelTutor);
            this.Controls.Add(this.label1);
            this.Name = "Form2_Tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2_Tutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPaneldelTutor;
        private System.Windows.Forms.Button BtnListadeEstudiantes;
        private System.Windows.Forms.ComboBox CmbTutor;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}