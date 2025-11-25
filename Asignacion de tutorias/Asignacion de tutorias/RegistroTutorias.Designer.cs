namespace Asignacion_de_tutorias
{
    partial class RegistroTutorias
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DgvAlumnos = new DataGridView();
            DtpFecha = new DateTimePicker();
            TxtActividad = new TextBox();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 1;
            label2.Text = "Alumnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 379);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 2;
            label3.Text = "Actividad";
            // 
            // DgvAlumnos
            // 
            DgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAlumnos.Location = new Point(12, 130);
            DgvAlumnos.Name = "DgvAlumnos";
            DgvAlumnos.RowHeadersWidth = 51;
            DgvAlumnos.Size = new Size(577, 198);
            DgvAlumnos.TabIndex = 3;
            DgvAlumnos.CellContentClick += DgvAlumnos_CellContentClick;
            // 
            // DtpFecha
            // 
            DtpFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DtpFecha.Location = new Point(105, 29);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(390, 30);
            DtpFecha.TabIndex = 4;
            DtpFecha.ValueChanged += DtpFecha_ValueChanged;
            // 
            // TxtActividad
            // 
            TxtActividad.Location = new Point(164, 378);
            TxtActividad.Name = "TxtActividad";
            TxtActividad.Size = new Size(346, 27);
            TxtActividad.TabIndex = 5;
            TxtActividad.TextChanged += TxtActividad_TextChanged;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = SystemColors.ActiveBorder;
            BtnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.ControlText;
            BtnCancelar.Location = new Point(49, 450);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(122, 51);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = SystemColors.ActiveBorder;
            BtnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.Location = new Point(428, 450);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(122, 51);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // RegistroTutorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 532);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnCancelar);
            Controls.Add(TxtActividad);
            Controls.Add(DtpFecha);
            Controls.Add(DgvAlumnos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroTutorias";
            Text = "RegistroTutorias";
            ((System.ComponentModel.ISupportInitialize)DgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView DgvAlumnos;
        private DateTimePicker DtpFecha;
        private TextBox TxtActividad;
        private Button BtnCancelar;
        private Button BtnGuardar;
    }
}