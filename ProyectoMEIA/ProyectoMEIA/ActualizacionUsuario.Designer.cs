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
            btn_regresar = new Button();
            btn_actualizar = new Button();
            lbl_FechaN = new Label();
            lbl_tel = new Label();
            dtp_NuevaFecha = new DateTimePicker();
            SuspendLayout();
            // 
            // lbl_actu
            // 
            lbl_actu.AutoSize = true;
            lbl_actu.Location = new Point(164, 72);
            lbl_actu.Name = "lbl_actu";
            lbl_actu.Size = new Size(162, 20);
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
            // btn_regresar
            // 
            btn_regresar.Location = new Point(297, 294);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(94, 29);
            btn_regresar.TabIndex = 11;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(121, 294);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(94, 29);
            btn_actualizar.TabIndex = 10;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // lbl_FechaN
            // 
            lbl_FechaN.AutoSize = true;
            lbl_FechaN.Location = new Point(66, 213);
            lbl_FechaN.Name = "lbl_FechaN";
            lbl_FechaN.Size = new Size(149, 20);
            lbl_FechaN.TabIndex = 9;
            lbl_FechaN.Text = "Fecha de Nacimiento";
            // 
            // lbl_tel
            // 
            lbl_tel.AutoSize = true;
            lbl_tel.Location = new Point(66, 148);
            lbl_tel.Name = "lbl_tel";
            lbl_tel.Size = new Size(67, 20);
            lbl_tel.TabIndex = 8;
            lbl_tel.Text = "Telefono";
            // 
            // dtp_NuevaFecha
            // 
            dtp_NuevaFecha.CustomFormat = "dd-MM-yyyy";
            dtp_NuevaFecha.Format = DateTimePickerFormat.Custom;
            dtp_NuevaFecha.Location = new Point(279, 213);
            dtp_NuevaFecha.Margin = new Padding(4, 3, 4, 3);
            dtp_NuevaFecha.Name = "dtp_NuevaFecha";
            dtp_NuevaFecha.Size = new Size(170, 27);
            dtp_NuevaFecha.TabIndex = 16;
            dtp_NuevaFecha.Value = new DateTime(2024, 10, 11, 0, 0, 0, 0);
            // 
            // ActualizacionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 450);
            Controls.Add(dtp_NuevaFecha);
            Controls.Add(lbl_actu);
            Controls.Add(txtTelefono);
            Controls.Add(btn_regresar);
            Controls.Add(btn_actualizar);
            Controls.Add(lbl_FechaN);
            Controls.Add(lbl_tel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizacionUsuario";
            Text = "ActualizacionUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_actu;
        private TextBox textBox2;
        private TextBox txtTelefono;
        private Button btn_regresar;
        private Button btn_actualizar;
        private Label lbl_FechaN;
        private Label lbl_tel;
        private DateTimePicker dtp_NuevaFecha;
    }
}