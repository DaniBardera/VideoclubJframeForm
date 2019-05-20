namespace videoclub
{
    partial class VentanaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaUsuario));
            this.foto = new System.Windows.Forms.PictureBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.tb_dni = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.datosUsuario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_usu = new System.Windows.Forms.Label();
            this.sexo_usu = new System.Windows.Forms.Label();
            this.telefono_usu = new System.Windows.Forms.Label();
            this.direccion_usu = new System.Windows.Forms.Label();
            this.apellido_usu = new System.Windows.Forms.Label();
            this.nombre_usu = new System.Windows.Forms.Label();
            this.l_nombre = new System.Windows.Forms.Label();
            this.errorCliente = new System.Windows.Forms.Label();
            this.cerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.datosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(181, 12);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(97, 101);
            this.foto.TabIndex = 4;
            this.foto.TabStop = false;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(48, 133);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 13;
            // 
            // tb_dni
            // 
            this.tb_dni.AutoSize = true;
            this.tb_dni.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dni.Location = new System.Drawing.Point(12, 133);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(30, 20);
            this.tb_dni.TabIndex = 14;
            this.tb_dni.Text = "DNI";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(182, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(184, 20);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // datosUsuario
            // 
            this.datosUsuario.Controls.Add(this.lblUsuario);
            this.datosUsuario.Controls.Add(this.lblDireccion);
            this.datosUsuario.Controls.Add(this.lblEmail);
            this.datosUsuario.Controls.Add(this.lblFechaNacimiento);
            this.datosUsuario.Controls.Add(this.lblApellidos);
            this.datosUsuario.Controls.Add(this.lblNombre);
            this.datosUsuario.Controls.Add(this.label4);
            this.datosUsuario.Controls.Add(this.label5);
            this.datosUsuario.Controls.Add(this.label2);
            this.datosUsuario.Controls.Add(this.label3);
            this.datosUsuario.Controls.Add(this.label1);
            this.datosUsuario.Controls.Add(this.email_usu);
            this.datosUsuario.Controls.Add(this.sexo_usu);
            this.datosUsuario.Controls.Add(this.telefono_usu);
            this.datosUsuario.Controls.Add(this.direccion_usu);
            this.datosUsuario.Controls.Add(this.apellido_usu);
            this.datosUsuario.Controls.Add(this.nombre_usu);
            this.datosUsuario.Controls.Add(this.l_nombre);
            this.datosUsuario.Location = new System.Drawing.Point(11, 207);
            this.datosUsuario.Name = "datosUsuario";
            this.datosUsuario.Size = new System.Drawing.Size(354, 270);
            this.datosUsuario.TabIndex = 18;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(104, 231);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(222, 25);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(104, 187);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(222, 25);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(104, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(222, 25);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Location = new System.Drawing.Point(104, 106);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(222, 25);
            this.lblFechaNacimiento.TabIndex = 19;
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Location = new System.Drawing.Point(104, 63);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(222, 25);
            this.lblApellidos.TabIndex = 18;
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(104, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(222, 25);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usuario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direccion:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cumpleaños:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellidos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_usu
            // 
            this.email_usu.AutoSize = true;
            this.email_usu.Location = new System.Drawing.Point(161, 229);
            this.email_usu.Name = "email_usu";
            this.email_usu.Size = new System.Drawing.Size(0, 13);
            this.email_usu.TabIndex = 11;
            // 
            // sexo_usu
            // 
            this.sexo_usu.AutoSize = true;
            this.sexo_usu.Location = new System.Drawing.Point(161, 192);
            this.sexo_usu.Name = "sexo_usu";
            this.sexo_usu.Size = new System.Drawing.Size(0, 13);
            this.sexo_usu.TabIndex = 10;
            // 
            // telefono_usu
            // 
            this.telefono_usu.AutoSize = true;
            this.telefono_usu.Location = new System.Drawing.Point(161, 149);
            this.telefono_usu.Name = "telefono_usu";
            this.telefono_usu.Size = new System.Drawing.Size(0, 13);
            this.telefono_usu.TabIndex = 9;
            // 
            // direccion_usu
            // 
            this.direccion_usu.AutoSize = true;
            this.direccion_usu.Location = new System.Drawing.Point(167, 111);
            this.direccion_usu.Name = "direccion_usu";
            this.direccion_usu.Size = new System.Drawing.Size(0, 13);
            this.direccion_usu.TabIndex = 8;
            // 
            // apellido_usu
            // 
            this.apellido_usu.AutoSize = true;
            this.apellido_usu.Location = new System.Drawing.Point(167, 74);
            this.apellido_usu.Name = "apellido_usu";
            this.apellido_usu.Size = new System.Drawing.Size(0, 13);
            this.apellido_usu.TabIndex = 7;
            // 
            // nombre_usu
            // 
            this.nombre_usu.AutoSize = true;
            this.nombre_usu.Location = new System.Drawing.Point(167, 31);
            this.nombre_usu.Name = "nombre_usu";
            this.nombre_usu.Size = new System.Drawing.Size(0, 13);
            this.nombre_usu.TabIndex = 6;
            // 
            // l_nombre
            // 
            this.l_nombre.Location = new System.Drawing.Point(18, 18);
            this.l_nombre.Name = "l_nombre";
            this.l_nombre.Size = new System.Drawing.Size(80, 25);
            this.l_nombre.TabIndex = 0;
            this.l_nombre.Text = "Nombre:";
            this.l_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorCliente
            // 
            this.errorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCliente.ForeColor = System.Drawing.Color.Red;
            this.errorCliente.Location = new System.Drawing.Point(11, 167);
            this.errorCliente.Name = "errorCliente";
            this.errorCliente.Size = new System.Drawing.Size(354, 25);
            this.errorCliente.TabIndex = 23;
            this.errorCliente.Text = "El cliente NO EXISTE";
            this.errorCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorCliente.Visible = false;
            // 
            // cerrarBtn
            // 
            this.cerrarBtn.Location = new System.Drawing.Point(290, 12);
            this.cerrarBtn.Name = "cerrarBtn";
            this.cerrarBtn.Size = new System.Drawing.Size(76, 20);
            this.cerrarBtn.TabIndex = 24;
            this.cerrarBtn.Text = "Cerrar";
            this.cerrarBtn.UseVisualStyleBackColor = true;
            this.cerrarBtn.Click += new System.EventHandler(this.cerrarBtn_Click);
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 489);
            this.Controls.Add(this.cerrarBtn);
            this.Controls.Add(this.errorCliente);
            this.Controls.Add(this.datosUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.foto);
            this.Name = "VentanaUsuario";
            this.Text = "VentanaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.datosUsuario.ResumeLayout(false);
            this.datosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label tb_dni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel datosUsuario;
        private System.Windows.Forms.Label email_usu;
        private System.Windows.Forms.Label sexo_usu;
        private System.Windows.Forms.Label telefono_usu;
        private System.Windows.Forms.Label direccion_usu;
        private System.Windows.Forms.Label apellido_usu;
        private System.Windows.Forms.Label nombre_usu;
        private System.Windows.Forms.Label l_nombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorCliente;
        private System.Windows.Forms.Button cerrarBtn;
    }
}