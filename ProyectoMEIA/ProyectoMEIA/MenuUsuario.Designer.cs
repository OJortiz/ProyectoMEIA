namespace ProyectoMEIA
{
    partial class MenuUsuario
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
            lnombre = new Label();
            lRol = new Label();
            lUsuario = new Label();
            lTelefono = new Label();
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
            panel8 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // lnombre
            // 
            lnombre.AutoSize = true;
            lnombre.ForeColor = Color.White;
            lnombre.Location = new Point(29, 91);
            lnombre.Name = "lnombre";
            lnombre.Size = new Size(64, 20);
            lnombre.TabIndex = 0;
            lnombre.Text = "Nombre";
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
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 450);
            panel1.TabIndex = 5;
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
            panel4.Controls.Add(lnombre);
            panel4.Controls.Add(lTelefono);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(115, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 155);
            panel4.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(label3);
            panel8.Controls.Add(linkLabel1);
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(button1);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(255, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(545, 450);
            panel8.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 91);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 156);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Nacimiento";
            // 
            // button1
            // 
            button1.Location = new Point(133, 237);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(309, 237);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(183, 333);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cambiar Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 28);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 7;
            label3.Text = "Actualizacion de Datos";
            // 
            // MenuUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "MenuUsuario";
            Text = "MenuUsuario";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lnombre;
        private Label lRol;
        private Label lUsuario;
        private Label lTelefono;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private Button btnLogout;
        private Panel panel9;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}