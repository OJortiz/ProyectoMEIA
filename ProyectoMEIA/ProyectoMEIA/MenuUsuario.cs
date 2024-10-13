﻿using System;
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
    }
}