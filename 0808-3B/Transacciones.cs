using MySql.Data.MySqlClient;
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


    public partial class Transacciones : Form
    {

        public string nombreUsuario;
        public double saldo;
        public string dui;

        public Transacciones(string nombreUsuario, double saldo, string dui)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.saldo = saldo;

            string textSaldo = saldo.ToString("C2");
            lblSaldo.Text = textSaldo;
            this.dui = dui;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // tomar el valor de todas las entradas de datos
            string numCuenta = txtNumCuenta.Text.Trim();
            string nomDestino = txtNomDestinatario.Text.Trim();
            String montoDestino = txtMonto.Text;

            // validar campos 
            if (numCuenta == "" || nomDestino == "")
            {
                MessageBox.Show("Completar datos", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double monto = Convert.ToDouble(montoDestino);
                if (monto > saldo)
                {
                    MessageBox.Show("Saldo insuficiente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // hacer transferencia hacia el usuario 
                    string conexion = "server=localhost; user=root;password=;database=miniBank";
                    using (MySqlConnection conn = new MySqlConnection(conexion))
                    {
                        conn.Open();
                        string queryUpdate = "UPDATE usuarios set saldo = saldo + @monto where numCuenta = @numCuenta";
                        using (MySqlCommand cmd = new MySqlCommand(queryUpdate, conn))
                        {
                            // asignar valores a cada variable para hacer la consulta
                            cmd.Parameters.AddWithValue("@monto", monto);
                            cmd.Parameters.AddWithValue("@numCuenta", numCuenta);
                            cmd.ExecuteNonQuery();
                                                      
                            MessageBox.Show($"Transferencia realizada de {monto} realizada con exito","Transferencia", MessageBoxButtons.OK);

                            // proceso para restar cantidad al usuario actual
                            string restaQuery = "Update usuarios set saldo = saldo - @monto where numDui = @numDui";
                            using (MySqlCommand cmd1 = new MySqlCommand(restaQuery, conn))
                            {
                                // asignar valores a cada variable para hacer la consulta
                                cmd1.Parameters.AddWithValue("@monto", monto);
                                cmd1.Parameters.AddWithValue("@numDui", dui);
                                cmd1.ExecuteNonQuery();


                                // limpiar campos
                         

                            }


                        }
                    }
                    //

                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            string dui = this.dui;
            double Nuevosaldo = 0;  // Declarar antes para usar después

            string conexion = "server=localhost; user=root;password=;database=miniBank";
            string query = $"SELECT saldo FROM usuarios WHERE numDui = '{dui}'";  // ojo con las comillas para string

            using (MySqlConnection conex = new MySqlConnection(conexion))
            {
                conex.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conex))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Nuevosaldo = reader.GetDouble("saldo");
                        }
                    }
                }
            }

            this.Hide();
            Index index = new Index(nombreUsuario, Nuevosaldo, dui);
            index.ShowDialog();
            Application.Exit();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
