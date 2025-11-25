namespace Asignacion_de_tutorias
{
    partial class Interfaz
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
            BtnRegistrarTuto = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnRegistrarTuto
            // 
            BtnRegistrarTuto.BackColor = SystemColors.ButtonHighlight;
            BtnRegistrarTuto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrarTuto.Location = new Point(285, 299);
            BtnRegistrarTuto.Name = "BtnRegistrarTuto";
            BtnRegistrarTuto.Size = new Size(155, 85);
            BtnRegistrarTuto.TabIndex = 0;
            BtnRegistrarTuto.Text = "Registrar ";
            BtnRegistrarTuto.UseVisualStyleBackColor = false;
            BtnRegistrarTuto.Click += BtnRegistrarTuto_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 300);
            button1.Name = "button1";
            button1.Size = new Size(155, 85);
            button1.TabIndex = 1;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(377, 35);
            label1.TabIndex = 2;
            label1.Text = "Registro de Tutorias";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tutoria;
            pictureBox1.Location = new Point(38, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 396);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(BtnRegistrarTuto);
            Name = "Interfaz";
            Text = "Interfaz";
            Load += Interfaz_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegistrarTuto;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}