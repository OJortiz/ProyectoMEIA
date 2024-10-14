using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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
            string nombreU = lUsuario.Text;
            ActualizacionContraseña actualizar_contra = new ActualizacionContraseña(nombreU);
            MostrarFormPanel(actualizar_contra);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?",
                                         "Confirmación",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Regresar a la pantalla de inicio
                this.Hide();
                Form_Main loginForm = new Form_Main();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Permanecerás en la aplicación.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_darseBaja_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas darte de baja?",
                                         "Confirmación",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Actualizar el estatus del usuario a 0 (inactivo)
                string rutaArchivoUsuarios = @"C:\MEIA\user.txt";
                if (File.Exists(rutaArchivoUsuarios))
                {
                    string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
                    for (int i = 0; i < lineas.Length; i++)
                    {
                        string[] campos = lineas[i].Split(';');
                        if (campos[0] == lUsuario.Text) // Verificamos el usuario actual
                        {
                            campos[7] = "0"; // Cambiar estatus a inactivo
                            lineas[i] = string.Join(";", campos);
                            break;
                        }
                    }
                    File.WriteAllLines(rutaArchivoUsuarios, lineas);
                    MessageBox.Show("Te has dado de baja con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Regresar a la pantalla de inicio
                this.Hide();
                Form_Main loginForm = new Form_Main();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Continuarás con tu sesión actual.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
