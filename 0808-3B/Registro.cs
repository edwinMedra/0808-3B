using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace _0808_3B
{
    public partial class Registro : Form
    {

        // instancia de conexion a base de  

        public Registro()
        {
            InitializeComponent();
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // accion al momento de precionar el boton de crear 


            // asignar valor a variables
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string email = txtEmail.Text.Trim();
            string numDui = txtNumDui.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string confirContra = txtConfirmarContra.Text.Trim();

            if (nombre == "" || apellido == "" || email == "" || contrasena == "" || confirContra == "")
            {
                MessageBox.Show("Completar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // en caso de que los datos esten completos, validar contraseña
                if (confirContra != contrasena)
                {
                    MessageBox.Show("Ingrese las cotraseñas correctamente", "Contraseñas no validas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // hacer proceso de inserción de datos
                    string conexion = "host=localhost;user=root;password=;database=miniBank;";
                    using (MySqlConnection conn = new MySqlConnection(conexion))
                    {
                        conn.Open();

                        // funcion para asignar el num de cuenta 
                        Random rnd = new Random();
                        int numeroCuenta = rnd.Next(10000000, 100000000); // entre 10,000,000 y 99,999,999
                      
                        //insert
                        string insertQuery = "INSERT INTO usuarios (nombre,apellido,email,numDui,pass, saldo, numCuenta) VALUES (@nombre,@apellido, @email,@numDui,@pass, '10.00', @numeroCuenta)";
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@apellido", apellido);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@numDui", numDui);
                            cmd.Parameters.AddWithValue("@pass", contrasena);
                            cmd.Parameters.AddWithValue("@numeroCuenta", numeroCuenta);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Usuario registrado exitosamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }



                }


            }
        }

        private void panel_registro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Hide();
            
        }
    }
}
