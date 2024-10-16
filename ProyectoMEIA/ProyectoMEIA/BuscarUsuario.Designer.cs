namespace ProyectoMEIA
{
    partial class BuscarUsuario
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
            txtUsuario = new TextBox();
            btn_buscar = new Button();
            btn_deshabilitar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label1.Location = new Point(137, 123);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(306, 120);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 5;
            // 
            // btn_buscar
            // 
            btn_buscar.FlatAppearance.BorderColor = Color.White;
            btn_buscar.FlatAppearance.BorderSize = 2;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btn_buscar.Location = new Point(93, 188);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(151, 45);
            btn_buscar.TabIndex = 10;
            btn_buscar.Text = "Buscar Usuario";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += button1_Click;
            // 
            // btn_deshabilitar
            // 
            btn_deshabilitar.FlatAppearance.BorderColor = Color.White;
            btn_deshabilitar.FlatAppearance.BorderSize = 2;
            btn_deshabilitar.FlatStyle = FlatStyle.Flat;
            btn_deshabilitar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btn_deshabilitar.Location = new Point(306, 188);
            btn_deshabilitar.Name = "btn_deshabilitar";
            btn_deshabilitar.Size = new Size(173, 46);
            btn_deshabilitar.TabIndex = 12;
            btn_deshabilitar.Text = "Deshabilitar Cuenta";
            btn_deshabilitar.UseVisualStyleBackColor = true;
            btn_deshabilitar.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 52);
            label2.Name = "label2";
            label2.Size = new Size(327, 33);
            label2.TabIndex = 13;
            label2.Text = "Busqueda de Usuarios:";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 30);
            panel1.TabIndex = 20;
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
            // BuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(553, 276);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btn_deshabilitar);
            Controls.Add(btn_buscar);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuscarUsuario";
            Text = "BuscarUsuario";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Button btn_buscar;
        private Button btn_deshabilitar;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}