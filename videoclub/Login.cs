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
    public partial class Login : Form
    {
        int numErrores = 0;

        public Login()
        {
            InitializeComponent();
            //Foco en campo usuario
            this.ActiveControl = textBox1;
        }

        private void login()
        {
            if (numErrores < 2)
            {
                MySqlConnection conexion = new ConexionBBDD().conecta();

                String texto1 = textBox1.Text;
                String texto2 = textBox2.Text;

                MySqlCommand comando = new MySqlCommand("" +
                    "SELECT * FROM usuarios WHERE" +
                    " usuario = '" + texto1 +
                    "' AND pass = '" + texto2 +
                    "' ", conexion);

                if (texto1.Contains("'") || texto2.Contains("'"))
                {
                    MessageBox.Show("Accceso Denegado", "USUARIO O CONTRASEÑA ERRONEOS");
                    numErrores++;
                }
                else
                {
                    if (numErrores < 2)
                    {
                        MySqlDataReader resultado = comando.ExecuteReader();

                        if (resultado.Read())
                        {
                            // ocultamos la ventana en la que estamos
                            this.Visible = false;

                            // creamos una nueva ventana del tipo VentanaPrincipal
                            VentanaInicio ventana = new VentanaInicio();
                            ventana.Visible = true;
                            CenterToScreen();

                            var mensajeBienvenida = MessageBox.Show("Acceso Correcto", "USUARIO OK");
                            CenterToScreen();
                        }

                        else
                        {
                            MessageBox.Show("Accceso Denegado", "USUARIO O CONTRASEÑA ERRONEOS");
                            CenterToScreen();
                            numErrores++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Demasiados intentos acometidos. Cuenta bloqueada", "Bloqueado");
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Demasiados intentos acometidos. Cuenta bloqueada", "Bloqueado");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        
    }
}
    