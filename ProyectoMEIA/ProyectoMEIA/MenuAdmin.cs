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
                string backupDescriptor = "C:\\MEIA\\desc_bitacora_backup.txt";
                string usuarioDescriptor = "C:\\MEIA\\desc_user.txt";

                if (Directory.Exists(directorioMEIA))
                {
                    // Abrir el diálogo para seleccionar la ubicación del respaldo
                    FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaDestino = Path.Combine(folderDialog.SelectedPath, "MEIA_Backup");

                        if (!Directory.Exists(rutaDestino))
                        {
                            Directory.CreateDirectory(rutaDestino);
                        }

                        // Copiar todos los archivos y directorios
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

                        // Registrar en la bitácora del backup (como apilo)
                        string fechaOperacion = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        string rutaCompleta = Path.GetFullPath(rutaDestino);
                        string usuarioBackup = lUsuario.Text;
                        string nuevaEntradaBitacora = $"{rutaCompleta};{usuarioBackup};{fechaOperacion}\n";

                        if (File.Exists(archivo_bitacora))
                        {
                            // Leer las entradas anteriores
                            string contenidoAnterior = File.ReadAllText(archivo_bitacora);

                            // Crear la nueva entrada en el principio (como apilo)
                            string nuevoContenido = nuevaEntradaBitacora + contenidoAnterior;

                            // Sobrescribir el archivo con la nueva entrada en el tope
                            File.WriteAllText(archivo_bitacora, nuevoContenido);
                        }
                        else
                        {
                            // Si el archivo no existe, simplemente crearlo con la nueva entrada
                            File.WriteAllText(archivo_bitacora, nuevaEntradaBitacora);
                        }

                        // Actualizar o crear el archivo descriptor del backup
                        if (File.Exists(backupDescriptor))
                        {
                            // Leer el archivo descriptor actual
                            string[] lineas = File.ReadAllLines(backupDescriptor);
                            int totalRegistros = lineas.Length;

                            // Crear la nueva entrada con los datos modificados
                            string nuevaEntradaDescriptor = $"bitacora_backup;{DateTime.Now:dd/MM/yyyy};{lUsuario.Text};{DateTime.Now:dd/MM/yyyy HH:mm:ss};{lUsuario.Text};{totalRegistros + 1};";

                            // Sobrescribir el contenido del archivo descriptor
                            File.WriteAllText(backupDescriptor, nuevaEntradaDescriptor);
                        }
                        else
                        {
                            // Crear el archivo descriptor si no existe con la entrada inicial
                            string nuevaEntradaDescriptor = $"bitacora_backup;{DateTime.Now:dd/MM/yyyy};{lUsuario.Text};{DateTime.Now:dd/MM/yyyy HH:mm:ss};{lUsuario.Text};1;";
                            File.WriteAllText(backupDescriptor, nuevaEntradaDescriptor);
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

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarUsuario buscar = new BuscarUsuario(lUsuario.Text, true);
            MostrarFormPanel(buscar);
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            string nombreU = lUsuario.Text;
            ActualizacionContraseña actualizar_contra = new ActualizacionContraseña(nombreU);
            MostrarFormPanel(actualizar_contra);
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            string nombreU = lUsuario.Text;
            ActualizacionUsuario actualizar_datos = new ActualizacionUsuario(nombreU, this);
            MostrarFormPanel(actualizar_datos);
        }
        public void ActualizarTelefonoEtiqueta(string nuevoTelefono)
        {
            lTelefono.Text = nuevoTelefono;
        }

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario(null, true); // true indica que es desde MenuAdmin
            nuevo.Show();
        }

        private void btn_Contacto_Click(object sender, EventArgs e)
        {
            FormContactos contactosForm = new FormContactos(lUsuario.Text, "", "", lUsuario.Text); // Usuario actual logeado
            MostrarFormPanel(contactosForm);
        }
    }
}
