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
    public partial class ListaDifusion : Form
    {
        private string usuarioActual;

        public ListaDifusion(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            // Configuración de columnas en el ListView para buscar las listas de difusion
            listViewResultados.View = View.Details;
            listViewResultados.Columns.Clear();
            listViewResultados.Columns.Add("Nombre Lista", 120);
            listViewResultados.Columns.Add("Usuario", 100);
            listViewResultados.Columns.Add("Descripción", 150);
            listViewResultados.Columns.Add("Número de Usuarios", 120);
            listViewResultados.Columns.Add("Fecha de Creación", 120);
            listViewResultados.Columns.Add("Estatus", 80);
            //Configuracion de columnas en el ListView para buscar usuarios en las listas
            listViewUsuarios.View = View.Details;
            listViewUsuarios.Columns.Clear();
            listViewUsuarios.Columns.Add("Nombre Lista", 120);
            listViewUsuarios.Columns.Add("Usuario", 100);
            listViewUsuarios.Columns.Add("Descripcion", 150);
            listViewUsuarios.Columns.Add("Usuario Asociado", 120);
            listViewUsuarios.Columns.Add("Estatus", 80);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rutaLista = @"C:/MEIA/lista.txt";
            string nombreLista = txtNombreLista.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            DateTime fechaCreacion = DateTime.Now;
            int numeroUsuarios = 0;
            int estatus = 1;

            try
            {
                // Verificar si ya existe una lista con el mismo nombre para el usuario actual
                if (File.Exists(rutaLista))
                {
                    string[] lineas = File.ReadAllLines(rutaLista);
                    foreach (string linea in lineas)
                    {
                        string[] campos = linea.Split(';');
                        if (campos.Length >= 6)
                        {
                            string nombreExistente = campos[0];
                            string usuarioExistente = campos[1];

                            if (nombreExistente == nombreLista && usuarioExistente == usuarioActual)
                            {
                                MessageBox.Show("Ya existe una lista de difusión con este nombre para el usuario actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }

                // Si no existe, agrega la nueva lista al archivo
                using (StreamWriter sw = File.AppendText(rutaLista))
                {
                    string nuevaEntrada = $"{nombreLista};{usuarioActual};{descripcion};{numeroUsuarios};{fechaCreacion:dd/MM/yyyy HH:mm:ss};{estatus}";
                    sw.WriteLine(nuevaEntrada);
                }

                MessageBox.Show("Lista de difusión agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la lista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rutaLista = @"C:/MEIA/lista.txt";
            string terminoBusqueda = txtBuscar.Text.Trim();
            bool buscarTodas = chkBuscarTodas.Checked;

            listViewResultados.Items.Clear();

            if (!File.Exists(rutaLista))
            {
                MessageBox.Show("El archivo de listas de difusión no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(terminoBusqueda) && !buscarTodas)
            {
                MessageBox.Show("Ingrese un término de búsqueda o marque la opción de buscar todas las listas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lineas = File.ReadAllLines(rutaLista);
            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(';');
                string nombreLista = campos[0];
                string usuarioLista = campos[1];
                string descripcion = campos[2];
                int numeroUsuarios = int.Parse(campos[3]);
                DateTime fechaCreacion = DateTime.Parse(campos[4]);
                bool estatus = campos[5] == "1";

                if ((buscarTodas || nombreLista.Contains(terminoBusqueda)) && usuarioLista == usuarioActual)
                {
                    ListViewItem item = new ListViewItem(nombreLista);
                    item.SubItems.Add(usuarioLista);
                    item.SubItems.Add(descripcion);
                    item.SubItems.Add(numeroUsuarios.ToString());
                    item.SubItems.Add(fechaCreacion.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(estatus ? "Activo" : "Inactivo");

                    listViewResultados.Items.Add(item);
                }
            }

            if (listViewResultados.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron listas que coincidan con la búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string rutaListas = @"C:\MEIA\lista.txt";
            string rutaIndice = @"C:\MEIA\indice_lista_usuario.txt";
            string rutaBloque = @"C:\MEIA\bloque_lista_usuario.txt";
            string nombreLista = txtmodificar.Text;

            if (!chkNombre.Checked && !chkDescripcion.Checked && !chkEstatus.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos una opción para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(rutaListas))
            {
                MessageBox.Show("El archivo de listas no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lineas = File.ReadAllLines(rutaListas);
            bool listaEncontrada = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');
                if (campos.Length == 6 && campos[0] == nombreLista && campos[1] == usuarioActual)
                {
                    listaEncontrada = true;
                    lblEstatus.Text = campos[5] == "1" ? "Activo" : "Inactivo";
                    lblEstatus.ForeColor = campos[5] == "1" ? Color.Green : Color.Red;
                    lblEstatus.Font = new Font(lblEstatus.Font, FontStyle.Bold);

                    if (chkNombre.Checked && !string.IsNullOrWhiteSpace(txtNuevoNombre.Text))
                    {
                        campos[0] = txtNuevoNombre.Text;
                    }
                    if (chkDescripcion.Checked && !string.IsNullOrWhiteSpace(txtNewDescripcion.Text))
                    {
                        campos[2] = txtNewDescripcion.Text;
                    }
                    if (chkEstatus.Checked)
                    {
                        campos[5] = campos[5] == "1" ? "0" : "1";
                        lblEstatus.Text = campos[5] == "1" ? "Activo" : "Inactivo";
                        lblEstatus.ForeColor = campos[5] == "1" ? Color.Green : Color.Red;
                    }

                    lineas[i] = string.Join(";", campos);
                    break;
                }
            }

            File.WriteAllLines(rutaListas, lineas);

            if (File.Exists(rutaIndice))
            {
                string[] lineasIndice = File.ReadAllLines(rutaIndice);
                for (int i = 0; i < lineasIndice.Length; i++)
                {
                    string[] camposIndice = lineasIndice[i].Split(';');
                    if (camposIndice.Length == 7 && camposIndice[2] == nombreLista && camposIndice[3] == usuarioActual)
                    {
                        listaEncontrada = true;
                        if (chkNombre.Checked && !string.IsNullOrWhiteSpace(txtNuevoNombre.Text))
                        {
                            camposIndice[2] = txtNuevoNombre.Text;
                        }
                        if (chkEstatus.Checked)
                        {
                            camposIndice[6] = camposIndice[6] == "1" ? "0" : "1";
                            lblEstatus.Text = camposIndice[6] == "1" ? "Activo" : "Inactivo";
                            lblEstatus.ForeColor = camposIndice[6] == "1" ? Color.Green : Color.Red;
                        }

                        lineasIndice[i] = string.Join(";", camposIndice);
                        break;
                    }
                }
                File.WriteAllLines(rutaIndice, lineasIndice);
            }

            if (File.Exists(rutaBloque))
            {
                string[] lineasBloque = File.ReadAllLines(rutaBloque);
                for (int i = 0; i < lineasBloque.Length; i++)
                {
                    string[] camposBloque = lineasBloque[i].Split(';');
                    if (camposBloque.Length == 6 && camposBloque[0] == nombreLista && camposBloque[1] == usuarioActual)
                    {
                        listaEncontrada = true;
                        if (chkNombre.Checked && !string.IsNullOrWhiteSpace(txtNuevoNombre.Text))
                        {
                            camposBloque[0] = txtNuevoNombre.Text;
                        }
                        if (chkDescripcion.Checked && !string.IsNullOrWhiteSpace(txtNewDescripcion.Text))
                        {
                            camposBloque[3] = txtNewDescripcion.Text;
                        }
                        if (chkEstatus.Checked)
                        {
                            camposBloque[5] = camposBloque[5] == "1" ? "0" : "1";
                            lblEstatus.Text = camposBloque[5] == "1" ? "Activo" : "Inactivo";
                            lblEstatus.ForeColor = camposBloque[5] == "1" ? Color.Green : Color.Red;
                        }

                        lineasBloque[i] = string.Join(";", camposBloque);
                        break;
                    }
                }
                File.WriteAllLines(rutaBloque, lineasBloque);
            }

            if (!listaEncontrada)
            {
                MessageBox.Show("La lista especificada no existe o no pertenece al usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEstatus.Text = "No encontrada";
                lblEstatus.ForeColor = Color.Red;
                return;
            }

            MessageBox.Show("Lista modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string rutaLista = @"C:/MEIA/lista.txt";
            string nombreLista = txtEliminar.Text.Trim();
            bool listaEliminada = false;

            if (File.Exists(rutaLista))
            {
                string[] lineas = File.ReadAllLines(rutaLista);

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');
                    if (campos.Length >= 6)
                    {
                        string nombreExistente = campos[0];
                        string usuarioExistente = campos[1];
                        int estatus = int.Parse(campos[5]);

                        if (nombreExistente == nombreLista && usuarioExistente == usuarioActual && estatus == 1)
                        {
                            campos[5] = "0";
                            lineas[i] = string.Join(";", campos);
                            listaEliminada = true;
                            break;
                        }
                    }
                }

                if (listaEliminada)
                {
                    File.WriteAllLines(rutaLista, lineas);
                    MessageBox.Show("Lista de difusión eliminada (estatus inactivo).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lista de difusión no encontrada o ya está inactiva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListaDifusion_Load(object sender, EventArgs e)
        {

        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNuevoNombre.Enabled = chkNombre.Checked;
        }

        private void chkEstatus_CheckedChanged(object sender, EventArgs e)
        {
            lblEstatus.Text = lblEstatus.Text == "Activo" ? "Inactivo" : "Activo";
            lblEstatus.ForeColor = lblEstatus.Text == "Activo" ? Color.Green : Color.Red;
        }

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            txtNewDescripcion.Enabled = chkDescripcion.Checked;
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            string rutaIndice = @"C:/MEIA/indice_lista_usuario.txt";
            string rutaBloque = @"C:/MEIA/bloque_lista_usuario.txt";
            string rutaLista = @"C:/MEIA/lista.txt";
            string nombreLista = txtNombreLista.Text.Trim();
            string usuarioAsociado = txtAgregarUsuario.Text.Trim();
            DateTime fechaCreacion = DateTime.Now;
            int estatus = 1;

            if (string.IsNullOrWhiteSpace(nombreLista) || string.IsNullOrWhiteSpace(usuarioAsociado))
            {
                MessageBox.Show("Debe agregar el nombre de la lista y el nombre del usuario a agregar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string descripcion = "";
                bool listaExiste = false;
                if (File.Exists(rutaLista))
                {
                    string[] lineasLista = File.ReadAllLines(rutaLista);
                    for (int i = 0; i < lineasLista.Length; i++)
                    {
                        string[] camposLista = lineasLista[i].Split(';');
                        if (camposLista.Length == 6 && camposLista[0] == nombreLista && camposLista[1] == usuarioActual && int.Parse(camposLista[5]) == estatus)
                        {
                            listaExiste = true;
                            descripcion = camposLista[2];
                            int numeroUsuarios = int.Parse(camposLista[3]) + 1;
                            camposLista[3] = numeroUsuarios.ToString();

                            lineasLista[i] = string.Join(";", camposLista);
                            File.WriteAllLines(rutaLista, lineasLista);
                            break;
                        }
                    }
                }

                if (!listaExiste)
                {
                    MessageBox.Show("La lista de difusion no existe");
                    return;
                }

                int registro = 1;
                double posicion = 0.0;
                if (File.Exists(rutaIndice))
                {
                    string[] lineasIndice = File.ReadAllLines(rutaIndice);
                    registro = lineasIndice.Length + 1;
                    posicion = lineasIndice.Length;

                    foreach (string linea in lineasIndice)
                    {
                        string[] campos = linea.Split(';');
                        if (campos.Length == 7)
                        {
                            string nombre_lista = campos[2];
                            string usuario = campos[3];
                            string usuario_asociado = campos[4];
                            int estatusExistente = int.Parse(campos[6]);

                            if (nombre_lista == nombreLista && usuario == usuarioActual && usuario_asociado == usuarioAsociado && estatusExistente == estatus)
                            {
                                MessageBox.Show("El usuario ya esta asociado a la lista de difusion");
                                return;
                            }
                        }
                    }
                }
                using (StreamWriter swIndice = File.AppendText(rutaIndice))
                {
                    string nuevaEntradaIndice = $"{registro};{posicion};{nombreLista};{usuarioActual};{usuarioAsociado};{fechaCreacion};{estatus}";
                    swIndice.WriteLine(nuevaEntradaIndice);
                }

                using (StreamWriter swBloque = File.AppendText(rutaBloque))
                {
                    string nuevaEntradaBloque = $"{nombreLista};{usuarioActual};{usuarioAsociado};{descripcion};{fechaCreacion};{estatus}";
                    swBloque.WriteLine(nuevaEntradaBloque);
                }

                MessageBox.Show($"Usuario {usuarioAsociado} agregado a la lista {nombreLista} exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            string rutaLista = @"C:\MEIA\lista.txt";
            string rutaIndice = @"C:\MEIA\indice_lista_usuario.txt";
            string rutaBloque = @"C:\MEIA\bloque_lista_usuario.txt";
            string nombreLista = txtEliminar.Text;
            string eliminarUsuario = txtEliminarUsuario.Text;

            if (string.IsNullOrWhiteSpace(nombreLista) || string.IsNullOrWhiteSpace(eliminarUsuario))
            {
                MessageBox.Show("Debe ingresar el nombre de la lista y el usuario que desea eliminar de ella", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool usuarioEncontrado = false;

            if (File.Exists(rutaIndice))
            {
                string[] lineasIndice = File.ReadAllLines(rutaIndice);
                for (int i = 0; i < lineasIndice.Length; i++)
                {
                    string[] camposIndice = lineasIndice[i].Split(';');
                    if (camposIndice.Length == 7 && camposIndice[2] == nombreLista && camposIndice[3] == usuarioActual && camposIndice[4] == eliminarUsuario)
                    {
                        camposIndice[6] = "0";
                        lineasIndice[i] = string.Join(";", camposIndice);
                        usuarioEncontrado = true;
                        break;
                    }
                }
                File.WriteAllLines(rutaIndice, lineasIndice);
            }

            if (File.Exists(rutaBloque))
            {
                string[] lineasBloque = File.ReadAllLines(rutaBloque);
                for (int i = 0; i < lineasBloque.Length; i++)
                {
                    string[] camposBloque = lineasBloque[i].Split(';');
                    if (camposBloque.Length == 6 && camposBloque[0] == nombreLista && camposBloque[1] == usuarioActual && camposBloque[2] == eliminarUsuario)
                    {
                        camposBloque[5] = "0";
                        lineasBloque[i] = string.Join(";", camposBloque);
                        usuarioEncontrado = true;
                        break;
                    }
                }
                File.WriteAllLines(rutaBloque, lineasBloque);
            }

            if (usuarioEncontrado && File.Exists(rutaLista))
            {
                string[] lineasLista = File.ReadAllLines(rutaLista);
                for (int i = 0; i < lineasLista.Length; i++)
                {
                    string[] camposLista = lineasLista[i].Split(";");
                    if (camposLista.Length == 6 && camposLista[0] == nombreLista && camposLista[1] == usuarioActual)
                    {
                        int numeroUsuarios = int.Parse(camposLista[3]);
                        if (numeroUsuarios > 0)
                        {
                            numeroUsuarios--;
                            camposLista[3] = numeroUsuarios.ToString();
                            lineasLista[i] = string.Join(";", camposLista);
                            File.WriteAllLines(rutaLista, lineasLista);
                        }
                        break;
                    }
                }
            }

            if (usuarioEncontrado)
            {
                MessageBox.Show("Usuario eliminado exitosamente de la lista.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el usuario especificado en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            string rutaBloque = @"C:/MEIA/bloque_lista_usuario.txt";
            string nombreLista = txtListaUsuario.Text;
            string usuarioBusqueda = txtBuscarUsuario.Text;
            listViewUsuarios.Items.Clear();

            if(!File.Exists(rutaBloque))
            {
                MessageBox.Show("El archivo de índice o bloque de usuarios no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(usuarioBusqueda) && string.IsNullOrWhiteSpace(nombreLista))
            {
                MessageBox.Show("No se puede buscar si no se ingresa la lista y el usuario deseado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lineasBloque = File.ReadAllLines(rutaBloque);
            foreach(string linea in lineasBloque)
            {
                string[] camposBloque = linea.Split(";");
                string nombreListaArchivo = camposBloque[0];
                string usuario = camposBloque[1];
                string usuarioAsociado = camposBloque[2];
                string descripcion = camposBloque[3];
                bool estatus = camposBloque[5] == "1";

                if (nombreListaArchivo == nombreLista && usuarioAsociado.Contains(usuarioBusqueda) && usuario == usuarioActual && estatus)
                {
                    ListViewItem item = new ListViewItem(nombreListaArchivo);
                    item.SubItems.Add(usuario);
                    item.SubItems.Add(descripcion);
                    item.SubItems.Add(usuarioAsociado);
                    item.SubItems.Add(estatus ? "Activo" : "Inactivo");

                    listViewUsuarios.Items.Add(item);
                }
            }

            if(listViewUsuarios.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda en la lista especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
