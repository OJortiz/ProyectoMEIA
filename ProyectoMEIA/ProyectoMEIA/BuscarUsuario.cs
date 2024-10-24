using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoMEIA
{
    public partial class BuscarUsuario : Form
    {
        public string ruta_user = "C:\\MEIA\\user.txt";
        string username;
 
        public BuscarUsuario(string usuario, bool admin)
        {
            InitializeComponent();
            username = usuario;
            if (admin == false)
            {
                btn_deshabilitar.Visible = false;
                btn_buscar.Location = new Point(200 ,188);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool existeUsuario = false;
                string nombre = "", apellido = "", usuario = "";

                if (!File.Exists(ruta_user))
                {
                    MessageBox.Show("El archivo de usuarios no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lineas = File.ReadAllLines(ruta_user);

                if (lineas.Length == 0)
                {
                    MessageBox.Show("El archivo de usuarios está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(';');

                    if (campos.Length == 8)
                    {
                        usuario = campos[0];
                        nombre = campos[1];
                        apellido = campos[2];
                        if (usuario == txtUsuario.Text)
                        {
                            existeUsuario = true;
                            break;
                        }
                    }
                }

                if (existeUsuario)
                {
                    MessageBox.Show($"El usuario {txtUsuario.Text} sí existe", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var respuesta = MessageBox.Show("¿Desea Agregar este Usuario a sus Contactos?",
                                     "Confirmación",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        FormContactos contactos = new FormContactos(usuario, nombre, apellido, username);
                        contactos.Show();
                    }
                    else
                    {
                        MessageBox.Show("Permanecerás en la misma ventana");
                    }
                }

                else
                {
                    MessageBox.Show($"No se encontró el usuario {txtUsuario.Text}", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta_user = @"C:\MEIA\user.txt";
                if (!File.Exists(ruta_user))
                {
                    MessageBox.Show("El archivo de usuarios no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lineas = File.ReadAllLines(ruta_user);
                bool usuarioEncontrado = false;

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');

                    if (campos.Length == 8)
                    {
                        string usuario = campos[0];
                        int estatus = int.Parse(campos[7]);

                        if (usuario == txtUsuario.Text)
                        {
                            usuarioEncontrado = true;

                            if (usuario == username)
                            {
                                MessageBox.Show("No es posible desactivar una cuenta de administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (estatus == 0)
                            {
                                MessageBox.Show("Este usuario ya está deshabilitado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            campos[7] = "0";
                            lineas[i] = string.Join(";", campos);

                            File.WriteAllLines(ruta_user, lineas);
                            MessageBox.Show("Usuario deshabilitado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                if (!usuarioEncontrado)
                {
                    MessageBox.Show("No se encontró el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al procesar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
