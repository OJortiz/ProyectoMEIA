namespace ProyectoMEIA
{
    partial class NuevoUsuario
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
            txtUsuario = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtPassword = new TextBox();
            txtTelefono = new TextBox();
            dtp_FechaNacimiento = new DateTimePicker();
            btnRegistrar = new Button();
            label7 = new Label();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(122, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 2;
            label3.Text = "Apellido: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(122, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 3;
            label4.Text = "Contraseña: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(122, 328);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 23);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(122, 385);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(446, 82);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(170, 30);
            txtUsuario.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(446, 138);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 30);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(446, 199);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(170, 30);
            txtApellido.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(446, 261);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 30);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(446, 377);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 30);
            txtTelefono.TabIndex = 10;
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.CustomFormat = "dd-MM-yyyy";
            dtp_FechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtp_FechaNacimiento.Location = new Point(446, 322);
            dtp_FechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(170, 30);
            dtp_FechaNacimiento.TabIndex = 11;
            dtp_FechaNacimiento.Value = new DateTime(2024, 10, 13, 0, 0, 0, 0);
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SteelBlue;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(122, 460);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(198, 60);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(245, 19);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(262, 33);
            label7.TabIndex = 13;
            label7.Text = "Ingrese sus datos:";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.SteelBlue;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Location = new Point(419, 460);
            btn_Login.Margin = new Padding(4, 3, 4, 3);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(198, 60);
            btn_Login.TabIndex = 14;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(764, 562);
            Controls.Add(btn_Login);
            Controls.Add(label7);
            Controls.Add(btnRegistrar);
            Controls.Add(dtp_FechaNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(txtPassword);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtUsuario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "NuevoUsuario";
            Text = "NuevoUsuario";
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
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtPassword;
        private TextBox txtTelefono;
        private DateTimePicker dtp_FechaNacimiento;
        private Button btnRegistrar;
        private Label label7;
        private Button btn_Login;
    }
}