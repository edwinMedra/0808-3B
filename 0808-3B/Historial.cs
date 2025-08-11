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
    public partial class Historial : Form
    {
        public string nombreUsuario;
        public double saldo;
        public string dui;

        public Historial(string nombreUsuario,double saldo, string dui)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.saldo = saldo;
            this.dui = dui;
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // boton para regresar a pagina principal
            this.Hide();
            Index index = new Index(nombreUsuario, saldo, dui);
            index.ShowDialog();
            Application.Exit();
          
        }
    }
}
