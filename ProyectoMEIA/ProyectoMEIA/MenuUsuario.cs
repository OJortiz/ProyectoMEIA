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
            string nombreU = lUsuario.Text;
            ActualizacionUsuario actualizar_datos = new ActualizacionUsuario(nombreU, this);
            MostrarFormPanel(actualizar_datos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreU = lUsuario.Text;
            ActualizacionContraseña actualizar_contra = new ActualizacionContraseña(nombreU);
            MostrarFormPanel(actualizar_contra);
        }

        // Método para actualizar la etiqueta del teléfono
        public void ActualizarTelefonoEtiqueta(string nuevoTelefono)
        {
            lTelefono.Text = nuevoTelefono;
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
                this.Close();
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
                string rutaDescriptorUsuarios = "C:\\MEIA\\desc_user.txt";
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
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Actualizar el archivo descriptor
                if (File.Exists(rutaDescriptorUsuarios))
                {
                    string[] lineasDesc = File.ReadAllLines(rutaDescriptorUsuarios);
                    DateTime fecha = DateTime.Now;
                    string fechaFormateada = fecha.ToString("dd/MM/yyyy HH:mm:ss");

                    for (int i = 0; i < lineasDesc.Length; i++)
                    {
                        string[] campos = lineasDesc[i].Split(';');
                        if (campos[0] == lUsuario.Text)
                        {
                            campos[3] = fechaFormateada;
                            campos[4] = lUsuario.Text;
                        }
                        campos[6] = (int.Parse(campos[6]) - 1).ToString();
                        campos[7] = (int.Parse(campos[7]) + 1).ToString();
                        lineasDesc[i] = string.Join(";", campos);
                    }
                    File.WriteAllLines(rutaDescriptorUsuarios, lineasDesc);
                }
                else
                {
                    MessageBox.Show("No se encontro el archivo descriptor de usuarios");
                }

                MessageBox.Show("Te has dado de baja con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Regresar a la pantalla de inicio
                this.Close();
                Form_Main loginForm = new Form_Main();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Continuarás con tu sesión actual.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            BuscarUsuario buscar = new BuscarUsuario(lUsuario.Text, false);
            MostrarFormPanel(buscar);
        }

        private void btn_ContactoOpciones_Click(object sender, EventArgs e)
        {
            FormContactos contactosForm = new FormContactos(lUsuario.Text, "", "", lUsuario.Text); // Usuario actual logeado
            MostrarFormPanel(contactosForm);
        }

        private void btnListaDifusion_Click(object sender, EventArgs e)
        {
            ListaDifusion listaDifusion = new ListaDifusion(lUsuario.Text);
            listaDifusion.Show();
            this.Close();
        }
    }
}
