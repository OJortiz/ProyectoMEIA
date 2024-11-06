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
    public partial class FormContactos : Form
    {
        private string usuarioActual; 

        public FormContactos(string usuario, string nombre, string apellido, string usuarioActual)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtNombre.Text = nombre + " " + apellido;
            this.usuarioActual = usuarioActual; 
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormContactos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rutaContactos = @"C:\MEIA\contactos.txt";
            string usuario = txtUsuario.Text;
            string contacto = txtNombre.Text;
            DateTime fechaTransaccion = DateTime.Now;

            if (string.IsNullOrWhiteSpace(contacto))
            {
                MessageBox.Show("Ingrese el nombre del usuario que desea agregar como contacto");
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("El nombre del usuario actual no puede ir vacio");
            }
            try
            {
                if (!File.Exists(rutaContactos))
                {
                    using (StreamWriter sw = File.CreateText(rutaContactos))
                    {
                        sw.WriteLine($"{usuarioActual};{usuario};{fechaTransaccion:dd/MM/yyyy HH:mm:ss};{usuarioActual};1");
                        MessageBox.Show("Contacto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                string[] lineas = File.ReadAllLines(rutaContactos);

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(';');
                    if (campos.Length == 5)
                    {
                        string usuarioExistente = campos[0]; // Usuario que agregó el contacto
                        string contactoExistente = campos[1]; // Contacto agregado
                        int estatus = int.Parse(campos[4]);

                        if (usuarioExistente == usuarioActual && contactoExistente == usuario && estatus == 1)
                        {
                            MessageBox.Show("Este contacto ya está en tu lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                using (StreamWriter sw = File.AppendText(rutaContactos))
                {
                    string nuevaEntrada = $"{usuarioActual};{usuario};{fechaTransaccion:dd/MM/yyyy HH:mm:ss};{usuarioActual};1";
                    sw.WriteLine(nuevaEntrada);
                }

                MessageBox.Show("Contacto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el contacto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string rutaContactos = @"C:\MEIA\contactos.txt";
            string usuario = txtUsuario.Text; 
            bool contactoEncontrado = false;

            try
            {
                if (!File.Exists(rutaContactos))
                {
                    MessageBox.Show("El archivo de contactos no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lineas = File.ReadAllLines(rutaContactos);

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');

                    if (campos.Length == 5 && campos[0] == usuarioActual && campos[1] == usuario)
                    {
                        contactoEncontrado = true;

                        int estatus = int.Parse(campos[4]);
                        if (estatus == 1)
                        {
                            campos[4] = "0"; 
                            MessageBox.Show("El contacto ha sido deshabilitado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            campos[4] = "1"; 
                            MessageBox.Show("El contacto ha sido habilitado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        lineas[i] = string.Join(";", campos);
                        break;
                    }
                }

                if (!contactoEncontrado)
                {
                    MessageBox.Show("El contacto no se encontró en tu lista de contactos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                File.WriteAllLines(rutaContactos, lineas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el estado del contacto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Lista_Click(object sender, EventArgs e)
        {
            ListaContactos listaContactosForm = new ListaContactos(usuarioActual);
            listaContactosForm.ShowDialog(); 
        }
    }
}
