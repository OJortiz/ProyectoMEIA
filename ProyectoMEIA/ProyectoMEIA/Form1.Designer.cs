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
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(94, 134);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(59, 20);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(94, 176);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(83, 20);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Contraseña";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(220, 127);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(182, 27);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(220, 176);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(182, 27);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(91, 258);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(136, 62);
            btn_login.TabIndex = 4;
            btn_login.Text = "Iniciar Sesión";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_createacc
            // 
            btn_createacc.Location = new Point(311, 258);
            btn_createacc.Name = "btn_createacc";
            btn_createacc.Size = new Size(136, 62);
            btn_createacc.TabIndex = 5;
            btn_createacc.Text = "Crear Cuenta";
            btn_createacc.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 441);
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
    }
}
