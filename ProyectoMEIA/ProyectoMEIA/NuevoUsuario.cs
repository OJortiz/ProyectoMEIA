using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProyectoMEIA
{
    public partial class NuevoUsuario : Form
    {
        public string archivo_usuario = "C:\\MEIA\\user.txt";
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contra = txtPassword.Text;
            int telefono = Int32.Parse(txtTelefono.Text);

            if (usuario.Length > 20)
            {
                MessageBox.Show("El usuario tiene que ser de 20 caracteres maximo");
            }
            if (nombre.Length > 30)
            {
                MessageBox.Show("El nombre tiene que ser de 30 caracteres maximo");
            }
            if (apellido.Length > 30)
            {
                MessageBox.Show("El apellido tiene que ser de 30 caracteres maximo");
            }
            if (contra.Length > 15)
            {
                MessageBox.Show("La contraseña tiene que ser de 15 caracteres maximo");
            }

        }
    }
}
