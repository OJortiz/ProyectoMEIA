namespace ProyectoMEIA
{
    partial class ListaDifusion
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
            txtNombreLista = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtmodificar = new TextBox();
            label5 = new Label();
            lblEstatus = new Label();
            chkDescripcion = new CheckBox();
            chkEstatus = new CheckBox();
            chkNombre = new CheckBox();
            txtNewDescripcion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNuevoNombre = new TextBox();
            tabPage3 = new TabPage();
            lblEliminar = new Label();
            txtEliminar = new TextBox();
            tabPage4 = new TabPage();
            label6 = new Label();
            chkBuscarTodas = new CheckBox();
            txtBuscar = new TextBox();
            listViewResultados = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreLista
            // 
            txtNombreLista.Location = new Point(255, 62);
            txtNombreLista.Name = "txtNombreLista";
            txtNombreLista.Size = new Size(125, 27);
            txtNombreLista.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(255, 135);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(247, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(255, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 48);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(67, 263);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(143, 48);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(56, 256);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 48);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(259, 222);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 48);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 69);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 11;
            label1.Text = "Nombre de Lista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 138);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 12;
            label2.Text = "Descripción";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(70, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(743, 436);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(txtDescripcion);
            tabPage1.Controls.Add(txtNombreLista);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(735, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(txtmodificar);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(lblEstatus);
            tabPage2.Controls.Add(chkDescripcion);
            tabPage2.Controls.Add(chkEstatus);
            tabPage2.Controls.Add(chkNombre);
            tabPage2.Controls.Add(txtNewDescripcion);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtNuevoNombre);
            tabPage2.Controls.Add(btnModificar);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(735, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificar";
            // 
            // txtmodificar
            // 
            txtmodificar.Location = new Point(65, 155);
            txtmodificar.Name = "txtmodificar";
            txtmodificar.Size = new Size(125, 27);
            txtmodificar.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 101);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 18;
            label5.Text = "Dato a modificar:";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(511, 295);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(80, 28);
            lblEstatus.TabIndex = 17;
            lblEstatus.Text = "Estatus";
            // 
            // chkDescripcion
            // 
            chkDescripcion.AutoSize = true;
            chkDescripcion.Font = new Font("Segoe UI", 10.8F);
            chkDescripcion.Location = new Point(300, 198);
            chkDescripcion.Name = "chkDescripcion";
            chkDescripcion.Size = new Size(126, 29);
            chkDescripcion.TabIndex = 16;
            chkDescripcion.Text = "Descripción";
            chkDescripcion.UseVisualStyleBackColor = true;
            chkDescripcion.CheckedChanged += chkDescripcion_CheckedChanged;
            // 
            // chkEstatus
            // 
            chkEstatus.AutoSize = true;
            chkEstatus.Font = new Font("Segoe UI", 10.8F);
            chkEstatus.Location = new Point(300, 168);
            chkEstatus.Name = "chkEstatus";
            chkEstatus.Size = new Size(90, 29);
            chkEstatus.TabIndex = 15;
            chkEstatus.Text = "Estatus";
            chkEstatus.UseVisualStyleBackColor = true;
            chkEstatus.CheckedChanged += chkEstatus_CheckedChanged;
            // 
            // chkNombre
            // 
            chkNombre.AutoSize = true;
            chkNombre.Font = new Font("Segoe UI", 10.8F);
            chkNombre.Location = new Point(300, 138);
            chkNombre.Name = "chkNombre";
            chkNombre.Size = new Size(100, 29);
            chkNombre.TabIndex = 14;
            chkNombre.Text = "Nombre";
            chkNombre.UseVisualStyleBackColor = true;
            chkNombre.CheckedChanged += chkNombre_CheckedChanged;
            // 
            // txtNewDescripcion
            // 
            txtNewDescripcion.Location = new Point(511, 240);
            txtNewDescripcion.Name = "txtNewDescripcion";
            txtNewDescripcion.Size = new Size(125, 27);
            txtNewDescripcion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 207);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 12;
            label4.Text = "Nueva Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 102);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 11;
            label3.Text = "Nuevo Nombre:";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.BackColor = SystemColors.Menu;
            txtNuevoNombre.Location = new Point(511, 146);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(125, 27);
            txtNuevoNombre.TabIndex = 10;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightGray;
            tabPage3.Controls.Add(lblEliminar);
            tabPage3.Controls.Add(txtEliminar);
            tabPage3.Controls.Add(btnEliminar);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(735, 403);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminar";
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Location = new Point(66, 67);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(169, 20);
            lblEliminar.TabIndex = 11;
            lblEliminar.Text = "Lista que desea eliminar";
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(66, 118);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(271, 27);
            txtEliminar.TabIndex = 10;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightGray;
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(chkBuscarTodas);
            tabPage4.Controls.Add(txtBuscar);
            tabPage4.Controls.Add(listViewResultados);
            tabPage4.Controls.Add(btnBuscar);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(735, 403);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Buscar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 48);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 12;
            label6.Text = "Busqueda:";
            // 
            // chkBuscarTodas
            // 
            chkBuscarTodas.AutoSize = true;
            chkBuscarTodas.Location = new Point(67, 199);
            chkBuscarTodas.Name = "chkBuscarTodas";
            chkBuscarTodas.Size = new Size(121, 24);
            chkBuscarTodas.TabIndex = 11;
            chkBuscarTodas.Text = "MostrarTodas";
            chkBuscarTodas.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(63, 89);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 10;
            // 
            // listViewResultados
            // 
            listViewResultados.Location = new Point(271, 26);
            listViewResultados.Name = "listViewResultados";
            listViewResultados.Size = new Size(420, 335);
            listViewResultados.TabIndex = 9;
            listViewResultados.UseCompatibleStateImageBehavior = false;
            listViewResultados.View = View.Details;
            // 
            // ListaDifusion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(881, 501);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListaDifusion";
            Text = "ListaDifusion";
            Load += ListaDifusion_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreLista;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtNuevoNombre;
        private ListView listViewResultados;
        private Label label3;
        private Label lblEliminar;
        private TextBox txtEliminar;
        private TextBox txtNewDescripcion;
        private Label label4;
        private CheckBox chkDescripcion;
        private CheckBox chkEstatus;
        private CheckBox chkNombre;
        private TabPage tabPage4;
        private TextBox txtmodificar;
        private Label label5;
        private Label lblEstatus;
        private TextBox txtBuscar;
        private Label label6;
        private CheckBox chkBuscarTodas;
    }
}