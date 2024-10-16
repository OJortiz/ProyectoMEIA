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
        Form formMenu; // Referencia al formulario principal

        public ActualizacionUsuario(string usuario, Form form)
        {
            InitializeComponent();

            username = usuario;
            formMenu = form;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados
            string nuevoTelefono = txtTelefono.Text.Trim();
            DateTime fechaSeleccionada = dtp_NuevaFecha.Value.Date; // Solo la parte de la fecha
            DateTime fechaActual = DateTime.Today; // Solo la fecha de hoy sin horas

            // Ruta del archivo de usuarios
            string rutaArchivoUsuarios = @"C:\MEIA\user.txt";

            // Validar si no se ha ingresado ni teléfono ni una nueva fecha de nacimiento
            if (string.IsNullOrEmpty(nuevoTelefono) && fechaSeleccionada == fechaActual)
            {
                MessageBox.Show("Debe ingresar al menos un dato para actualizar (teléfono o fecha de nacimiento).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el número de teléfono si el campo no está vacío
            if (!string.IsNullOrEmpty(nuevoTelefono))
            {
                if (nuevoTelefono.Length != 8 || !nuevoTelefono.All(char.IsDigit))
                {
                    MessageBox.Show("El número de teléfono debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Actualizar los datos en el archivo de usuarios
            if (File.Exists(rutaArchivoUsuarios))
            {
                string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');
                    if (campos[0] == username) // Verificamos el usuario actual
                    {
                        // Actualizar el teléfono solo si se ingresó un nuevo número
                        if (!string.IsNullOrEmpty(nuevoTelefono))
                        {
                            campos[6] = nuevoTelefono; // Índice del teléfono
                        }

                        // Actualizar la fecha de nacimiento solo si la fecha seleccionada es diferente a la actual
                        if (fechaSeleccionada != fechaActual)
                        {
                            campos[5] = fechaSeleccionada.ToString("dd/MM/yyyy"); // Índice de la fecha de nacimiento
                        }

                        lineas[i] = string.Join(";", campos); // Actualizar la línea completa
                        break;
                    }
                }

                // Guardar los cambios en el archivo
                File.WriteAllLines(rutaArchivoUsuarios, lineas);

                // Actualizar la etiqueta en el formulario principal si se cambió el teléfono
                if (!string.IsNullOrEmpty(nuevoTelefono))
                {
                    if (formMenu is MenuUsuario menuUsuario)
                    {
                        menuUsuario.ActualizarTelefonoEtiqueta(nuevoTelefono); // Llamada al método en MenuUsuario
                    }
                    else if (formMenu is MenuAdmin menuAdmin)
                    {
                        menuAdmin.ActualizarTelefonoEtiqueta(nuevoTelefono); // Llamada al método en MenuAdmin
                    }
                }

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
