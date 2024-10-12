﻿namespace ProyectoMEIA
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 56);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 164);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 218);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Contraseña: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 269);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 319);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(380, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(380, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(380, 157);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(380, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(380, 312);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 10;
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.CustomFormat = "dd-MM-yyyy";
            dtp_FechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtp_FechaNacimiento.Location = new Point(380, 264);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(125, 27);
            dtp_FechaNacimiento.TabIndex = 11;
            dtp_FechaNacimiento.Value = new DateTime(2024, 10, 11, 0, 0, 0, 0);
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(252, 367);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(144, 52);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
    }
}