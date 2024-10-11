using System.Text;
using System.Security.Cryptography;

namespace ProyectoMEIA
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txt_username.Text;
            string passwordIngresado = txt_password.Text;

            // Verificar si los campos no están vacíos
            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(passwordIngresado))
            {
                MessageBox.Show("Por favor, ingrese tanto el usuario como la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ruta del archivo de usuarios
            string rutaArchivoUsuarios = @"C:\MEIA\user.txt";

            // Verificar si el archivo de usuarios existe
            if (!File.Exists(rutaArchivoUsuarios))
            {
                MessageBox.Show("El archivo de usuarios no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cifrar la contraseña ingresada utilizando SHA-256
            string passwordCifrada = CifrarSHA256(passwordIngresado);

            string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
            bool usuarioEncontrado = false;
            foreach (string linea in lineas)
            {
                // Separar los campos por el delimitador ";"
                string[] campos = linea.Split(';');

                if (campos.Length == 8) // Asegurarse de que haya el número correcto de campos
                {
                    string usuario = campos[0];
                    string passwordAlmacenada = campos[3];
                    int estatus = int.Parse(campos[7]);

                    // Verificar si el usuario existe y está activo
                    if (usuario == usuarioIngresado && estatus == 1)
                    {
                        // Verificar la contraseña cifrada
                        if (passwordAlmacenada == passwordCifrada)
                        {
                            usuarioEncontrado = true;
                            MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Aquí sigue si el login es exitoso, dirige a la pantalla principal
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario no encontrado o inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CifrarSHA256(string input)
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

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            nuevo.Show();
        }
    }
}
