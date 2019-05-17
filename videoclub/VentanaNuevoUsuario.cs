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

        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellidos.Text) || string.IsNullOrEmpty(Direccion.Text)
               || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(NickName.Text) || string.IsNullOrEmpty(FechaNac.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            else
                MessageBox.Show(" Sentimos las molestias pero en estos momentos la base de datos no esta disponible , inténtelo más tarde.");
            {
            }
        }
    }
}
    
