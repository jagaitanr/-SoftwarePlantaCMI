namespace WindowsFormsApplication5
{
    partial class Ingreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxBxUsuario = new System.Windows.Forms.TextBox();
            this.TxBxContraseña = new System.Windows.Forms.TextBox();
            this.Boton_Verificación_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Planta de Asfalto CMI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sistema semi-automático con ARDUINO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxBxUsuario
            // 
            this.TxBxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxUsuario.Location = new System.Drawing.Point(131, 137);
            this.TxBxUsuario.Name = "TxBxUsuario";
            this.TxBxUsuario.Size = new System.Drawing.Size(188, 29);
            this.TxBxUsuario.TabIndex = 4;
            // 
            // TxBxContraseña
            // 
            this.TxBxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxContraseña.Location = new System.Drawing.Point(153, 252);
            this.TxBxContraseña.Name = "TxBxContraseña";
            this.TxBxContraseña.Size = new System.Drawing.Size(188, 29);
            this.TxBxContraseña.TabIndex = 5;
            this.TxBxContraseña.UseSystemPasswordChar = true;
            // 
            // Boton_Verificación_usuario
            // 
            this.Boton_Verificación_usuario.AutoSize = true;
            this.Boton_Verificación_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Verificación_usuario.Location = new System.Drawing.Point(332, 308);
            this.Boton_Verificación_usuario.Name = "Boton_Verificación_usuario";
            this.Boton_Verificación_usuario.Size = new System.Drawing.Size(101, 42);
            this.Boton_Verificación_usuario.TabIndex = 6;
            this.Boton_Verificación_usuario.Text = "Ingresar";
            this.Boton_Verificación_usuario.UseVisualStyleBackColor = true;
            this.Boton_Verificación_usuario.Click += new System.EventHandler(this.Boton_Verificación_usuario_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.Boton_Verificación_usuario);
            this.Controls.Add(this.TxBxContraseña);
            this.Controls.Add(this.TxBxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ingreso";
            this.Text = "Registro de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxBxUsuario;
        private System.Windows.Forms.TextBox TxBxContraseña;
        private System.Windows.Forms.Button Boton_Verificación_usuario;
    }
}

