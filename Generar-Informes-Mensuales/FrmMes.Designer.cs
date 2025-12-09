namespace Generar_Informes_Mensuales
{
    partial class FrmMes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmbMes = new ComboBox();
            BtnGenerar = new Button();
            DgvSesiones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvSesiones).BeginInit();
            SuspendLayout();
            // 
            // CmbMes
            // 
            CmbMes.FormattingEnabled = true;
            CmbMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            CmbMes.Location = new Point(12, 23);
            CmbMes.Name = "CmbMes";
            CmbMes.Size = new Size(311, 28);
            CmbMes.TabIndex = 0;
            // 
            // BtnGenerar
            // 
            BtnGenerar.Location = new Point(12, 314);
            BtnGenerar.Name = "BtnGenerar";
            BtnGenerar.Size = new Size(203, 80);
            BtnGenerar.TabIndex = 1;
            BtnGenerar.Text = "Generar";
            BtnGenerar.UseVisualStyleBackColor = true;
            BtnGenerar.Click += BtnGenerar_Click;
            // 
            // DgvSesiones
            // 
            DgvSesiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSesiones.Location = new Point(12, 83);
            DgvSesiones.Name = "DgvSesiones";
            DgvSesiones.RowHeadersWidth = 51;
            DgvSesiones.Size = new Size(383, 188);
            DgvSesiones.TabIndex = 2;
            DgvSesiones.CellContentClick += DgvSesiones_CellContentClick;
            // 
            // FrmMes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 406);
            Controls.Add(DgvSesiones);
            Controls.Add(BtnGenerar);
            Controls.Add(CmbMes);
            Name = "FrmMes";
            Text = "Mes";
            ((System.ComponentModel.ISupportInitialize)DgvSesiones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CmbMes;
        private Button BtnGenerar;
        private DataGridView DgvSesiones;
    }
}
