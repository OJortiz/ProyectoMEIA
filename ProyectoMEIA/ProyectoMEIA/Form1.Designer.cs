namespace ProyectoMEIA
{
    partial class Form_Main
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
            lbl_Username = new Label();
            lbl_password = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_createacc = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.FlatStyle = FlatStyle.Flat;
            lbl_Username.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(61, 72);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(76, 23);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Usuario";
            lbl_Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = Color.White;
            lbl_password.Location = new Point(61, 179);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(112, 23);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Contraseña";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(64, 64, 64);
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.ForeColor = Color.White;
            txt_username.Location = new Point(61, 115);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(329, 25);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(64, 64, 64);
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.White;
            txt_password.Location = new Point(61, 228);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(329, 25);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(64, 64, 64);
            btn_login.FlatAppearance.BorderColor = Color.Black;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Arial", 9F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(61, 315);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(136, 62);
            btn_login.TabIndex = 4;
            btn_login.Text = "Iniciar Sesión";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_createacc
            // 
            btn_createacc.BackColor = Color.FromArgb(64, 64, 64);
            btn_createacc.FlatAppearance.BorderColor = Color.Black;
            btn_createacc.FlatStyle = FlatStyle.Flat;
            btn_createacc.Font = new Font("Arial", 9F, FontStyle.Bold);
            btn_createacc.ForeColor = Color.White;
            btn_createacc.Location = new Point(254, 315);
            btn_createacc.Name = "btn_createacc";
            btn_createacc.Size = new Size(136, 62);
            btn_createacc.TabIndex = 5;
            btn_createacc.Text = "Crear Cuenta";
            btn_createacc.UseVisualStyleBackColor = false;
            btn_createacc.Click += btn_createacc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 21);
            label1.Name = "label1";
            label1.Size = new Size(201, 39);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(464, 441);
            Controls.Add(label1);
            Controls.Add(btn_createacc);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_Main";
            Text = "Proyecto MEIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Username;
        private Label lbl_password;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_createacc;
        private Label label1;
    }
}
