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
    public partial class Index : Form
    {

        public string nombreUsuario;
        public double saldo;
        public string dui;
        public Index(string nombreUsuario, double saldo, string dui)
        {
            InitializeComponent();

            // colocar el nombre de usuario aca
            this.nombreUsuario = nombreUsuario;
            this.saldo = saldo;
            this.dui = dui;


            lblUsuario.Text = nombreUsuario;
            lblSaldo.Text = saldo.ToString("C2"); // formato de dinero

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dirijir a pagina de transferencias 
            this.Hide();
            var historial = new Historial(nombreUsuario, saldo, dui);
            historial.ShowDialog();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void label1_Click_2(object sender, EventArgs e, double sal)
        {


        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {
            string textSaldo = saldo.ToString();
            lblSaldo.Text = textSaldo;
        }

        private void button_consultarSaldo_Click(object sender, EventArgs e)
        {
            // pagina para consultar saldo 
            this.Hide();
            ImprimirSaldo imprimirSaldo = new ImprimirSaldo(nombreUsuario, saldo, dui);
            imprimirSaldo.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_creditos_Click(object sender, EventArgs e)
        {
            // pagina para ir a transferir saldo a otra cuenta
            this.Hide();
            Transacciones transacciones = new Transacciones(nombreUsuario, saldo, dui);
            transacciones.ShowDialog();
            Application.Exit();
        }

        private void button_cerrarsesion_Click(object sender, EventArgs e)
        {
            // volver a index normal sin log
            this.Hide();
            indexDeslogeado indexNoLog = new indexDeslogeado();
            indexNoLog.ShowDialog();
            Application.Exit();
        }
    }
}
