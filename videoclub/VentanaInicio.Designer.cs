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
            this.SuspendLayout();
            // 
            // desplegableActores
            // 
            this.desplegableActores.FormattingEnabled = true;
            this.desplegableActores.Location = new System.Drawing.Point(109, 75);
            this.desplegableActores.Name = "desplegableActores";
            this.desplegableActores.Size = new System.Drawing.Size(121, 21);
            this.desplegableActores.TabIndex = 0;
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.desplegableActores);
            this.Name = "VentanaInicio";
            this.Text = "VentanaInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableActores;
    }
}