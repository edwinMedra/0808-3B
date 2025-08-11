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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // acción de tomar los datos
            string email = txtDui.Text.Trim();
            string pass = txtContra.Text.Trim();

            if (email == "" || pass == "")
            {
                MessageBox.Show("Completa ambos campos.");
                return;
            }

            string connStr = "host=localhost;user=root;password=;database=miniBank;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT nombre, pass FROM usuarios WHERE email=@e AND pass=@p LIMIT 1";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@p", pass);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.Hide();
                            var index = new Index();
                            index.ShowDialog();
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas.");
                        }
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Derigir a pagina de registro
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void labelUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
