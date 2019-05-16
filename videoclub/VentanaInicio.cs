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

                desplegableActores.Items.Add(genre);
            }
            conexion.Close();   // Para cerrar la conexión
        }

        private void desplegableActores_SelectionChangeCommitted(object sender, EventArgs e)
        {       
            rellenaBusqueda();
        }
        
        public void rellenaBusqueda()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT name FROM movies, movies_genres WHERE"+
                "movies_genres.genre = '" + desplegableActores + "'", conexion);

            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado2 = comando.ExecuteReader();

            while (resultado2.Read())
            {
                String name = resultado2.GetString("name");

                desplegableBusqueda.Items.Add(name);
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
    }
}