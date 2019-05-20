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

        private void button1_Click(object sender, EventArgs e)
        {



            datosUsuario.Visible = true;


            //Actualizamos datos de la peli
            string datos = tb_dni.Text.ToString();

            //Query para los datos
            MySqlConnection conexion = new ConexionBBDD().conecta();

            MySqlCommand comando = new MySqlCommand("SELECT * FROM nuevos_usuarios WHERE nuevos_usuarios.Dni = '" + tb_dni.Text + "';", conexion);

            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.Read())
            {
                //Comprobamos los datos y si los tenemos los introducimos en sus lugares
                //Si no hay nulos en la 1ª columna, saco el nombre
                if (!resultado.IsDBNull(1))
                {
                    nombre_usu.Text = resultado.GetString("Nombre");
                }
                else
                {
                    nombre_usu.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 2ª columna, saco el año de publicacion
                if (!resultado.IsDBNull(2))
                {
                    apellido_usu.Text = resultado.GetString("Apellido");
                }
                else
                {
                    apellido_usu.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 3ª columna, saco el ranking de la peli
                if (!resultado.IsDBNull(3))
                {
                    direccion_usu.Text = resultado.GetString("Direccion");
                }
                else
                {
                    direccion_usu.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 4ª columna, saco el stock de la peli
                if (!resultado.IsDBNull(4))
                {
                    telefono_usu.Text = resultado.GetString("Telefono");

                }
                else
                {
                    telefono_usu.Text = "Dato desconocido";

                }
                if (!resultado.IsDBNull(4))
                {
                    sexo_usu.Text = resultado.GetString("Sexo");

                }
                else
                {
                    sexo_usu.Text = "Dato desconocido";

                }
                if (!resultado.IsDBNull(4))
                {
                    email_usu.Text = resultado.GetString("Email");

                }
                else
                {
                    email_usu.Text = "Dato desconocido";

                }


            }

            //Cerramos conexion
            conexion.Close();

        }
    }
}
          
        
    
    



