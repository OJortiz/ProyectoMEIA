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
    public partial class BuscarUsuario : Form
    {
        public string ruta_user = "C:\\MEIA\\user.txt";
        private bool existeUsuario = false;
        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(ruta_user))
                {
                    MessageBox.Show("El archivo de usuarios no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] lineas = File.ReadAllLines(ruta_user);
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(';');

                    if (campos.Length == 8)
                    {
                        string usuario = campos[0];

                        if (usuario == txtUsuario.Text)
                        {
                            existeUsuario = true;
                            break;
                        }
                    }
                }
                if (existeUsuario)
                {
                    MessageBox.Show($"El usuario {txtUsuario.Text} si existe");
                }
                else
                {
                    MessageBox.Show($"No se encontro el usuario {txtUsuario.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al leer el archivo" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!existeUsuario)
                {
                    MessageBox.Show("Se debe buscar un usuario primero");
                    return;
                }

                if (!File.Exists(ruta_user))
                {
                    MessageBox.Show("No se encontro el archivo de usuarios");
                    return;
                }

                var confirmar = MessageBox.Show($"¿Está seguro de que desea dar de baja al usuario?",
                    "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    string[] lineas = File.ReadAllLines(ruta_user);
                    for (int i = 0; i < lineas.Length; i++)
                    {
                        string[] campos = lineas[i].Split(';');
                        if (campos[0] == txtUsuario.Text)
                        {
                            campos[7] = "0";
                            lineas[i] = string.Join(';', campos);
                            break;
                        }
                    }
                    File.WriteAllLines(ruta_user, lineas);
                    MessageBox.Show("Usuario dado de baja exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se realizo ninguna accion..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
            }
        }
    }
}
