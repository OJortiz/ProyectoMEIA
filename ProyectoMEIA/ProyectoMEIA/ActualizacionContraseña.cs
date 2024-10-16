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
    public partial class ActualizacionContraseña : Form
    {
        string username;

        public ActualizacionContraseña(string usuario)
        {
            InitializeComponent();
            username = usuario;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            NuevoUsuario newUser = new NuevoUsuario();

            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtContraActual.Text))
            {
                MessageBox.Show("Por favor, ingrese su contraseña actual.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNuevaContra.Text))
            {
                MessageBox.Show("Por favor, ingrese su nueva contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmarContra.Text))
            {
                MessageBox.Show("Por favor, confirme su nueva contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contraseñaActual = txtContraActual.Text;
            string nuevaContraseña = txtNuevaContra.Text;
            string confirmarNuevaContraseña = txtConfirmarContra.Text;

            // Verificar que la contraseña nueva y la confirmación coinciden
            if (nuevaContraseña != confirmarNuevaContraseña)
            {
                MessageBox.Show("La nueva contraseña y su confirmación no coinciden. Intente de nuevo.", "Error de coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que la contraseña actual sea correcta
            string rutaArchivoUsuarios = @"C:\MEIA\user.txt";
            if (File.Exists(rutaArchivoUsuarios))
            {
                string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
                bool contraseñaCorrecta = false;

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');
                    if (campos[0] == username)
                    {
                        string contraseñaCifradaActual = newUser.CifrarSHA256(contraseñaActual);
                        if (campos[3] == contraseñaCifradaActual)
                        {
                            contraseñaCorrecta = true;
                            break;
                        }
                    }
                }

                if (!contraseñaCorrecta)
                {
                    MessageBox.Show("La contraseña actual es incorrecta.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Verificar nivel de seguridad de la nueva contraseña
            string nivelSeguridad = newUser.EvaluarPassword(nuevaContraseña);
            if (nivelSeguridad == "baja")
            {
                MessageBox.Show("La contraseña es de seguridad baja. Intente con una contraseña más segura.", "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cifrar la nueva contraseña
            string nuevaContraseñaCifrada = newUser.CifrarSHA256(nuevaContraseña);

            // Actualizar la contraseña en el archivo
            if (File.Exists(rutaArchivoUsuarios))
            {
                string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');
                    if (campos[0] == username)
                    {
                        // Actualizar la contraseña en el archivo
                        campos[3] = nuevaContraseñaCifrada;
                        lineas[i] = string.Join(";", campos);
                        break;
                    }
                }
                File.WriteAllLines(rutaArchivoUsuarios, lineas);
                MessageBox.Show("Contraseña actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El archivo de usuarios no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
