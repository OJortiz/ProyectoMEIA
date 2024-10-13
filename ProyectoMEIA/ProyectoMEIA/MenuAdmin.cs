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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin(string usuario, string nombre, string apellido, int telefono)
        {
            InitializeComponent();

            lUsuario.Text = usuario;
            lNombre.Text = nombre + " " + apellido;
            lRol.Text = "Administrador";
            lTelefono.Text = telefono.ToString();
        }
    }
}
