namespace ProyectoMEIA
{
    partial class ActualizacionContraseña
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
            txtContraActual = new TextBox();
            txtNuevaContra = new TextBox();
            txtConfirmarContra = new TextBox();
            btnCambiarContraseña = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label1.Location = new Point(52, 85);
            label1.Name = "label1";
            label1.Size = new Size(174, 22);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su contraseña: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label2.Location = new Point(52, 151);
            label2.Name = "label2";
            label2.Size = new Size(220, 22);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su nueva contraseña: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label3.Location = new Point(52, 220);
            label3.Name = "label3";
            label3.Size = new Size(231, 22);
            label3.TabIndex = 2;
            label3.Text = "Confirme su nueva contraseña: ";
            // 
            // txtContraActual
            // 
            txtContraActual.Location = new Point(351, 85);
            txtContraActual.Name = "txtContraActual";
            txtContraActual.Size = new Size(140, 27);
            txtContraActual.TabIndex = 3;
            txtContraActual.UseSystemPasswordChar = true;
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(351, 151);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(140, 27);
            txtNuevaContra.TabIndex = 4;
            txtNuevaContra.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(351, 220);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(140, 27);
            txtConfirmarContra.TabIndex = 5;
            txtConfirmarContra.UseSystemPasswordChar = true;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.FlatAppearance.BorderColor = Color.White;
            btnCambiarContraseña.FlatAppearance.BorderSize = 2;
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.Location = new Point(170, 305);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(197, 60);
            btnCambiarContraseña.TabIndex = 6;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 30);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.cerrar1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 23);
            label4.Name = "label4";
            label4.Size = new Size(276, 33);
            label4.TabIndex = 20;
            label4.Text = "Cambio de contraseña: ";
            // 
            // ActualizacionContraseña
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(543, 393);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(txtConfirmarContra);
            Controls.Add(txtNuevaContra);
            Controls.Add(txtContraActual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizacionContraseña";
            Text = "ActualizacionContraseña";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContraActual;
        private TextBox txtNuevaContra;
        private TextBox txtConfirmarContra;
        private Button btnCambiarContraseña;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}