namespace WindowsFormsApplication5
{
    partial class CalibracionRecicladocs
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
            this.label21 = new System.Windows.Forms.Label();
            this.PesodePruebaArriba = new System.Windows.Forms.Button();
            this.PesoPruebaAbajo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IndBasculaReciclado = new System.Windows.Forms.TextBox();
            this.TPH_HzReciclado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecicladoCalcularBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.AgregadoRecicladoOffBoton = new System.Windows.Forms.Button();
            this.AgregadoRecicladoOnBoton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.MotorTrituradoOffBoton = new System.Windows.Forms.Button();
            this.MotorTrituradoOnBoton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BandaRecicladoOffBoton = new System.Windows.Forms.Button();
            this.BandaRecicladoOnBoton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CompuertaRecicladoBotonRechazo = new System.Windows.Forms.Button();
            this.CompuertaRecicladoBotonSecador = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CeroBotonRec = new System.Windows.Forms.Button();
            this.SpamBotonRec = new System.Windows.Forms.Button();
            this.CalibrarBotonRec = new System.Windows.Forms.Button();
            this.Ind_mAmpRec = new System.Windows.Forms.Label();
            this.IndSpamRec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(437, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 26);
            this.label21.TabIndex = 125;
            this.label21.Text = "VERIFICACIÓN";
            // 
            // PesodePruebaArriba
            // 
            this.PesodePruebaArriba.Location = new System.Drawing.Point(531, 92);
            this.PesodePruebaArriba.Name = "PesodePruebaArriba";
            this.PesodePruebaArriba.Size = new System.Drawing.Size(85, 47);
            this.PesodePruebaArriba.TabIndex = 124;
            this.PesodePruebaArriba.Text = "Peso de Prueba \r\nARRIBA";
            this.PesodePruebaArriba.UseVisualStyleBackColor = true;
            this.PesodePruebaArriba.Click += new System.EventHandler(this.PesodePruebaArriba_Click);
            // 
            // PesoPruebaAbajo
            // 
            this.PesoPruebaAbajo.Location = new System.Drawing.Point(421, 92);
            this.PesoPruebaAbajo.Name = "PesoPruebaAbajo";
            this.PesoPruebaAbajo.Size = new System.Drawing.Size(85, 47);
            this.PesoPruebaAbajo.TabIndex = 123;
            this.PesoPruebaAbajo.Text = "Peso de Prueba \r\nABAJO";
            this.PesoPruebaAbajo.UseVisualStyleBackColor = true;
            this.PesoPruebaAbajo.Click += new System.EventHandler(this.PesoPruebaAbajo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 50);
            this.label3.TabIndex = 118;
            this.label3.Text = "Indicador Báscula\r\n de Reciclado\r\n";
            // 
            // IndBasculaReciclado
            // 
            this.IndBasculaReciclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndBasculaReciclado.Location = new System.Drawing.Point(225, 51);
            this.IndBasculaReciclado.Name = "IndBasculaReciclado";
            this.IndBasculaReciclado.Size = new System.Drawing.Size(116, 38);
            this.IndBasculaReciclado.TabIndex = 117;
            // 
            // TPH_HzReciclado
            // 
            this.TPH_HzReciclado.AutoSize = true;
            this.TPH_HzReciclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPH_HzReciclado.Location = new System.Drawing.Point(394, 198);
            this.TPH_HzReciclado.Name = "TPH_HzReciclado";
            this.TPH_HzReciclado.Size = new System.Drawing.Size(18, 20);
            this.TPH_HzReciclado.TabIndex = 116;
            this.TPH_HzReciclado.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "TPH por cada Hz: ";
            // 
            // RecicladoCalcularBoton
            // 
            this.RecicladoCalcularBoton.Location = new System.Drawing.Point(152, 194);
            this.RecicladoCalcularBoton.Name = "RecicladoCalcularBoton";
            this.RecicladoCalcularBoton.Size = new System.Drawing.Size(94, 31);
            this.RecicladoCalcularBoton.TabIndex = 114;
            this.RecicladoCalcularBoton.Text = "Calcular";
            this.RecicladoCalcularBoton.UseVisualStyleBackColor = true;
            this.RecicladoCalcularBoton.Click += new System.EventHandler(this.RecicladoCalcularBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "RECICLADO";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label28.Location = new System.Drawing.Point(228, 303);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 34);
            this.label28.TabIndex = 137;
            this.label28.Text = "AGG.RE CICLADO";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregadoRecicladoOffBoton
            // 
            this.AgregadoRecicladoOffBoton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AgregadoRecicladoOffBoton.Location = new System.Drawing.Point(234, 337);
            this.AgregadoRecicladoOffBoton.Name = "AgregadoRecicladoOffBoton";
            this.AgregadoRecicladoOffBoton.Size = new System.Drawing.Size(42, 33);
            this.AgregadoRecicladoOffBoton.TabIndex = 136;
            this.AgregadoRecicladoOffBoton.Text = "OFF";
            this.AgregadoRecicladoOffBoton.UseVisualStyleBackColor = true;
            this.AgregadoRecicladoOffBoton.Click += new System.EventHandler(this.AgregadoRecicladoOffBoton_Click);
            // 
            // AgregadoRecicladoOnBoton
            // 
            this.AgregadoRecicladoOnBoton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AgregadoRecicladoOnBoton.Location = new System.Drawing.Point(231, 264);
            this.AgregadoRecicladoOnBoton.Name = "AgregadoRecicladoOnBoton";
            this.AgregadoRecicladoOnBoton.Size = new System.Drawing.Size(42, 33);
            this.AgregadoRecicladoOnBoton.TabIndex = 135;
            this.AgregadoRecicladoOnBoton.Text = "ON";
            this.AgregadoRecicladoOnBoton.UseVisualStyleBackColor = true;
            this.AgregadoRecicladoOnBoton.Click += new System.EventHandler(this.AgregadoRecicladoOnBoton_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label11.Location = new System.Drawing.Point(163, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 34);
            this.label11.TabIndex = 134;
            this.label11.Text = "SCAL PER";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MotorTrituradoOffBoton
            // 
            this.MotorTrituradoOffBoton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MotorTrituradoOffBoton.Location = new System.Drawing.Point(166, 338);
            this.MotorTrituradoOffBoton.Name = "MotorTrituradoOffBoton";
            this.MotorTrituradoOffBoton.Size = new System.Drawing.Size(42, 33);
            this.MotorTrituradoOffBoton.TabIndex = 133;
            this.MotorTrituradoOffBoton.Text = "OFF";
            this.MotorTrituradoOffBoton.UseVisualStyleBackColor = true;
            this.MotorTrituradoOffBoton.Click += new System.EventHandler(this.MotorTrituradoOffBoton_Click);
            // 
            // MotorTrituradoOnBoton
            // 
            this.MotorTrituradoOnBoton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MotorTrituradoOnBoton.Location = new System.Drawing.Point(166, 265);
            this.MotorTrituradoOnBoton.Name = "MotorTrituradoOnBoton";
            this.MotorTrituradoOnBoton.Size = new System.Drawing.Size(42, 33);
            this.MotorTrituradoOnBoton.TabIndex = 132;
            this.MotorTrituradoOnBoton.Text = "ON";
            this.MotorTrituradoOnBoton.UseVisualStyleBackColor = true;
            this.MotorTrituradoOnBoton.Click += new System.EventHandler(this.MotorTrituradoOnBoton_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label10.Location = new System.Drawing.Point(106, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 34);
            this.label10.TabIndex = 131;
            this.label10.Text = "B. INCL RECICLADO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BandaRecicladoOffBoton
            // 
            this.BandaRecicladoOffBoton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BandaRecicladoOffBoton.Location = new System.Drawing.Point(109, 338);
            this.BandaRecicladoOffBoton.Name = "BandaRecicladoOffBoton";
            this.BandaRecicladoOffBoton.Size = new System.Drawing.Size(42, 33);
            this.BandaRecicladoOffBoton.TabIndex = 130;
            this.BandaRecicladoOffBoton.Text = "OFF";
            this.BandaRecicladoOffBoton.UseVisualStyleBackColor = true;
            this.BandaRecicladoOffBoton.Click += new System.EventHandler(this.BandaRecicladoOffBoton_Click);
            // 
            // BandaRecicladoOnBoton
            // 
            this.BandaRecicladoOnBoton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BandaRecicladoOnBoton.Location = new System.Drawing.Point(109, 265);
            this.BandaRecicladoOnBoton.Name = "BandaRecicladoOnBoton";
            this.BandaRecicladoOnBoton.Size = new System.Drawing.Size(42, 33);
            this.BandaRecicladoOnBoton.TabIndex = 129;
            this.BandaRecicladoOnBoton.Text = "ON";
            this.BandaRecicladoOnBoton.UseVisualStyleBackColor = true;
            this.BandaRecicladoOnBoton.Click += new System.EventHandler(this.BandaRecicladoOnBoton_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label8.Location = new System.Drawing.Point(44, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 34);
            this.label8.TabIndex = 128;
            this.label8.Text = "COMP. RECICLADO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompuertaRecicladoBotonRechazo
            // 
            this.CompuertaRecicladoBotonRechazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.CompuertaRecicladoBotonRechazo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompuertaRecicladoBotonRechazo.Location = new System.Drawing.Point(47, 338);
            this.CompuertaRecicladoBotonRechazo.Name = "CompuertaRecicladoBotonRechazo";
            this.CompuertaRecicladoBotonRechazo.Size = new System.Drawing.Size(42, 33);
            this.CompuertaRecicladoBotonRechazo.TabIndex = 127;
            this.CompuertaRecicladoBotonRechazo.Text = "RECHAZO";
            this.CompuertaRecicladoBotonRechazo.UseVisualStyleBackColor = true;
            this.CompuertaRecicladoBotonRechazo.Click += new System.EventHandler(this.CompuertaRecicladoBotonRechazo_Click);
            // 
            // CompuertaRecicladoBotonSecador
            // 
            this.CompuertaRecicladoBotonSecador.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.CompuertaRecicladoBotonSecador.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CompuertaRecicladoBotonSecador.Location = new System.Drawing.Point(47, 265);
            this.CompuertaRecicladoBotonSecador.Name = "CompuertaRecicladoBotonSecador";
            this.CompuertaRecicladoBotonSecador.Size = new System.Drawing.Size(42, 33);
            this.CompuertaRecicladoBotonSecador.TabIndex = 126;
            this.CompuertaRecicladoBotonSecador.Text = "SECADOR";
            this.CompuertaRecicladoBotonSecador.UseVisualStyleBackColor = true;
            this.CompuertaRecicladoBotonSecador.Click += new System.EventHandler(this.CompuertaRecicladoBotonSecador_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label15.Location = new System.Drawing.Point(587, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 25);
            this.label15.TabIndex = 143;
            this.label15.Text = "TPH";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label12.Location = new System.Drawing.Point(478, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 141;
            this.label12.Text = "mA";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // CeroBotonRec
            // 
            this.CeroBotonRec.Location = new System.Drawing.Point(422, 301);
            this.CeroBotonRec.Name = "CeroBotonRec";
            this.CeroBotonRec.Size = new System.Drawing.Size(75, 23);
            this.CeroBotonRec.TabIndex = 145;
            this.CeroBotonRec.Text = "CERO";
            this.CeroBotonRec.UseVisualStyleBackColor = true;
            this.CeroBotonRec.Click += new System.EventHandler(this.CeroBotonRec_Click);
            // 
            // SpamBotonRec
            // 
            this.SpamBotonRec.Location = new System.Drawing.Point(553, 300);
            this.SpamBotonRec.Name = "SpamBotonRec";
            this.SpamBotonRec.Size = new System.Drawing.Size(75, 23);
            this.SpamBotonRec.TabIndex = 146;
            this.SpamBotonRec.Text = "SPAM";
            this.SpamBotonRec.UseVisualStyleBackColor = true;
            this.SpamBotonRec.Click += new System.EventHandler(this.SpamBotonRec_Click);
            // 
            // CalibrarBotonRec
            // 
            this.CalibrarBotonRec.Location = new System.Drawing.Point(467, 347);
            this.CalibrarBotonRec.Name = "CalibrarBotonRec";
            this.CalibrarBotonRec.Size = new System.Drawing.Size(75, 23);
            this.CalibrarBotonRec.TabIndex = 147;
            this.CalibrarBotonRec.Text = "CALIBRAR";
            this.CalibrarBotonRec.UseVisualStyleBackColor = true;
            this.CalibrarBotonRec.Click += new System.EventHandler(this.CalibrarBotonRec_Click);
            // 
            // Ind_mAmpRec
            // 
            this.Ind_mAmpRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Ind_mAmpRec.ForeColor = System.Drawing.Color.DarkGreen;
            this.Ind_mAmpRec.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Ind_mAmpRec.Location = new System.Drawing.Point(419, 395);
            this.Ind_mAmpRec.Name = "Ind_mAmpRec";
            this.Ind_mAmpRec.Size = new System.Drawing.Size(53, 22);
            this.Ind_mAmpRec.TabIndex = 148;
            this.Ind_mAmpRec.Text = "--------";
            // 
            // IndSpamRec
            // 
            this.IndSpamRec.Location = new System.Drawing.Point(481, 234);
            this.IndSpamRec.Name = "IndSpamRec";
            this.IndSpamRec.Size = new System.Drawing.Size(100, 20);
            this.IndSpamRec.TabIndex = 149;
            // 
            // CalibracionRecicladocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 421);
            this.Controls.Add(this.IndSpamRec);
            this.Controls.Add(this.Ind_mAmpRec);
            this.Controls.Add(this.CalibrarBotonRec);
            this.Controls.Add(this.SpamBotonRec);
            this.Controls.Add(this.CeroBotonRec);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.AgregadoRecicladoOffBoton);
            this.Controls.Add(this.AgregadoRecicladoOnBoton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MotorTrituradoOffBoton);
            this.Controls.Add(this.MotorTrituradoOnBoton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BandaRecicladoOffBoton);
            this.Controls.Add(this.BandaRecicladoOnBoton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CompuertaRecicladoBotonRechazo);
            this.Controls.Add(this.CompuertaRecicladoBotonSecador);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.PesodePruebaArriba);
            this.Controls.Add(this.PesoPruebaAbajo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IndBasculaReciclado);
            this.Controls.Add(this.TPH_HzReciclado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecicladoCalcularBoton);
            this.Controls.Add(this.label1);
            this.Name = "CalibracionRecicladocs";
            this.Text = "CalibracionRecicladocs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalibracionRecicladocs_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button PesodePruebaArriba;
        private System.Windows.Forms.Button PesoPruebaAbajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IndBasculaReciclado;
        private System.Windows.Forms.Label TPH_HzReciclado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RecicladoCalcularBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button AgregadoRecicladoOffBoton;
        private System.Windows.Forms.Button AgregadoRecicladoOnBoton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button MotorTrituradoOffBoton;
        private System.Windows.Forms.Button MotorTrituradoOnBoton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BandaRecicladoOffBoton;
        private System.Windows.Forms.Button BandaRecicladoOnBoton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CompuertaRecicladoBotonRechazo;
        private System.Windows.Forms.Button CompuertaRecicladoBotonSecador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button CeroBotonRec;
        private System.Windows.Forms.Button SpamBotonRec;
        private System.Windows.Forms.Button CalibrarBotonRec;
        private System.Windows.Forms.Label Ind_mAmpRec;
        private System.Windows.Forms.TextBox IndSpamRec;
    }
}