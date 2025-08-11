using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0808_3B
{
    public partial class indexDeslogeado : Form
    {
        public indexDeslogeado()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // mostrar pagina de registro 
            this.Hide();
            Registro registro = new Registro();
            registro.ShowDialog();
            Application.Exit();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // mostrar pagina para iniciar sesión
            this.Hide();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.ShowDialog();
            Application.Exit();
        }
    }
}
