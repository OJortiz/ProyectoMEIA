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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(288, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 5;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(75, 132);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(151, 45);
            btn_buscar.TabIndex = 10;
            btn_buscar.Text = "Buscar Usuario";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += button1_Click;
            // 
            // btn_deshabilitar
            // 
            btn_deshabilitar.Location = new Point(288, 132);
            btn_deshabilitar.Name = "btn_deshabilitar";
            btn_deshabilitar.Size = new Size(173, 46);
            btn_deshabilitar.TabIndex = 12;
            btn_deshabilitar.Text = "Deshabilitar Cuenta";
            btn_deshabilitar.UseVisualStyleBackColor = true;
            btn_deshabilitar.Click += button3_Click;
            // 
            // BuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 255);
            Controls.Add(btn_deshabilitar);
            Controls.Add(btn_buscar);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BuscarUsuario";
            Text = "BuscarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Button btn_buscar;
        private Button btn_deshabilitar;
    }
}