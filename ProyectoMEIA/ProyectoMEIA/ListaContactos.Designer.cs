namespace ProyectoMEIA
{
    partial class ListaContactos
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
            listViewContactos = new ListView();
            SuspendLayout();
            // 
            // listViewContactos
            // 
            listViewContactos.Location = new Point(174, 39);
            listViewContactos.Name = "listViewContactos";
            listViewContactos.Size = new Size(444, 346);
            listViewContactos.TabIndex = 0;
            listViewContactos.UseCompatibleStateImageBehavior = false;
            // 
            // ListaContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewContactos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ListaContactos";
            Text = "ListaContactos";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewContactos;
    }
}