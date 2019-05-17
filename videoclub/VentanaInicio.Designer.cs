namespace videoclub
{
    partial class VentanaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicio));
            this.desplegableGeneros = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.desplegableBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioEntrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevoUsuarioEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInfoPeli = new System.Windows.Forms.Panel();
            this.stockPeli = new System.Windows.Forms.Label();
            this.rankingPeli = new System.Windows.Forms.Label();
            this.yearPeli = new System.Windows.Forms.Label();
            this.nombrePeli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlquilarPeli = new System.Windows.Forms.Button();
            this.btnMostrarAlquileres = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.desplegableSociosVideoclub = new System.Windows.Forms.ComboBox();
            this.panelAlquileres = new System.Windows.Forms.Panel();
            this.labelAlquileres = new System.Windows.Forms.Label();
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.cerrarAlquileres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInfoPeli.SuspendLayout();
            this.panelAlquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // desplegableGeneros
            // 
            this.desplegableGeneros.FormattingEnabled = true;
            this.desplegableGeneros.Location = new System.Drawing.Point(11, 92);
            this.desplegableGeneros.Name = "desplegableGeneros";
            this.desplegableGeneros.Size = new System.Drawing.Size(202, 21);
            this.desplegableGeneros.TabIndex = 0;
            this.desplegableGeneros.SelectionChangeCommitted += new System.EventHandler(this.desplegableActores_SelectionChangeCommitted);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // desplegableBusqueda
            // 
            this.desplegableBusqueda.FormattingEnabled = true;
            this.desplegableBusqueda.Location = new System.Drawing.Point(246, 92);
            this.desplegableBusqueda.Name = "desplegableBusqueda";
            this.desplegableBusqueda.Size = new System.Drawing.Size(205, 21);
            this.desplegableBusqueda.TabIndex = 2;
            this.desplegableBusqueda.SelectedIndexChanged += new System.EventHandler(this.desplegableBusqueda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Socios Videoclub";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuarioEntrar
            // 
            this.usuarioEntrar.Location = new System.Drawing.Point(457, 187);
            this.usuarioEntrar.Name = "usuarioEntrar";
            this.usuarioEntrar.Size = new System.Drawing.Size(146, 32);
            this.usuarioEntrar.TabIndex = 4;
            this.usuarioEntrar.Text = "Entrar";
            this.usuarioEntrar.UseVisualStyleBackColor = true;
            this.usuarioEntrar.Click += new System.EventHandler(this.usuarioEntrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo Socio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nuevoUsuarioEntrar
            // 
            this.nuevoUsuarioEntrar.Location = new System.Drawing.Point(457, 279);
            this.nuevoUsuarioEntrar.Name = "nuevoUsuarioEntrar";
            this.nuevoUsuarioEntrar.Size = new System.Drawing.Size(146, 31);
            this.nuevoUsuarioEntrar.TabIndex = 6;
            this.nuevoUsuarioEntrar.Text = "Entrar";
            this.nuevoUsuarioEntrar.UseVisualStyleBackColor = true;
            this.nuevoUsuarioEntrar.Click += new System.EventHandler(this.nuevoUsuarioEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelInfoPeli
            // 
            this.panelInfoPeli.BackColor = System.Drawing.Color.Transparent;
            this.panelInfoPeli.Controls.Add(this.stockPeli);
            this.panelInfoPeli.Controls.Add(this.rankingPeli);
            this.panelInfoPeli.Controls.Add(this.yearPeli);
            this.panelInfoPeli.Controls.Add(this.nombrePeli);
            this.panelInfoPeli.Controls.Add(this.label5);
            this.panelInfoPeli.Controls.Add(this.label6);
            this.panelInfoPeli.Controls.Add(this.label3);
            this.panelInfoPeli.Controls.Add(this.label4);
            this.panelInfoPeli.Location = new System.Drawing.Point(12, 119);
            this.panelInfoPeli.Name = "panelInfoPeli";
            this.panelInfoPeli.Size = new System.Drawing.Size(439, 213);
            this.panelInfoPeli.TabIndex = 8;
            // 
            // stockPeli
            // 
            this.stockPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPeli.Location = new System.Drawing.Point(155, 145);
            this.stockPeli.Name = "stockPeli";
            this.stockPeli.Size = new System.Drawing.Size(265, 23);
            this.stockPeli.TabIndex = 7;
            this.stockPeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankingPeli
            // 
            this.rankingPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingPeli.Location = new System.Drawing.Point(155, 111);
            this.rankingPeli.Name = "rankingPeli";
            this.rankingPeli.Size = new System.Drawing.Size(265, 23);
            this.rankingPeli.TabIndex = 6;
            this.rankingPeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearPeli
            // 
            this.yearPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPeli.Location = new System.Drawing.Point(155, 77);
            this.yearPeli.Name = "yearPeli";
            this.yearPeli.Size = new System.Drawing.Size(265, 23);
            this.yearPeli.TabIndex = 5;
            this.yearPeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombrePeli
            // 
            this.nombrePeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePeli.Location = new System.Drawing.Point(164, 43);
            this.nombrePeli.Name = "nombrePeli";
            this.nombrePeli.Size = new System.Drawing.Size(268, 23);
            this.nombrePeli.TabIndex = 4;
            this.nombrePeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stock:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ranking IMDB:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Año Emisión:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlquilarPeli
            // 
            this.btnAlquilarPeli.Location = new System.Drawing.Point(12, 377);
            this.btnAlquilarPeli.Name = "btnAlquilarPeli";
            this.btnAlquilarPeli.Size = new System.Drawing.Size(201, 43);
            this.btnAlquilarPeli.TabIndex = 9;
            this.btnAlquilarPeli.Text = "Alquilar";
            this.btnAlquilarPeli.UseVisualStyleBackColor = true;
            this.btnAlquilarPeli.Click += new System.EventHandler(this.btnAlquilarPeli_Click);
            // 
            // btnMostrarAlquileres
            // 
            this.btnMostrarAlquileres.Location = new System.Drawing.Point(250, 377);
            this.btnMostrarAlquileres.Name = "btnMostrarAlquileres";
            this.btnMostrarAlquileres.Size = new System.Drawing.Size(201, 43);
            this.btnMostrarAlquileres.TabIndex = 10;
            this.btnMostrarAlquileres.Text = "Mostrar Alquileres";
            this.btnMostrarAlquileres.UseVisualStyleBackColor = true;
            this.btnMostrarAlquileres.Click += new System.EventHandler(this.btnMostrarAlquileres_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Socio que alquila:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desplegableSociosVideoclub
            // 
            this.desplegableSociosVideoclub.FormattingEnabled = true;
            this.desplegableSociosVideoclub.Location = new System.Drawing.Point(169, 338);
            this.desplegableSociosVideoclub.Name = "desplegableSociosVideoclub";
            this.desplegableSociosVideoclub.Size = new System.Drawing.Size(282, 21);
            this.desplegableSociosVideoclub.TabIndex = 11;
            // 
            // panelAlquileres
            // 
            this.panelAlquileres.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelAlquileres.Controls.Add(this.labelAlquileres);
            this.panelAlquileres.Controls.Add(this.dataGridViewAlquileres);
            this.panelAlquileres.Controls.Add(this.cerrarAlquileres);
            this.panelAlquileres.Location = new System.Drawing.Point(11, 92);
            this.panelAlquileres.Name = "panelAlquileres";
            this.panelAlquileres.Size = new System.Drawing.Size(592, 328);
            this.panelAlquileres.TabIndex = 12;
            // 
            // labelAlquileres
            // 
            this.labelAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlquileres.Location = new System.Drawing.Point(5, 3);
            this.labelAlquileres.Name = "labelAlquileres";
            this.labelAlquileres.Size = new System.Drawing.Size(439, 36);
            this.labelAlquileres.TabIndex = 2;
            this.labelAlquileres.Text = "Alquileres de: ";
            this.labelAlquileres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.AllowUserToAddRows = false;
            this.dataGridViewAlquileres.AllowUserToDeleteRows = false;
            this.dataGridViewAlquileres.AllowUserToOrderColumns = true;
            this.dataGridViewAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(5, 42);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.ReadOnly = true;
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(584, 283);
            this.dataGridViewAlquileres.TabIndex = 1;
            // 
            // cerrarAlquileres
            // 
            this.cerrarAlquileres.Location = new System.Drawing.Point(450, 3);
            this.cerrarAlquileres.Name = "cerrarAlquileres";
            this.cerrarAlquileres.Size = new System.Drawing.Size(139, 36);
            this.cerrarAlquileres.TabIndex = 0;
            this.cerrarAlquileres.Text = "Cerrar";
            this.cerrarAlquileres.UseVisualStyleBackColor = true;
            this.cerrarAlquileres.Click += new System.EventHandler(this.cerrarAlquileres_Click);
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.desplegableSociosVideoclub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMostrarAlquileres);
            this.Controls.Add(this.btnAlquilarPeli);
            this.Controls.Add(this.panelInfoPeli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nuevoUsuarioEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuarioEntrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desplegableBusqueda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.desplegableGeneros);
            this.Controls.Add(this.panelAlquileres);
            this.Name = "VentanaInicio";
            this.Text = "VentanaInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInfoPeli.ResumeLayout(false);
            this.panelAlquileres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableGeneros;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox desplegableBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button usuarioEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nuevoUsuarioEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInfoPeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stockPeli;
        private System.Windows.Forms.Label rankingPeli;
        private System.Windows.Forms.Label yearPeli;
        private System.Windows.Forms.Label nombrePeli;
        private System.Windows.Forms.Button btnAlquilarPeli;
        private System.Windows.Forms.Button btnMostrarAlquileres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox desplegableSociosVideoclub;
        private System.Windows.Forms.Panel panelAlquileres;
        private System.Windows.Forms.Button cerrarAlquileres;
        private System.Windows.Forms.Label labelAlquileres;
        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
    }
}