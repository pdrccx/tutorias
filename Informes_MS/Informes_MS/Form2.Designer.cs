namespace Informes_MS
{
    partial class Form2
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
            this.CmbTutor = new System.Windows.Forms.ComboBox();
            this.DgvSemestrales = new System.Windows.Forms.DataGridView();
            this.DgvMensuales = new System.Windows.Forms.DataGridView();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSemestrales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMensuales)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbTutor
            // 
            this.CmbTutor.FormattingEnabled = true;
            this.CmbTutor.Location = new System.Drawing.Point(29, 33);
            this.CmbTutor.Name = "CmbTutor";
            this.CmbTutor.Size = new System.Drawing.Size(512, 21);
            this.CmbTutor.TabIndex = 0;
            // 
            // DgvSemestrales
            // 
            this.DgvSemestrales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSemestrales.Location = new System.Drawing.Point(29, 94);
            this.DgvSemestrales.Name = "DgvSemestrales";
            this.DgvSemestrales.Size = new System.Drawing.Size(391, 150);
            this.DgvSemestrales.TabIndex = 1;
            // 
            // DgvMensuales
            // 
            this.DgvMensuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMensuales.Location = new System.Drawing.Point(438, 92);
            this.DgvMensuales.Name = "DgvMensuales";
            this.DgvMensuales.Size = new System.Drawing.Size(424, 152);
            this.DgvMensuales.TabIndex = 2;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(178, 250);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegresar.TabIndex = 3;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(602, 250);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informes Semestrales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Informes Mensuales";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvMensuales);
            this.Controls.Add(this.DgvSemestrales);
            this.Controls.Add(this.CmbTutor);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSemestrales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMensuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTutor;
        private System.Windows.Forms.DataGridView DgvSemestrales;
        private System.Windows.Forms.DataGridView DgvMensuales;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}