using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
               || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(NickName.Text) || string.IsNullOrEmpty(fechaNacimiento.Text))
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

                string fecha = fechaNacimiento.Value.ToString("dd/MM/yyyy HH:mm:ss");

                //LO que habria que hacer es comprobar que los campos clave no se repiten y si esta todo ok Jose Luis hacer el insert
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
    
