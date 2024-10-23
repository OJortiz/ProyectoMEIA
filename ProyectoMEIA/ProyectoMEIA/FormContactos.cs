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
    public partial class FormContactos : Form
    {

        public FormContactos(string usuario, string nombre, string apellido)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtNombre.Text = nombre + " " + apellido;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormContactos_Load(object sender, EventArgs e)
        {

        }
    }
}
