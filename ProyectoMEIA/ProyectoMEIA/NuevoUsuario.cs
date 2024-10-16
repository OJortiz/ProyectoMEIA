using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProyectoMEIA
{
    public partial class NuevoUsuario : Form
    {
        private bool fueLlamadoDesdeAdmin;
        public string archivo_usuario = "C:\\MEIA\\user.txt";
        public string archivo_descriptor = "C:\\MEIA\\desc_user.txt";
        public NuevoUsuario(string nombreUser = null, bool esAdmin = false)
        {
            InitializeComponent();
            txtUsuario.Text = nombreUser;
            fueLlamadoDesdeAdmin = esAdmin;
            if (fueLlamadoDesdeAdmin)
            {
                btn_Login.Text = "Admin";
            }
        }
        public static void CrearDescriptorUsuario(string archivo_usuario, string archivo_descriptor, string nombreUsuario, string user)
        {
            int registrosActivos = 0, registrosInactivos = 0, totalRegistros = 0;

            if (File.Exists(archivo_usuario))
            {
                string[] lineas = File.ReadAllLines(archivo_usuario);
                foreach(var linea in lineas)
                {
                    string[] campos = linea.Split(';');
                    if (campos.Length == 8)
                    {
                        int estado = int.Parse(campos[7]);
                        if (estado == 1)
                        {
                            registrosActivos++;
                        }
                        else if (estado == 0)
                        {
                            registrosInactivos++;
                        }
                        totalRegistros++;
                    }
                }
            }

            DateTime fecha = DateTime.Now;
            string fechaFormateada = fecha.ToString("dd/MM/yyyy HH:mm:ss");

            try
            {
                using (StreamWriter sw = File.AppendText(archivo_descriptor))
                {
                    string nuevaLinea = $"{nombreUsuario};{fechaFormateada};{user};{fechaFormateada};{user};{totalRegistros};{registrosActivos};{registrosInactivos};{0}";
                    sw.WriteLine(nuevaLinea);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }
 
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string contra = txtPassword.Text.Trim();
            string fechaNacimiento = dtp_FechaNacimiento.Value.ToString("dd/MM/yyyy");
            string telefonoStr = txtTelefono.Text.Trim();
            int estatus = 1;

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("El campo de usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo de nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El campo de apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación del teléfono
            if (telefonoStr.Length != 8 || !telefonoStr.All(char.IsDigit))
            {
                MessageBox.Show("El número de teléfono debe ser numérico y tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir a entero después de la validación
            int telefono = Int32.Parse(telefonoStr);

            // Evaluar nivel de seguridad de la contraseña
            string nivelSeguridad = EvaluarPassword(contra);
            if (nivelSeguridad == "baja")
            {
                MessageBox.Show("La contraseña es de nivel bajo. No se puede usar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show($"Nivel de seguridad de la contraseña: {nivelSeguridad}.", "Seguridad de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Validaciones de longitud máxima
            if (usuario.Length > 20)
            {
                MessageBox.Show("El usuario tiene que ser de 20 caracteres máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nombre.Length > 30)
            {
                MessageBox.Show("El nombre tiene que ser de 30 caracteres máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (apellido.Length > 30)
            {
                MessageBox.Show("El apellido tiene que ser de 30 caracteres máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contra.Length > 15)
            {
                MessageBox.Show("La contraseña tiene que ser de 15 caracteres máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el usuario ya existe
            if (File.Exists(archivo_usuario))
            {
                string[] lineas = File.ReadAllLines(archivo_usuario);
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(';');
                    if (campos[0] == usuario)
                    {
                        MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Cifrar la contraseña
            string contraCifrada = CifrarSHA256(contra);

            // Asignar rol (el primer usuario será administrador)
            int rol = 0;
            if (!File.Exists(archivo_usuario) || new FileInfo(archivo_usuario).Length == 0)
            {
                rol = 1; // Primer usuario será administrador
            }

            // Crear el nuevo registro
            string nuevoRegistro = $"{usuario};{nombre};{apellido};{contraCifrada};{rol};{fechaNacimiento};{telefono};{estatus}";

            // Escribir el nuevo usuario en el archivo
            using (StreamWriter sw = File.AppendText(archivo_usuario))
            {
                sw.WriteLine(nuevoRegistro);
            }

            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CrearDescriptorUsuario(archivo_usuario, archivo_descriptor, nombre + apellido, usuario);
            // Limpiar campos después de registrar
            txtUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtPassword.Clear();
            txtTelefono.Clear();


        }

        public string EvaluarPassword(string password)
        {
            int puntuacion = 0;

            if (password.Length >= 8)
                puntuacion++;
            if (password.Length >= 10)
                puntuacion++;

            if (password.Any(char.IsUpper))
                puntuacion++;
            if (password.Any(char.IsLower))
                puntuacion++;
            if (password.Any(char.IsDigit))
                puntuacion++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
                puntuacion++;

            if (puntuacion <= 2)
                return "baja";
            if (puntuacion == 3 || puntuacion == 4)
                return "media";

            return "alta";
        }

        public string CifrarSHA256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (fueLlamadoDesdeAdmin)
            {
                var datosAdmin = ObtenerDatosAdmin();
                if (datosAdmin.usuario != null)
                {
                    MenuAdmin adminForm = new MenuAdmin(datosAdmin.usuario, datosAdmin.nombre, datosAdmin.apellido, datosAdmin.telefono);

                    this.Close();
                                 
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos del administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Form_Main loginForm = new Form_Main();
                loginForm.Show();

                this.Close();
            }
        }

        private (string usuario, string nombre, string apellido, int telefono) ObtenerDatosAdmin()
        {
            string[] lineas = File.ReadAllLines(archivo_usuario);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(';');
                if (campos.Length == 8 && campos[4] == "1")
                {
                    string usuario = campos[0];
                    string nombre = campos[1];
                    string apellido = campos[2];
                    int telefono = int.Parse(campos[6]);
                    return (usuario, nombre, apellido, telefono);
                }
            }

            return (null, null, null, 0);
        }

    }
}
