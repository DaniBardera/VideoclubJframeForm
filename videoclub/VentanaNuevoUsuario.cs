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
    public partial class VentanaNuevoUsuario : Form
    {
        public VentanaNuevoUsuario()
        {
            InitializeComponent();
        }

        private void VentanaNuevoUsuario_Load(object sender, EventArgs e)
        {
            Dni.Focus();
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellidos.Text) || string.IsNullOrEmpty(Direccion.Text)
               || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(NickName.Text) || string.IsNullOrEmpty(Fecha_Nac.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                //Cogemos los datos que hemos introducido
                string DNI = Dni.Text;

                string nombre = Nombre.Text;

                string apellidos = Apellidos.Text;

                string usuario = NickName.Text;

                string direccion = Direccion.Text;

                string email = Email.Text;

                string sexo = "";

                if(Hombre.Checked)
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }

                string fecha = Fecha_Nac.Text;

                //Lo que habria que hacer es comprobar que los campos clave no se repiten y si esta todo ok Jose Luis hacer el insert

                MySqlConnection conexion = new ConexionBBDD().conecta();               

                MySqlCommand comando = new MySqlCommand("SELECT * FROM nuevos_usuarios WHERE Dni = '" + DNI + "';", conexion);

                MySqlDataReader resultado = comando.ExecuteReader();

           
                if (resultado.Read())
                {
                    MessageBox.Show("El DNI seleccionado ya está registrado en la BBDD");
                }

                else
                {
                    conexion.Close();

                    MySqlConnection conexion2 = new ConexionBBDD().conecta();

                    string valores = DNI + ", '" + nombre + "' ," + "'" + apellidos + ",'" + fecha + ",'" + Hombre.Checked +
                        ("HOMBRE") + email + "' ," + direccion + "' ," + usuario + "' ,";

                    MySqlCommand comando1 = new MySqlCommand("INSERT INTO nuevos_usuarios (Dni, Nombre, Apellido, Fecha_Nac, Sexo, Email, Direccion, NickName) " +
                    "VALUES (" + valores + ");", conexion2);

                    resultado = comando1.ExecuteReader();
                }
                    conexion.Close();
               
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
    
