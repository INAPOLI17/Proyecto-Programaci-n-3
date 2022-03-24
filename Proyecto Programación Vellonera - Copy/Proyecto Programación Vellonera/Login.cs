﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programación_Vellonera
{
    public partial class Login : Form
    {
        Conexión con = new Conexión();
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ClaDatos permiso = new ClaDatos();
            
            
            if(con.Login(txtUser.Text,txtPass.Text) == true){

                Form1 inicio = new Form1();
                inicio.Show();
                inicio.rol = con.Login(txtUser.Text, txtPass.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
