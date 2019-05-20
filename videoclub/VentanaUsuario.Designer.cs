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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tb_dni = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nickName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datosUsuario = new System.Windows.Forms.Panel();
            this.l_nombre = new System.Windows.Forms.Label();
            this.l_apellido = new System.Windows.Forms.Label();
            this.l_direccion = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_sexo = new System.Windows.Forms.Label();
            this.l_telefono = new System.Windows.Forms.Label();
            this.direccion_usu = new System.Windows.Forms.Label();
            this.apellido_usu = new System.Windows.Forms.Label();
            this.nombre_usu = new System.Windows.Forms.Label();
            this.email_usu = new System.Windows.Forms.Label();
            this.sexo_usu = new System.Windows.Forms.Label();
            this.telefono_usu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.datosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(12, 12);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(97, 101);
            this.foto.TabIndex = 4;
            this.foto.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(48, 147);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // tb_dni
            // 
            this.tb_dni.AutoSize = true;
            this.tb_dni.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dni.Location = new System.Drawing.Point(12, 145);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(30, 20);
            this.tb_dni.TabIndex = 14;
            this.tb_dni.Text = "DNI";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(542, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(192, 27);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(263, 71);
            this.nickName.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datosUsuario
            // 
            this.datosUsuario.Controls.Add(this.email_usu);
            this.datosUsuario.Controls.Add(this.sexo_usu);
            this.datosUsuario.Controls.Add(this.telefono_usu);
            this.datosUsuario.Controls.Add(this.direccion_usu);
            this.datosUsuario.Controls.Add(this.apellido_usu);
            this.datosUsuario.Controls.Add(this.nombre_usu);
            this.datosUsuario.Controls.Add(this.l_email);
            this.datosUsuario.Controls.Add(this.l_sexo);
            this.datosUsuario.Controls.Add(this.l_telefono);
            this.datosUsuario.Controls.Add(this.l_direccion);
            this.datosUsuario.Controls.Add(this.l_apellido);
            this.datosUsuario.Controls.Add(this.l_nombre);
            this.datosUsuario.Location = new System.Drawing.Point(12, 184);
            this.datosUsuario.Name = "datosUsuario";
            this.datosUsuario.Size = new System.Drawing.Size(354, 257);
            this.datosUsuario.TabIndex = 18;
            // 
            // l_nombre
            // 
            this.l_nombre.AutoSize = true;
            this.l_nombre.Location = new System.Drawing.Point(16, 31);
            this.l_nombre.Name = "l_nombre";
            this.l_nombre.Size = new System.Drawing.Size(47, 13);
            this.l_nombre.TabIndex = 0;
            this.l_nombre.Text = "Nombre:";
            // 
            // l_apellido
            // 
            this.l_apellido.AutoSize = true;
            this.l_apellido.Location = new System.Drawing.Point(16, 74);
            this.l_apellido.Name = "l_apellido";
            this.l_apellido.Size = new System.Drawing.Size(47, 13);
            this.l_apellido.TabIndex = 1;
            this.l_apellido.Text = "Apellido:";
            // 
            // l_direccion
            // 
            this.l_direccion.AutoSize = true;
            this.l_direccion.Location = new System.Drawing.Point(16, 111);
            this.l_direccion.Name = "l_direccion";
            this.l_direccion.Size = new System.Drawing.Size(52, 13);
            this.l_direccion.TabIndex = 2;
            this.l_direccion.Text = "Dirección";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(16, 229);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(35, 13);
            this.l_email.TabIndex = 5;
            this.l_email.Text = "Email:";
            // 
            // l_sexo
            // 
            this.l_sexo.AutoSize = true;
            this.l_sexo.Location = new System.Drawing.Point(16, 192);
            this.l_sexo.Name = "l_sexo";
            this.l_sexo.Size = new System.Drawing.Size(34, 13);
            this.l_sexo.TabIndex = 4;
            this.l_sexo.Text = "Sexo:";
            // 
            // l_telefono
            // 
            this.l_telefono.AutoSize = true;
            this.l_telefono.Location = new System.Drawing.Point(16, 149);
            this.l_telefono.Name = "l_telefono";
            this.l_telefono.Size = new System.Drawing.Size(49, 13);
            this.l_telefono.TabIndex = 3;
            this.l_telefono.Text = "Teléfono";
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
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 453);
            this.Controls.Add(this.datosUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.textBox7);
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label tb_dni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nickName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel datosUsuario;
        private System.Windows.Forms.Label email_usu;
        private System.Windows.Forms.Label sexo_usu;
        private System.Windows.Forms.Label telefono_usu;
        private System.Windows.Forms.Label direccion_usu;
        private System.Windows.Forms.Label apellido_usu;
        private System.Windows.Forms.Label nombre_usu;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_sexo;
        private System.Windows.Forms.Label l_telefono;
        private System.Windows.Forms.Label l_direccion;
        private System.Windows.Forms.Label l_apellido;
        private System.Windows.Forms.Label l_nombre;
    }
}