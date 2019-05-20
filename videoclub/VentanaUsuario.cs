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

namespace videoclub
{
    public partial class VentanaUsuario : Form
    {
        public VentanaUsuario()
        {
            InitializeComponent();
            datosUsuario.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Cogemos el DNI que hemos metido en la barra de busqueda
            string DNI = textBoxDNI.Text.ToString();

            //Query para los datos
            MySqlConnection conexion = new ConexionBBDD().conecta();

            MySqlCommand comando = new MySqlCommand("SELECT * FROM nuevos_usuarios WHERE Dni = '" + DNI + "';", conexion);

            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.Read())
            {
                errorCliente.Visible = false;
                datosUsuario.Visible = true;
                //Comprobamos los datos y si los tenemos los introducimos en sus lugares
                //Si no hay nulos en la 2ª columna, saco el nombre
                if (!resultado.IsDBNull(1))
                {
                    lblNombre.Text = resultado.GetString("Nombre");
                }
                else
                {
                    lblNombre.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 3ª columna, saco el apellido
                if (!resultado.IsDBNull(2))
                {
                    lblApellidos.Text = resultado.GetString("Apellido");
                }
                else
                {
                    lblApellidos.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 4ª columna, saco la fecha de nacimiento
                if (!resultado.IsDBNull(3))
                {
                    lblFechaNacimiento.Text = resultado.GetString("Fecha_Nac");
                }
                else
                {
                    lblFechaNacimiento.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 5ª columna, saco el email
                if (!resultado.IsDBNull(5))
                {
                    lblEmail.Text = resultado.GetString("Email");
                }
                else
                {
                    lblEmail.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 6ª columna, saco la direccion
                if (!resultado.IsDBNull(6))
                {
                    lblDireccion.Text = resultado.GetString("Direccion");
                }
                else
                {
                    lblDireccion.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 7ª columna, saco el super nickname
                if (!resultado.IsDBNull(7))
                {
                    lblUsuario.Text = resultado.GetString("NickName");
                }
                else
                {
                    lblUsuario.Text = "Dato desconocido";
                }

            }
            else
            {
                errorCliente.Visible = true;
                datosUsuario.Visible = false;
                textBoxDNI.Focus();
                textBoxDNI.Text = "";
            }

            //Cerramos conexion
            conexion.Close();
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
          
        
    
    



