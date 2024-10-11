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

            // Verificar si los campos no est�n vac�os
            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(passwordIngresado))
            {
                MessageBox.Show("Por favor, ingrese tanto el usuario como la contrase�a.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
            bool usuarioEncontrado = false;
            foreach (string linea in lineas)
            {
                // Separar los campos por el delimitador ";"
                string[] campos = linea.Split(';');

                if (campos.Length == 8) // Asegurarse de que haya el n�mero correcto de campos
                {
                    string usuario = campos[0];
                    string password = campos[3];
                    int estatus = int.Parse(campos[7]);

                    // Verificar si el usuario existe y est� activo
                    if (usuario == usuarioIngresado && estatus == 1)
                    {
                        // Verificar la contrase�a 
                        if (password == passwordIngresado)
                        {
                            usuarioEncontrado = true;
                            MessageBox.Show("Inicio de sesi�n exitoso.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Aqu� sigue si el login es exitoso, dirige a la pantalla principal
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Contrase�a incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            nuevo.Show();
        }
    }
}
