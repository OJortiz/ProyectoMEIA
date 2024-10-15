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
                string directorioMEIA = @"C:\MEIA";

                if (Directory.Exists(directorioMEIA))
                {
                    // Abrir el diálogo para seleccionar la ubicación del respaldo
                    FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada por el usuario
                        string rutaDestino = Path.Combine(folderDialog.SelectedPath, "MEIA_Backup");

                        if (!Directory.Exists(rutaDestino))
                        {
                            Directory.CreateDirectory(rutaDestino);
                        }

                        // Copiar todos los archivos y subdirectorios de MEIA al nuevo directorio de respaldo
                        foreach (string archivo in Directory.GetFiles(directorioMEIA))
                        {
                            string nombreArchivo = Path.GetFileName(archivo);
                            string destinoArchivo = Path.Combine(rutaDestino, nombreArchivo);
                            File.Copy(archivo, destinoArchivo, true);
                        }

                        foreach (string directorio in Directory.GetDirectories(directorioMEIA))
                        {
                            string nombreDirectorio = Path.GetFileName(directorio);
                            string destinoDirectorio = Path.Combine(rutaDestino, nombreDirectorio);
                            DirectoryCopy(directorio, destinoDirectorio);
                        }

                        // Registrar la operación en la bitácora
                        string fechaOperacion = DateTime.Now.ToString("dd/MM/yyyy");
                        string rutaCompleta = Path.GetFullPath(rutaDestino);
                        string usuarioBackup = lUsuario.Text;

                        string entradaBitacora = $"{rutaCompleta};{usuarioBackup};{fechaOperacion}\n";

                        if (File.Exists(archivo_bitacora))
                        {
                            File.AppendAllText(archivo_bitacora, entradaBitacora);
                        }
                        else
                        {
                            File.WriteAllText(archivo_bitacora, entradaBitacora);
                        }

                        MessageBox.Show("Copia de seguridad realizada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el directorio MEIA.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los archivos: " + ex.Message);
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Si el directorio de destino no existe, crearlo
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Copiar todos los archivos del directorio
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // Copiar todos los subdirectorios recursivamente
            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, tempPath);
            }
        }

    }
}
