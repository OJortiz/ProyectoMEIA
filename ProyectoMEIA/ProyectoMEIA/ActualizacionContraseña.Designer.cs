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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 77);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su contraseña: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 137);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su nueva contraseña: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 200);
            label3.Name = "label3";
            label3.Size = new Size(214, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirme su nueva contraseña: ";
            // 
            // txtContraActual
            // 
            txtContraActual.Location = new Point(382, 70);
            txtContraActual.Name = "txtContraActual";
            txtContraActual.Size = new Size(125, 27);
            txtContraActual.TabIndex = 3;
            txtContraActual.UseSystemPasswordChar = true;
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(382, 130);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(125, 27);
            txtNuevaContra.TabIndex = 4;
            txtNuevaContra.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(382, 193);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(125, 27);
            txtConfirmarContra.TabIndex = 5;
            txtConfirmarContra.UseSystemPasswordChar = true;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Location = new Point(194, 263);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(175, 55);
            btnCambiarContraseña.TabIndex = 6;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // ActualizacionContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(txtConfirmarContra);
            Controls.Add(txtNuevaContra);
            Controls.Add(txtContraActual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActualizacionContraseña";
            Text = "ActualizacionContraseña";
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
    }
}