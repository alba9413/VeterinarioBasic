using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioBasic
{
    public partial class VentanaLogin : Form
    {
        //Conexion miConexion = new Conexion();
       // Registro miRegistro = new Registro();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (miConexion.loginClientes(user.Text, pass.Text))
            //{
            //    this.Hide();
            //    VentanaPrincipal v = new VentanaPrincipal();
            //    v.Show();
            //}
            //else
            //{
            //    MessageBox.Show("usuario o contraseña incorrrectos");
            //}
        }

        private void registro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //miRegistro.Show();
        }
    }
}
