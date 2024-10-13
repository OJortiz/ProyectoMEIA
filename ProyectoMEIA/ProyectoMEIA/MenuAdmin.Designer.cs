namespace ProyectoMEIA
{
    partial class MenuAdmin
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
            panel1 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            btnLogout = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            lRol = new Label();
            lUsuario = new Label();
            lNombre = new Label();
            lTelefono = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 450);
            panel1.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 387);
            panel5.Name = "panel5";
            panel5.Size = new Size(255, 63);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(103, 63);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnLogout);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(103, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(152, 63);
            panel7.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 63);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 155);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 155);
            panel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox1);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(115, 155);
            panel9.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkBlue;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.sesion;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(lRol);
            panel4.Controls.Add(lUsuario);
            panel4.Controls.Add(lNombre);
            panel4.Controls.Add(lTelefono);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(115, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 155);
            panel4.TabIndex = 1;
            // 
            // lRol
            // 
            lRol.AutoSize = true;
            lRol.ForeColor = Color.White;
            lRol.Location = new Point(29, 14);
            lRol.Name = "lRol";
            lRol.Size = new Size(31, 20);
            lRol.TabIndex = 2;
            lRol.Text = "Rol";
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.ForeColor = Color.White;
            lUsuario.Location = new Point(29, 50);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(59, 20);
            lUsuario.TabIndex = 3;
            lUsuario.Text = "Usuario";
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.ForeColor = Color.White;
            lNombre.Location = new Point(29, 91);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(64, 20);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            // 
            // lTelefono
            // 
            lTelefono.AutoSize = true;
            lTelefono.ForeColor = Color.White;
            lTelefono.Location = new Point(29, 125);
            lTelefono.Name = "lTelefono";
            lTelefono.Size = new Size(67, 20);
            lTelefono.TabIndex = 4;
            lTelefono.Text = "Telefono";
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MenuAdmin";
            Text = "MenuAdmin";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button btnLogout;
        private Panel panel2;
        private Panel panel3;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label lRol;
        private Label lUsuario;
        private Label lNombre;
        private Label lTelefono;
    }
}