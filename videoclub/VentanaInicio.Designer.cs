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
            this.desplegableActores = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.desplegableBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioEntrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevoUsuarioEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desplegableActores
            // 
            this.desplegableActores.FormattingEnabled = true;
            this.desplegableActores.Location = new System.Drawing.Point(26, 112);
            this.desplegableActores.Name = "desplegableActores";
            this.desplegableActores.Size = new System.Drawing.Size(202, 21);
            this.desplegableActores.TabIndex = 0;
            this.desplegableActores.SelectionChangeCommitted += new System.EventHandler(this.desplegableActores_SelectionChangeCommitted);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // desplegableBusqueda
            // 
            this.desplegableBusqueda.FormattingEnabled = true;
            this.desplegableBusqueda.Location = new System.Drawing.Point(257, 112);
            this.desplegableBusqueda.Name = "desplegableBusqueda";
            this.desplegableBusqueda.Size = new System.Drawing.Size(205, 21);
            this.desplegableBusqueda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuarioEntrar
            // 
            this.usuarioEntrar.Location = new System.Drawing.Point(528, 212);
            this.usuarioEntrar.Name = "usuarioEntrar";
            this.usuarioEntrar.Size = new System.Drawing.Size(48, 32);
            this.usuarioEntrar.TabIndex = 4;
            this.usuarioEntrar.Text = "Entrar";
            this.usuarioEntrar.UseVisualStyleBackColor = true;
            this.usuarioEntrar.Click += new System.EventHandler(this.usuarioEntrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nuevoUsuarioEntrar
            // 
            this.nuevoUsuarioEntrar.Location = new System.Drawing.Point(528, 327);
            this.nuevoUsuarioEntrar.Name = "nuevoUsuarioEntrar";
            this.nuevoUsuarioEntrar.Size = new System.Drawing.Size(48, 31);
            this.nuevoUsuarioEntrar.TabIndex = 6;
            this.nuevoUsuarioEntrar.Text = "Entrar";
            this.nuevoUsuarioEntrar.UseVisualStyleBackColor = true;
            this.nuevoUsuarioEntrar.Click += new System.EventHandler(this.nuevoUsuarioEntrar_Click);
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.nuevoUsuarioEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuarioEntrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desplegableBusqueda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.desplegableActores);
            this.Name = "VentanaInicio";
            this.Text = "VentanaInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableActores;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox desplegableBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button usuarioEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nuevoUsuarioEntrar;
    }
}