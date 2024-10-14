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
    public partial class ActualizacionUsuario : Form
    {
        string username;
        MenuUsuario formMenu; // Referencia al formulario principal

        public ActualizacionUsuario(string usuario, MenuUsuario form)
        {
            InitializeComponent();

            username = usuario;
            formMenu = form;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados
            string nuevoTelefono = txtTelefono.Text;
            DateTime nuevaFechaNacimiento = dtp_NuevaFecha.Value;

            // Validar el número de teléfono (debe tener 8 dígitos)
            if (nuevoTelefono.Length != 8 || !nuevoTelefono.All(char.IsDigit))
            {
                MessageBox.Show("El número de teléfono debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar los datos en el archivo de usuarios
            string rutaArchivoUsuarios = @"C:\MEIA\user.txt";
            if (File.Exists(rutaArchivoUsuarios))
            {
                string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');
                    if (campos[0] == username) // Verificamos el usuario actual
                    {
                        // Actualizar el número de teléfono y la fecha de nacimiento
                        campos[6] = nuevoTelefono; // Índice del teléfono
                        campos[5] = nuevaFechaNacimiento.ToString("dd/MM/yyyy"); // Índice de la fecha de nacimiento
                        lineas[i] = string.Join(";", campos);
                        break;
                    }
                }

                // Guardar los cambios en el archivo
                File.WriteAllLines(rutaArchivoUsuarios, lineas);
                // Actualizar la etiqueta en el formulario principal
                formMenu.ActualizarTelefonoEtiqueta(nuevoTelefono); // Llamada al método en el formulario principal
                MessageBox.Show("Datos actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
