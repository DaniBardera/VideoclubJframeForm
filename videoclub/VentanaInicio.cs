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
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
            rellenaComboGeneros();
            rellenaComboSocios();
            panelInfoPeli.Visible = false;
            btnAlquilarPeli.Visible = false;
            btnMostrarAlquileres.Enabled = false;

        }
        // Para que al cerrar este Form, se cierre la app completamente
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit(); // Con este comando cerraremos la app
        }

        private void rellenaComboGeneros()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();

            // Le decimos en que punto tiene que buscar dentro de la BBDD
            MySqlCommand comando = new MySqlCommand
                                    ("SELECT distinct genre FROM movies_genres", conexion);
            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado = comando.ExecuteReader();

            // Queremos que añada cada valor de la BBDD a nuestro comboBox
            while (resultado.Read())
            {
                String genre = resultado.GetString("genre");
                desplegableGeneros.Items.Add(genre);
            }
            conexion.Close();   // Para cerrar la conexión
        }

        private void rellenaComboSocios()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();

            // Le decimos en que punto tiene que buscar dentro de la BBDD
            MySqlCommand comando = new MySqlCommand("SELECT * FROM nuevos_usuarios", conexion);
            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado = comando.ExecuteReader();

            bool usuarioElegido = false;

            // Queremos que añada cada valor de la BBDD a nuestro comboBox
            while (resultado.Read())
            {
                String nombre = resultado.GetString("nombre");
                String apellido = resultado.GetString("apellido");
                String dni = resultado.GetString("dni");
                String email = resultado.GetString("email");
                String nick = resultado.GetString("nickname");

                String socio = nombre + apellido + "," + dni + "," + email;

                desplegableSociosVideoclub.Items.Add(socio);

                if(!usuarioElegido)
                {
                    desplegableSociosVideoclub.SelectedItem = socio;
                    usuarioElegido = true;
                }
            }
            conexion.Close();   // Para cerrar la conexión
        }


        private void desplegableActores_SelectionChangeCommitted(object sender, EventArgs e)
        {       
            rellenaBusqueda();
        }
        
        public void rellenaBusqueda()
        {
            //Limpiamos el desplegable de las peliculas
            desplegableBusqueda.Items.Clear();

            MySqlConnection conexion = new ConexionBBDD().conecta();

            MySqlCommand comando = new MySqlCommand("SELECT DISTINCT(name) FROM movies " +
                "WHERE id IN (SELECT movie_id FROM movies_genres " +
                "WHERE genre = '" + desplegableGeneros.SelectedItem.ToString() + "');", conexion);

            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado2 = comando.ExecuteReader();

            bool peliElegida = false;

            while (resultado2.Read())
            {
                String name = resultado2.GetString("name");
                desplegableBusqueda.Items.Add(name);
                if(!peliElegida)
                {
                    desplegableBusqueda.SelectedItem = name;
                    peliElegida = true;
                }
            }
            conexion.Close();   // Para cerrar la conexión
        }
        private void usuarioEntrar_Click(object sender, EventArgs e)
        {
            // creamos una nueva ventana del tipo VentanaUsuario
            VentanaUsuario ventana = new VentanaUsuario();
            ventana.Visible = true;
        }

        private void nuevoUsuarioEntrar_Click(object sender, EventArgs e)
        {
            // creamos una nueva ventana del tipo VentanaNuevoUsuario
            VentanaNuevoUsuario ventana = new VentanaNuevoUsuario();
            ventana.Visible = true;
        }

        private void desplegableBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostramos panel
            panelInfoPeli.Visible = true;
            btnAlquilarPeli.Visible = true;
            
            //Actualizamos datos de la peli
            string peli = desplegableBusqueda.SelectedItem.ToString();

            //Query para los datos
            MySqlConnection conexion = new ConexionBBDD().conecta();

            MySqlCommand comando = new MySqlCommand("SELECT * FROM movies WHERE name = '" + desplegableBusqueda.SelectedItem.ToString() + "';", conexion);

            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado = comando.ExecuteReader();

            if(resultado.Read())
            {
                //Comprobamos los datos y si los tenemos los introducimos en sus lugares
                //Si no hay nulos en la 1ª columna, saco el nombre
                if(!resultado.IsDBNull(1))
                {
                    nombrePeli.Text = resultado.GetString("name");
                }
                else
                {
                    nombrePeli.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 2ª columna, saco el año de publicacion
                if (!resultado.IsDBNull(2))
                {
                    yearPeli.Text = resultado.GetString("year");
                }
                else
                {
                    yearPeli.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 3ª columna, saco el ranking de la peli
                if (!resultado.IsDBNull(3))
                {
                    rankingPeli.Text = resultado.GetString("rank");
                }
                else
                {
                    rankingPeli.Text = "Dato desconocido";
                }
                //Si no hay nulos en la 4ª columna, saco el stock de la peli
                if (!resultado.IsDBNull(4) && resultado.GetInt32("stock") > 0)
                {
                    stockPeli.Text = resultado.GetString("stock");
                    //Habilito el boton de alquilar
                    btnAlquilarPeli.Enabled = true;
                }
                else
                {
                    stockPeli.Text = "No queda stock";
                    //Deshabilito el boton de alquilar la peli
                    btnAlquilarPeli.Enabled = false;
                    btnMostrarAlquileres.Enabled = true;
                }

            }

            //Cerramos conexion
            conexion.Close();

            //Comprobamos si esta pelicula ha tenido alquileres
            if(muestraAlquileres(peli))
            {
                //Mostramos el boton de mostrar alquileres
                btnMostrarAlquileres.Enabled = true;
            }

        }

        private bool muestraAlquileres(String pelicula)
        {
            bool tieneAlquileres = false;

            return tieneAlquileres;
        }

        private void btnAlquilarPeli_Click(object sender, EventArgs e)
        {
            //Alquilamos la peli
            //Que necesito para alquilar la pelicula? idPeli, idUsuario, fechaActual
            string usuarioElegido = desplegableSociosVideoclub.SelectedItem.ToString();
            string[] usuario = usuarioElegido.Split(',');
            //Cojo el DNI del usuario
            string DNI = usuario[1];

            //Cojo el id de la pelicula -- BBDD??
            string pelicula = desplegableBusqueda.SelectedItem.ToString();

            //Llamo a BBDD para coger el ID de la pelicula
            //Query para los datos
            MySqlConnection conexion = new ConexionBBDD().conecta();

            MySqlCommand comando = new MySqlCommand("SELECT id,stock FROM movies WHERE name = '" + pelicula + "';", conexion);

            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado = comando.ExecuteReader();

            int idPeli = 0;
            int stock = 0;

            //Cojo el ID de la pelicula y su stock original
            if(resultado.Read())
            {
                idPeli = resultado.GetInt32("id");
                stock = resultado.GetInt32("stock");
            }

            conexion.Close();

            //Cojo la fecha de hoy
            DateTime hoy = DateTime.Now;

            //Establezco un periodo de alquiler de 10 dias
            DateTime fechaDevol = hoy.AddDays(10);

            string valores = idPeli + ", '" + DNI + "' ," + "'" + hoy.ToString("yyyy-MM-dd H:mm:ss") + "'" + "," + "'" + fechaDevol.ToString("yyyy-MM-dd H:mm:ss") + "'";

            //Stock previo de la pelicula antes de alquilarla
            conexion.Open();

            comando = new MySqlCommand("INSERT INTO alquiler (idPeli, idUsuario, fechaInicio, fechaFin) " +
                "VALUES (" + valores + ");", conexion);

            resultado = comando.ExecuteReader();
            //Si el comando altera una fila, se que se habrá añadido correctamente el alquiler
            if (resultado.RecordsAffected == 1)
            {
                MessageBox.Show("Pelicula alquilada correctamente", "Pelicula Alquilada");
                CenterToParent();
            }

            conexion.Close();

            //Resto 1 al stock de la peli -- UPDATE
            int nuevoStock = stock-1;

            conexion.Open();
            comando = new MySqlCommand("UPDATE movies SET stock = " + nuevoStock + " WHERE id = " + idPeli + ";",conexion);
            resultado = comando.ExecuteReader();
            //Si el comando altera una fila cambiamos el valor de los items disponibles
            if (resultado.RecordsAffected == 1)
            {
                //Si no hay nulos en la 4ª columna, saco el stock de la peli
                if (nuevoStock > 0)
                {
                    stockPeli.Text = nuevoStock.ToString();
                    //Habilito el boton de alquilar
                    btnAlquilarPeli.Enabled = true;
                }
                else
                {
                    stockPeli.Text = "No queda stock";
                    //Deshabilito el boton de alquilar la peli
                    btnAlquilarPeli.Enabled = false;
                    btnMostrarAlquileres.Enabled = true;
                }
            }
            conexion.Close();
        }
    }
}