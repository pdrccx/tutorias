namespace cuentas_de_usuario
{
    partial class frmRegistrar
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUsuarios = new TextBox();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            cmbTipo = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 111);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 199);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 282);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 371);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 4;
            label5.Text = "Correo Electronico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 459);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Usuario";
            // 
            // txtUsuarios
            // 
            txtUsuarios.Location = new Point(25, 59);
            txtUsuarios.Name = "txtUsuarios";
            txtUsuarios.Size = new Size(125, 27);
            txtUsuarios.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.CharacterCasing = CharacterCasing.Lower;
            txtContraseña.Location = new Point(25, 148);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 238);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(25, 326);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(125, 27);
            txtApellidos.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(25, 417);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(305, 27);
            txtCorreo.TabIndex = 10;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Administrador ", "Estudiante", "Docente", "Jefe de Departamento" });
            cmbTipo.Location = new Point(25, 504);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(305, 28);
            cmbTipo.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(410, 504);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 544);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTipo);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuarios);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistrar";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUsuarios;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private ComboBox cmbTipo;
        private Button btnGuardar;
    }
}