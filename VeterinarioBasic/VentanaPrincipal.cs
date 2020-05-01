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
    public partial class VentanaPrincipal : Form
    {

        conexion c = new conexion();
        DataTable dt = new DataTable();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = c.obtenerDatos("SELECT * FORM cliente WHERE dni =" + buscador.Text + ";");
            Cnombre.Text = dt.Rows[0]["nombre"].ToString();
            capellido.Text = dt.Rows[0]["apellidos"].ToString();
            Cdni.Text = dt.Rows[0]["dni"].ToString();
            cdireccion.Text = dt.Rows[0]["direccion"].ToString();
            ccp.Text = dt.Rows[0]["cp"].ToString();
            cemail.Text = dt.Rows[0]["email"].ToString();
            cchip.Text = dt.Rows[0]["chip_mascota"].ToString();

        }
    }
}
