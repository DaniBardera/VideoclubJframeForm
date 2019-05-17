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
        }
        /*
        public void RellenaDatos() {
           
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand
                ( "SELECT nuevos_usuarios.Nombre FROM nuevos_usuarios where Dni = '" + tb_dni.Text + "'");
            MySqlDataReader resultado = comando.ExecuteReader();
            while( resultado.Read()){
                tb_nombre.Text = resultado.ToString();
            }
            

            conexion.Close();
                  }
     */  
    }
    }


