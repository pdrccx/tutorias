namespace RegistroCanalizacion
{
    partial class Form1
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
            label1 = new Label();
            Label = new Label();
            DtpFecha = new DateTimePicker();
            TxtNumControl = new TextBox();
            label2 = new Label();
            comboCanalizar = new ComboBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 39);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(5, 128);
            Label.Name = "Label";
            Label.Size = new Size(125, 20);
            Label.TabIndex = 1;
            Label.Text = "No. Control";
            // 
            // DtpFecha
            // 
            DtpFecha.Location = new Point(79, 33);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(282, 27);
            DtpFecha.TabIndex = 3;
            DtpFecha.ValueChanged += DtpFecha_ValueChanged;
            // 
            // TxtNumControl
            // 
            TxtNumControl.Location = new Point(136, 124);
            TxtNumControl.Name = "TxtNumControl";
            TxtNumControl.Size = new Size(225, 27);
            TxtNumControl.TabIndex = 4;
            TxtNumControl.TextChanged += TxtNumControl_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "Canalizar";
            // 
            // comboCanalizar
            // 
            comboCanalizar.FormattingEnabled = true;
            comboCanalizar.Location = new Point(127, 220);
            comboCanalizar.Name = "comboCanalizar";
            comboCanalizar.Size = new Size(202, 28);
            comboCanalizar.TabIndex = 6;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = SystemColors.ActiveBorder;
            BtnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.Location = new Point(236, 310);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(102, 37);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = SystemColors.ActiveBorder;
            BtnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.Location = new Point(40, 310);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(102, 37);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 401);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(comboCanalizar);
            Controls.Add(label2);
            Controls.Add(TxtNumControl);
            Controls.Add(DtpFecha);
            Controls.Add(Label);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Label;
        private DateTimePicker DtpFecha;
        private TextBox TxtNumControl;
        private Label label2;
        private ComboBox comboCanalizar;
        private Button BtnGuardar;
        private Button BtnCancelar;
    }
}
