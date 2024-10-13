using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoMEIA
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario(string usuario, string nombre, string apellido, int telefono)
        {
            InitializeComponent();

            lUsuario.Text = usuario;
            lnombre.Text = nombre + " " + apellido;
            lRol.Text = "Usuario";
            lTelefono.Text = telefono.ToString();
        }
        //La funcion MostrarFormPanel a
        private void MostrarFormPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelOpciones.Controls.Clear();
            panelOpciones.Controls.Add(form);
            panelOpciones.Tag = form;
            form.Show();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            ActualizacionUsuario actualizar_datos = new ActualizacionUsuario();
            MostrarFormPanel(actualizar_datos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizacionContraseña actualizar_contra = new ActualizacionContraseña();
            MostrarFormPanel(actualizar_contra);
        }
    }
}
