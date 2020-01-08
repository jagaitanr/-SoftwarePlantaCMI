namespace WindowsFormsApplication5
{
    partial class ConfigPuertoSerial
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.EnviarBoton = new System.Windows.Forms.Button();
            this.Datos_a_Enviar = new System.Windows.Forms.TextBox();
            this.DatosRecibidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puertos Disponibles";
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(151, 30);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(121, 21);
            this.cmbPuertos.TabIndex = 1;
            this.cmbPuertos.SelectedIndexChanged += new System.EventHandler(this.cmbPuertos_SelectedIndexChanged);
            // 
            // EnviarBoton
            // 
            this.EnviarBoton.Location = new System.Drawing.Point(15, 90);
            this.EnviarBoton.Name = "EnviarBoton";
            this.EnviarBoton.Size = new System.Drawing.Size(101, 24);
            this.EnviarBoton.TabIndex = 2;
            this.EnviarBoton.Text = "Enviar";
            this.EnviarBoton.UseVisualStyleBackColor = true;
            this.EnviarBoton.Click += new System.EventHandler(this.EnviarBoton_Click);
            // 
            // Datos_a_Enviar
            // 
            this.Datos_a_Enviar.Location = new System.Drawing.Point(152, 95);
            this.Datos_a_Enviar.Name = "Datos_a_Enviar";
            this.Datos_a_Enviar.Size = new System.Drawing.Size(106, 20);
            this.Datos_a_Enviar.TabIndex = 3;
            // 
            // DatosRecibidos
            // 
            this.DatosRecibidos.Location = new System.Drawing.Point(152, 147);
            this.DatosRecibidos.Name = "DatosRecibidos";
            this.DatosRecibidos.Size = new System.Drawing.Size(199, 20);
            this.DatosRecibidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos Recibidos";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ConfigPuertoSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.DatosRecibidos);
            this.Controls.Add(this.Datos_a_Enviar);
            this.Controls.Add(this.EnviarBoton);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigPuertoSerial";
            this.Text = "ConfigPuertoSerial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigPuertoSerial_FormClosing);
            this.Load += new System.EventHandler(this.ConfigPuertoSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Button EnviarBoton;
        private System.Windows.Forms.TextBox Datos_a_Enviar;
        private System.Windows.Forms.TextBox DatosRecibidos;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}