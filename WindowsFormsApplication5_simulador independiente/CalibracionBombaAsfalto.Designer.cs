﻿namespace WindowsFormsApplication5
{
    partial class CalibracionBombaAsfalto
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
            this.label3 = new System.Windows.Forms.Label();
            this.IndBasculaAsfalto = new System.Windows.Forms.TextBox();
            this.TPH_HzAsfalto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AsfaltoCalcularBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BombaAsfaltoAtrasBoton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.BombaAsfaltoStopBoton = new System.Windows.Forms.Button();
            this.BombaAsfaltoAdelanteBoton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RetornoBoton = new System.Windows.Forms.Button();
            this.BasculaBoton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.IngTiempoDesfaseAsfalto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 50);
            this.label3.TabIndex = 143;
            this.label3.Text = "Indicador Báscula\r\n de Asfalto";
            // 
            // IndBasculaAsfalto
            // 
            this.IndBasculaAsfalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndBasculaAsfalto.Location = new System.Drawing.Point(250, 39);
            this.IndBasculaAsfalto.Name = "IndBasculaAsfalto";
            this.IndBasculaAsfalto.Size = new System.Drawing.Size(116, 38);
            this.IndBasculaAsfalto.TabIndex = 142;
            // 
            // TPH_HzAsfalto
            // 
            this.TPH_HzAsfalto.AutoSize = true;
            this.TPH_HzAsfalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPH_HzAsfalto.Location = new System.Drawing.Point(403, 120);
            this.TPH_HzAsfalto.Name = "TPH_HzAsfalto";
            this.TPH_HzAsfalto.Size = new System.Drawing.Size(18, 20);
            this.TPH_HzAsfalto.TabIndex = 141;
            this.TPH_HzAsfalto.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 140;
            this.label2.Text = "TPH por cada Hz: ";
            // 
            // AsfaltoCalcularBoton
            // 
            this.AsfaltoCalcularBoton.Location = new System.Drawing.Point(161, 116);
            this.AsfaltoCalcularBoton.Name = "AsfaltoCalcularBoton";
            this.AsfaltoCalcularBoton.Size = new System.Drawing.Size(94, 31);
            this.AsfaltoCalcularBoton.TabIndex = 139;
            this.AsfaltoCalcularBoton.Text = "Calcular";
            this.AsfaltoCalcularBoton.UseVisualStyleBackColor = true;
            this.AsfaltoCalcularBoton.Click += new System.EventHandler(this.AsfaltoCalcularBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 138;
            this.label1.Text = "ASFALTO";
            // 
            // BombaAsfaltoAtrasBoton
            // 
            this.BombaAsfaltoAtrasBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BombaAsfaltoAtrasBoton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BombaAsfaltoAtrasBoton.Location = new System.Drawing.Point(86, 302);
            this.BombaAsfaltoAtrasBoton.Name = "BombaAsfaltoAtrasBoton";
            this.BombaAsfaltoAtrasBoton.Size = new System.Drawing.Size(89, 29);
            this.BombaAsfaltoAtrasBoton.TabIndex = 150;
            this.BombaAsfaltoAtrasBoton.Text = "ATRAS";
            this.BombaAsfaltoAtrasBoton.UseVisualStyleBackColor = true;
            this.BombaAsfaltoAtrasBoton.Click += new System.EventHandler(this.BombaAsfaltoAtrasBoton_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label20.Location = new System.Drawing.Point(104, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 34);
            this.label20.TabIndex = 149;
            this.label20.Text = "BOMBA ASFALTO";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BombaAsfaltoStopBoton
            // 
            this.BombaAsfaltoStopBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BombaAsfaltoStopBoton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BombaAsfaltoStopBoton.Location = new System.Drawing.Point(86, 263);
            this.BombaAsfaltoStopBoton.Name = "BombaAsfaltoStopBoton";
            this.BombaAsfaltoStopBoton.Size = new System.Drawing.Size(89, 33);
            this.BombaAsfaltoStopBoton.TabIndex = 148;
            this.BombaAsfaltoStopBoton.Text = "STOP";
            this.BombaAsfaltoStopBoton.UseVisualStyleBackColor = true;
            this.BombaAsfaltoStopBoton.Click += new System.EventHandler(this.BombaAsfaltoStopBoton_Click);
            // 
            // BombaAsfaltoAdelanteBoton
            // 
            this.BombaAsfaltoAdelanteBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BombaAsfaltoAdelanteBoton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BombaAsfaltoAdelanteBoton.Location = new System.Drawing.Point(86, 191);
            this.BombaAsfaltoAdelanteBoton.Name = "BombaAsfaltoAdelanteBoton";
            this.BombaAsfaltoAdelanteBoton.Size = new System.Drawing.Size(89, 33);
            this.BombaAsfaltoAdelanteBoton.TabIndex = 147;
            this.BombaAsfaltoAdelanteBoton.Text = "ADELANTE";
            this.BombaAsfaltoAdelanteBoton.UseVisualStyleBackColor = true;
            this.BombaAsfaltoAdelanteBoton.Click += new System.EventHandler(this.BombaAsfaltoAdelanteBoton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label4.Location = new System.Drawing.Point(263, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.TabIndex = 153;
            this.label4.Text = "BÁSCULA ASFALTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RetornoBoton
            // 
            this.RetornoBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RetornoBoton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetornoBoton.Location = new System.Drawing.Point(250, 283);
            this.RetornoBoton.Name = "RetornoBoton";
            this.RetornoBoton.Size = new System.Drawing.Size(90, 48);
            this.RetornoBoton.TabIndex = 152;
            this.RetornoBoton.Text = "RETORNO";
            this.RetornoBoton.UseVisualStyleBackColor = true;
            this.RetornoBoton.Click += new System.EventHandler(this.RetornoBoton_Click);
            // 
            // BasculaBoton
            // 
            this.BasculaBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BasculaBoton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BasculaBoton.Location = new System.Drawing.Point(250, 191);
            this.BasculaBoton.Name = "BasculaBoton";
            this.BasculaBoton.Size = new System.Drawing.Size(90, 52);
            this.BasculaBoton.TabIndex = 151;
            this.BasculaBoton.Text = "FLUJO POR BÁSCULA";
            this.BasculaBoton.UseVisualStyleBackColor = true;
            this.BasculaBoton.Click += new System.EventHandler(this.BasculaBoton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Honeydew;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(391, 190);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 34);
            this.label24.TabIndex = 155;
            this.label24.Text = "Tiempo\r\nDesfase (seg)";
            // 
            // IngTiempoDesfaseAsfalto
            // 
            this.IngTiempoDesfaseAsfalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngTiempoDesfaseAsfalto.Location = new System.Drawing.Point(394, 227);
            this.IngTiempoDesfaseAsfalto.Name = "IngTiempoDesfaseAsfalto";
            this.IngTiempoDesfaseAsfalto.Size = new System.Drawing.Size(72, 26);
            this.IngTiempoDesfaseAsfalto.TabIndex = 154;
            // 
            // CalibracionBombaAsfalto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 364);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.IngTiempoDesfaseAsfalto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RetornoBoton);
            this.Controls.Add(this.BasculaBoton);
            this.Controls.Add(this.BombaAsfaltoAtrasBoton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.BombaAsfaltoStopBoton);
            this.Controls.Add(this.BombaAsfaltoAdelanteBoton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IndBasculaAsfalto);
            this.Controls.Add(this.TPH_HzAsfalto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AsfaltoCalcularBoton);
            this.Controls.Add(this.label1);
            this.Name = "CalibracionBombaAsfalto";
            this.Text = "CalibracionBombaAsfalto";
            this.Load += new System.EventHandler(this.CalibracionBombaAsfalto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IndBasculaAsfalto;
        private System.Windows.Forms.Label TPH_HzAsfalto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AsfaltoCalcularBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BombaAsfaltoAtrasBoton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BombaAsfaltoStopBoton;
        private System.Windows.Forms.Button BombaAsfaltoAdelanteBoton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RetornoBoton;
        private System.Windows.Forms.Button BasculaBoton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox IngTiempoDesfaseAsfalto;
    }
}