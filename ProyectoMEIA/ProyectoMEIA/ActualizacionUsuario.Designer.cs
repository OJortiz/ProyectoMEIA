namespace ProyectoMEIA
{
    partial class ActualizacionUsuario
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
            lbl_actu = new Label();
            txtTelefono = new TextBox();
            btn_actualizar = new Button();
            lbl_FechaN = new Label();
            lbl_tel = new Label();
            dtp_NuevaFecha = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_actu
            // 
            lbl_actu.AutoSize = true;
            lbl_actu.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_actu.Location = new Point(86, 51);
            lbl_actu.Name = "lbl_actu";
            lbl_actu.Size = new Size(322, 33);
            lbl_actu.TabIndex = 15;
            lbl_actu.Text = "Actualizacion de Datos";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(297, 141);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 12;
            // 
            // btn_actualizar
            // 
            btn_actualizar.FlatAppearance.BorderColor = Color.White;
            btn_actualizar.FlatAppearance.BorderSize = 2;
            btn_actualizar.FlatStyle = FlatStyle.Flat;
            btn_actualizar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btn_actualizar.Location = new Point(176, 289);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(141, 42);
            btn_actualizar.TabIndex = 10;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // lbl_FechaN
            // 
            lbl_FechaN.AutoSize = true;
            lbl_FechaN.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lbl_FechaN.Location = new Point(66, 213);
            lbl_FechaN.Name = "lbl_FechaN";
            lbl_FechaN.Size = new Size(172, 19);
            lbl_FechaN.TabIndex = 9;
            lbl_FechaN.Text = "Fecha de Nacimiento";
            // 
            // lbl_tel
            // 
            lbl_tel.AutoSize = true;
            lbl_tel.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lbl_tel.Location = new Point(66, 148);
            lbl_tel.Name = "lbl_tel";
            lbl_tel.Size = new Size(75, 19);
            lbl_tel.TabIndex = 8;
            lbl_tel.Text = "Telefono";
            // 
            // dtp_NuevaFecha
            // 
            dtp_NuevaFecha.CustomFormat = "dd-MM-yyyy";
            dtp_NuevaFecha.Format = DateTimePickerFormat.Custom;
            dtp_NuevaFecha.Location = new Point(297, 213);
            dtp_NuevaFecha.Margin = new Padding(4, 3, 4, 3);
            dtp_NuevaFecha.Name = "dtp_NuevaFecha";
            dtp_NuevaFecha.Size = new Size(125, 27);
            dtp_NuevaFecha.TabIndex = 16;
            dtp_NuevaFecha.Value = new DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.cerrar1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 27);
            panel1.TabIndex = 18;
            // 
            // ActualizacionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(494, 450);
            Controls.Add(panel1);
            Controls.Add(dtp_NuevaFecha);
            Controls.Add(lbl_actu);
            Controls.Add(txtTelefono);
            Controls.Add(btn_actualizar);
            Controls.Add(lbl_FechaN);
            Controls.Add(lbl_tel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizacionUsuario";
            Text = "ActualizacionUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_actu;
        private TextBox textBox2;
        private TextBox txtTelefono;
        private Button btn_actualizar;
        private Label lbl_FechaN;
        private Label lbl_tel;
        private DateTimePicker dtp_NuevaFecha;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}