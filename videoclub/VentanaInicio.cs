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
            rellenaComboAutores();
        }
        // Para que al cerrar este Form, se cierre la app completamente
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit(); // Con este comando cerraremos la app
        }

        private void rellenaComboAutores()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();

            // Le decimos en que punto tiene que buscar dentro de la BBDD
            MySqlCommand comando = new MySqlCommand
                                    ("SELECT * FROM actors ORDER BY first_name", conexion);
            // Con este comando mandamos ejecutar la consulta anterior
            MySqlDataReader resultado = comando.ExecuteReader();

            // Queremos que añada cada valor de la BBDD a nuestro comboBox
            while (resultado.Read())
            {
                // Ejemplo buscando la columna por número
                String id = resultado.GetString(0);

                // Ejemplo buscando la columna por nombre
                String first_name = resultado.GetString("first_name");
                String last_name = resultado.GetString("last_name");
                String gender = resultado.GetString("gender");

                desplegableActores.Items.Add(id + first_name + " -- "
                                            + last_name + " -- "
                                            + gender + " -- ");
            }

            conexion.Close();   // Para cerrar la conexión
        }
    }
}