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
        conexion Conexion = new conexion();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Conexion.loginVeterinario(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                VentanaPrincipal vp = new VentanaPrincipal();
                vp.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrrectos");
            }
            

        }
    }
}