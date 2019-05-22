using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.ActiveControl = Dni;
            dniRegistrado.Visible = false;
            usuarioRegistrado.Visible = false;
            emailRegistrado.Visible = false;
            fechaNacimiento.MaxDate = DateTime.Today;
        }

        private void VentanaNuevoUsuario_Load(object sender, EventArgs e)
        {
            Dni.Focus();
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellidos.Text) ||
                string.IsNullOrEmpty(Direccion.Text) || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(NickName.Text) ||
                string.IsNullOrEmpty(fechaNacimiento.Text))
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

                if (Hombre.Checked)
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }
                
                DateTime fechaNac = Convert.ToDateTime(fechaNacimiento.Text);

                string fecha = fechaNac.ToString("yyyy-MM-dd");

                //Cogemos la foto
                string foto = obtenFotoUsuario();
                
                MySqlConnection conexion = new ConexionBBDD().conecta();

                string valores = "'" + DNI + "','" + nombre + "','" + apellidos + "','" + fecha + "','" + sexo +
                "','" + email + "','" + direccion + "','" + usuario + "','" + foto + "'";

                if (foto == null)
                {
                    valores = "'" + DNI + "','" + nombre + "','" + apellidos + "','" + fecha + "','" + sexo +
                "','" + email + "','" + direccion + "','" + usuario + "', NULL" ;

                }

                MySqlCommand comando = new MySqlCommand("INSERT INTO nuevos_usuarios (Dni, Nombre, Apellido, Fecha_Nac, Sexo, Email, Direccion, NickName, Foto) " +
                "VALUES (" + valores + ");", conexion);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.RecordsAffected == 1)
                {
                    MessageBox.Show("Usuario: " + usuario + " añadido correctamente.");
                    this.Visible = false;
                }

                conexion.Close();

            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Comprobacion de campos clave
        #region Comprobacion Campos Clave


        /// <summary>
        /// Comprueba si el DNI esta en la base de datos o no.
        /// En caso de estarlo, saldra una etiqueta roja y nos
        /// bloqueara el boton de añadir usuario. En caso de que
        /// el DNI este disponible para su insercion nos mostrara
        /// una etiqueta diciendo que el DNI esta disponible
        /// </summary>
        /// <returns>Variable booleana que dice si esta o no el DNI en la BBDD</returns>
        private bool compruebaDNI()
        {
            bool dniPermitido = false;

            string DNI = Dni.Text;

            if (DNI.Length >= 1)
            {

                //Cada vez que pulso una tecla busco el DNI en la bbdd
                MySqlConnection conexion = new ConexionBBDD().conecta();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM nuevos_usuarios WHERE Dni = '" + DNI + "';", conexion);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    //Mostramos la etiqueta de DNI registrado y deshabilitamos el boton de añadir usuario
                    dniRegistrado.Visible = true;
                    dniRegistrado.Text = "DNI REGISTRADO";
                    dniRegistrado.ForeColor = Color.Red;
                    BotonAlta.Enabled = false;
                }
                else
                {
                    dniRegistrado.Visible = true;
                    dniRegistrado.Text = "DNI Disponible";
                    dniRegistrado.ForeColor = Color.Green;
                    BotonAlta.Enabled = true;
                    dniPermitido = true;
                }
            }
            else
            {
                dniRegistrado.Visible = true;
                dniRegistrado.Text = "DNI Obligatorio";
                dniRegistrado.ForeColor = Color.Red;
                BotonAlta.Enabled = false;
                dniPermitido = true;
            }

            return dniPermitido;
        }

        private bool compruebaEmail()
        {
            bool emailPermitido = false;

            string email = Email.Text;

            if (email.Length >= 1)
            {

                //Cada vez que pulso una tecla busco el DNI en la bbdd
                MySqlConnection conexion = new ConexionBBDD().conecta();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM nuevos_usuarios WHERE Email = '" + email + "';", conexion);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    //Mostramos la etiqueta de DNI registrado y deshabilitamos el boton de añadir usuario
                    emailRegistrado.Visible = true;
                    emailRegistrado.Text = "Email REGISTRADO";
                    emailRegistrado.ForeColor = Color.Red;
                    BotonAlta.Enabled = false;
                }
                else
                {
                    emailRegistrado.Visible = true;
                    emailRegistrado.Text = "Email Disponible";
                    emailRegistrado.ForeColor = Color.Green;
                    BotonAlta.Enabled = true;
                    emailPermitido = true;
                }
            }
            else
            {
                emailRegistrado.Visible = true;
                emailRegistrado.Text = "Email Obligatorio";
                emailRegistrado.ForeColor = Color.Red;
                BotonAlta.Enabled = false;
                emailPermitido = true;
            }

            return emailPermitido;

        }

        private bool compruebaUsuario()
        {
            bool nicknamePermitido = false;

            string nickname = NickName.Text;

            if (nickname.Length >= 1)
            {

                //Cada vez que pulso una tecla busco el DNI en la bbdd
                MySqlConnection conexion = new ConexionBBDD().conecta();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM nuevos_usuarios WHERE NickName = '" + nickname + "';", conexion);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    //Mostramos la etiqueta de DNI registrado y deshabilitamos el boton de añadir usuario
                    usuarioRegistrado.Visible = true;
                    usuarioRegistrado.Text = "Usuario REGISTRADO";
                    usuarioRegistrado.ForeColor = Color.Red;
                    BotonAlta.Enabled = false;
                }
                else
                {
                    usuarioRegistrado.Visible = true;
                    usuarioRegistrado.Text = "Usuario Disponible";
                    usuarioRegistrado.ForeColor = Color.Green;
                    BotonAlta.Enabled = true;
                    nicknamePermitido = true;
                }
            }
            else
            {
                usuarioRegistrado.Visible = true;
                usuarioRegistrado.Text = "Nickname Obligatorio";
                usuarioRegistrado.ForeColor = Color.Red;
                BotonAlta.Enabled = false;
                nicknamePermitido = true;
            }
            return nicknamePermitido;

        }

        #endregion

        private void Dni_KeyUp(object sender, KeyEventArgs e)
        {
            compruebaDNI();
        }

        private void Dni_Leave(object sender, EventArgs e)
        {
            compruebaDNI();
        }

        private void NickName_KeyUp(object sender, KeyEventArgs e)
        {
            compruebaUsuario();
        }

        private void NickName_Leave(object sender, EventArgs e)
        {
            compruebaUsuario();
        }

        private void Email_KeyUp(object sender, KeyEventArgs e)
        {
            compruebaEmail();
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            compruebaEmail();
        }


        /// <summary>
        /// Evento que se ejecuta cuando el checkbox de Hombre cambia de estado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hombre_CheckedChanged(object sender, EventArgs e)
        {
            if(Hombre.Checked)
            {
                //Desactivo Mujer
                Mujer.Enabled = false;
            }
            else
            {
                //Activo Mujer
                Mujer.Enabled = true;
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando el checkbox de Mujer cambia de estado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mujer_CheckedChanged(object sender, EventArgs e)
        {
            if (Mujer.Checked)
            {
                //Desactivo Hombre
                Hombre.Enabled = false;
            }
            else
            {
                //Activo Hombre
                Hombre.Enabled = true;
            }
        }

        private string obtenFotoUsuario()
        {
            //Aqui almacenaremos la foto
            string foto = null;

            MessageBox.Show("Debe seleccionar una foto formato JPG. Si no, no guardara la imagen");

            //Mostramos el dialogo para seleccionar la imagen
            var dialogo = openFileDialog1.ShowDialog();            

            //Si pulsa el OK o Aceptar
            if (dialogo == DialogResult.OK)
            {
                //Cogemos el fichero y comprobamos que sea una imagen
                Image fotoUsuario = Image.FromFile(openFileDialog1.FileName);

                string[] fotoSeleccionada = openFileDialog1.SafeFileName.Split('.');

                if (fotoSeleccionada[1] != "jpg")
                {
                    MessageBox.Show("La foto debe ser formato JPG");
                }
                else
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        fotoUsuario.Save(m, fotoUsuario.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        string base64String = Convert.ToBase64String(imageBytes);

                        foto = base64String;


                    }
               }
            }
            else
            {
                foto = null;
            }

            return foto;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            obtenFotoUsuario();
        }
    }
}

