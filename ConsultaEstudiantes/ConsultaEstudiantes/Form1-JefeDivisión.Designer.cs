namespace ConsultaEstudiantes
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
            this.LblJefeDivisión = new System.Windows.Forms.Label();
            this.BtnAbrirPaneldelTutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTutores = new System.Windows.Forms.ComboBox();
            this.BtnGuardarTutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblJefeDivisión
            // 
            this.LblJefeDivisión.AutoSize = true;
            this.LblJefeDivisión.Location = new System.Drawing.Point(50, 27);
            this.LblJefeDivisión.Name = "LblJefeDivisión";
            this.LblJefeDivisión.Size = new System.Drawing.Size(100, 13);
            this.LblJefeDivisión.TabIndex = 0;
            this.LblJefeDivisión.Text = "JEFE DE DIVISION";
            // 
            // BtnAbrirPaneldelTutor
            // 
            this.BtnAbrirPaneldelTutor.Location = new System.Drawing.Point(118, 146);
            this.BtnAbrirPaneldelTutor.Name = "BtnAbrirPaneldelTutor";
            this.BtnAbrirPaneldelTutor.Size = new System.Drawing.Size(109, 51);
            this.BtnAbrirPaneldelTutor.TabIndex = 3;
            this.BtnAbrirPaneldelTutor.Text = "Abrir panel del tutor.";
            this.BtnAbrirPaneldelTutor.UseVisualStyleBackColor = true;
            this.BtnAbrirPaneldelTutor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecciona un tutor:";
            // 
            // CmbTutores
            // 
            this.CmbTutores.FormattingEnabled = true;
            this.CmbTutores.Location = new System.Drawing.Point(117, 61);
            this.CmbTutores.Name = "CmbTutores";
            this.CmbTutores.Size = new System.Drawing.Size(121, 21);
            this.CmbTutores.TabIndex = 5;
            // 
            // BtnGuardarTutor
            // 
            this.BtnGuardarTutor.Location = new System.Drawing.Point(12, 160);
            this.BtnGuardarTutor.Name = "BtnGuardarTutor";
            this.BtnGuardarTutor.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarTutor.TabIndex = 6;
            this.BtnGuardarTutor.Text = "Guardar";
            this.BtnGuardarTutor.UseVisualStyleBackColor = true;
            this.BtnGuardarTutor.Click += new System.EventHandler(this.BtnGuardarTutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 209);
            this.Controls.Add(this.BtnGuardarTutor);
            this.Controls.Add(this.CmbTutores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAbrirPaneldelTutor);
            this.Controls.Add(this.LblJefeDivisión);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblJefeDivisión;
        private System.Windows.Forms.Button BtnAbrirPaneldelTutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTutores;
        private System.Windows.Forms.Button BtnGuardarTutor;
    }
}

