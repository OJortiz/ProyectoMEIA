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
    public partial class ListaContactos : Form
    {
        public string usuarioActual { get; set; }
        public ListaContactos(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario; 
            InicializarListView();   
            CargarContactos();       
        }

        private void InicializarListView()
        {
            listViewContactos.View = View.Details;

            listViewContactos.Columns.Add("Usuario", 100, HorizontalAlignment.Left);
            listViewContactos.Columns.Add("Fecha Transacción", 150, HorizontalAlignment.Left);
            listViewContactos.Columns.Add("Estado", 100, HorizontalAlignment.Left);

            listViewContactos.FullRowSelect = true;
            listViewContactos.GridLines = true;
        }

        private void CargarContactos()
        {
            string rutaContactos = @"C:\MEIA\contactos.txt";

            try
            {
                if (File.Exists(rutaContactos))
                {
                    string[] lineas = File.ReadAllLines(rutaContactos);

                    foreach (string linea in lineas)
                    {
                        string[] campos = linea.Split(';');
                        if (campos.Length == 5)
                        {
                            string usuario = campos[0];
                            string contacto = campos[1];
                            string fechaTransaccion = campos[2];
                            int estatus = int.Parse(campos[4]);

                            if (usuario == usuarioActual)
                            {
                                ListViewItem item = new ListViewItem(contacto);
                                item.SubItems.Add(fechaTransaccion);

                                if (estatus == 1)
                                {
                                    item.SubItems.Add("Activo");
                                }
                                else
                                {
                                    item.SubItems.Add("Inactivo");
                                    item.BackColor = Color.DarkRed;
                                }

                                listViewContactos.Items.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay contactos registrados para este usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contactos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
