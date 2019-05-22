namespace videoclub
{
    partial class VentanaNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaNuevoUsuario));
            this.Nombre = new System.Windows.Forms.TextBox();
            this.NickName = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Hombre = new System.Windows.Forms.CheckBox();
            this.Mujer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BotonAlta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Dni = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.dniRegistrado = new System.Windows.Forms.Label();
            this.usuarioRegistrado = new System.Windows.Forms.Label();
            this.emailRegistrado = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(137, 231);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(199, 20);
            this.Nombre.TabIndex = 2;
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(137, 377);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(199, 20);
            this.NickName.TabIndex = 4;
            this.NickName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NickName_KeyUp);
            this.NickName.Leave += new System.EventHandler(this.NickName_Leave);
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(526, 161);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(199, 20);
            this.Direccion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(137, 300);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(199, 20);
            this.Apellidos.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(526, 375);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(199, 20);
            this.Email.TabIndex = 9;
            this.Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Email_KeyUp);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Hombre
            // 
            this.Hombre.AutoSize = true;
            this.Hombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hombre.Location = new System.Drawing.Point(526, 298);
            this.Hombre.Name = "Hombre";
            this.Hombre.Size = new System.Drawing.Size(76, 24);
            this.Hombre.TabIndex = 7;
            this.Hombre.Text = "Hombre";
            this.Hombre.UseVisualStyleBackColor = true;
            this.Hombre.CheckedChanged += new System.EventHandler(this.Hombre_CheckedChanged);
            // 
            // Mujer
            // 
            this.Mujer.AutoSize = true;
            this.Mujer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mujer.Location = new System.Drawing.Point(664, 298);
            this.Mujer.Name = "Mujer";
            this.Mujer.Size = new System.Drawing.Size(61, 24);
            this.Mujer.TabIndex = 8;
            this.Mujer.Text = "Mujer";
            this.Mujer.UseVisualStyleBackColor = true;
            this.Mujer.CheckedChanged += new System.EventHandler(this.Mujer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha Nacimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Direccion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sexo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(0, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(798, 138);
            this.label4.TabIndex = 18;
            // 
            // BotonAlta
            // 
            this.BotonAlta.Location = new System.Drawing.Point(175, 453);
            this.BotonAlta.Name = "BotonAlta";
            this.BotonAlta.Size = new System.Drawing.Size(198, 37);
            this.BotonAlta.TabIndex = 10;
            this.BotonAlta.Text = "Dar de Alta";
            this.BotonAlta.UseVisualStyleBackColor = true;
            this.BotonAlta.Click += new System.EventHandler(this.BotonAlta_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "DNI";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dni
            // 
            this.Dni.Location = new System.Drawing.Point(137, 161);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(199, 20);
            this.Dni.TabIndex = 1;
            this.Dni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dni_KeyUp);
            this.Dni.Leave += new System.EventHandler(this.Dni_Leave);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(439, 453);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(199, 37);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // dniRegistrado
            // 
            this.dniRegistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniRegistrado.ForeColor = System.Drawing.Color.Red;
            this.dniRegistrado.Location = new System.Drawing.Point(137, 184);
            this.dniRegistrado.Name = "dniRegistrado";
            this.dniRegistrado.Size = new System.Drawing.Size(199, 23);
            this.dniRegistrado.TabIndex = 25;
            this.dniRegistrado.Text = "DNI REGISTRADO";
            this.dniRegistrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuarioRegistrado
            // 
            this.usuarioRegistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioRegistrado.ForeColor = System.Drawing.Color.Red;
            this.usuarioRegistrado.Location = new System.Drawing.Point(137, 400);
            this.usuarioRegistrado.Name = "usuarioRegistrado";
            this.usuarioRegistrado.Size = new System.Drawing.Size(199, 23);
            this.usuarioRegistrado.TabIndex = 26;
            this.usuarioRegistrado.Text = "USUARIO REGISTRADO";
            this.usuarioRegistrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailRegistrado
            // 
            this.emailRegistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegistrado.ForeColor = System.Drawing.Color.Red;
            this.emailRegistrado.Location = new System.Drawing.Point(526, 398);
            this.emailRegistrado.Name = "emailRegistrado";
            this.emailRegistrado.Size = new System.Drawing.Size(199, 23);
            this.emailRegistrado.TabIndex = 27;
            this.emailRegistrado.Text = "EMAIL REGISTRADO";
            this.emailRegistrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(525, 230);
            this.fechaNacimiento.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.fechaNacimiento.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "dialogoImagen";
            // 
            // VentanaNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.emailRegistrado);
            this.Controls.Add(this.usuarioRegistrado);
            this.Controls.Add(this.dniRegistrado);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.Dni);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BotonAlta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mujer);
            this.Controls.Add(this.Hombre);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.Nombre);
            this.Name = "VentanaNuevoUsuario";
            this.Text = "VentanaNuevoUsuario";
            this.Load += new System.EventHandler(this.VentanaNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.CheckBox Hombre;
        private System.Windows.Forms.CheckBox Mujer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BotonAlta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Dni;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label dniRegistrado;
        private System.Windows.Forms.Label usuarioRegistrado;
        private System.Windows.Forms.Label emailRegistrado;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}