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
        public string archivo_usuario = "C:\\MEIA\\user.txt";
        public string archivo_bitacora = "C:\\MEIA\\bitacora_backup.txt";
        public MenuAdmin(string usuario, string nombre, string apellido, int telefono)
        {
            InitializeComponent();

            lUsuario.Text = usuario;
            lNombre.Text = nombre + " " + apellido;
            lRol.Text = "Administrador";
            lTelefono.Text = telefono.ToString();
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

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(archivo_usuario))
                {
                    string [] contenido_usuarios = File.ReadAllLines(archivo_usuario);
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string archivo_backup = saveFileDialog1.FileName;
                        File.WriteAllLines(archivo_backup, contenido_usuarios);
                        string fecha_operacion = DateTime.Now.ToString("dd/MM/yyyy");

                        string entradaArchivo = "";
                        foreach(string linea in contenido_usuarios)
                        {
                            string [] campos = linea.Split(';');

                            if (campos.Length == 8)
                            {
                                string usuario = campos[0];
                                entradaArchivo += $"{archivo_backup};{usuario};{fecha_operacion}\n";
                            }
                        }
                        string informacionActual = "";
                        if (File.Exists(archivo_bitacora))
                        {
                            informacionActual = File.ReadAllText(archivo_bitacora);
                        }
                        entradaArchivo += informacionActual;
                        File.WriteAllText(archivo_bitacora, entradaArchivo);

                        MessageBox.Show("Copia de Seguridad realizada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Operacion Cancelada");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ningun archivo de usuarios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los archivos: " + ex.Message);
            }
        }
    }
}
