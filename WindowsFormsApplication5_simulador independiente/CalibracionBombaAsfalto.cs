using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class CalibracionBombaAsfalto : Form
    {
        public CalibracionBombaAsfalto()
        {
            InitializeComponent();
        }

        private void AsfaltoCalcularBoton_Click(object sender, EventArgs e)
        {
            try
            {
                VariablesGlobales.IndicadorBasculaAsfalto = double.Parse(IndBasculaAsfalto.Text);// conversión de string a double
                VariablesGlobales.TPH_HzAsfalto = (VariablesGlobales.IndicadorBasculaAsfalto/ 48);
                TPH_HzAsfalto.Text = VariablesGlobales.TPH_HzAsfalto.ToString();
                VariablesGlobales.TiempoDesfaseAsfalto = int.Parse(IngTiempoDesfaseAsfalto.Text);
            }
            catch (System.FormatException) //captura del error por llenado de campos con texto y no numeros
            {
                MessageBox.Show("Todos los campos requieren números, \n corrija error o verifique datos del indicador");
            }
        }

        private void BombaAsfaltoAdelanteBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BombaAsfaltoAtras = 0;
            MotoresGlobales.BombaAsfaltoAdelante = 1;
        }

        private void BombaAsfaltoStopBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BombaAsfaltoAtras = 0;
            MotoresGlobales.BombaAsfaltoAdelante = 0;
        }

        private void BombaAsfaltoAtrasBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BombaAsfaltoAtras = 1;
            MotoresGlobales.BombaAsfaltoAdelante = 0;
        }

        private void BasculaBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BasculaAsfalto = 1;
            BasculaBoton.BackColor = Color.Green;
            RetornoBoton.BackColor = Color.Gray;
        }

        private void RetornoBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BasculaAsfalto = 0;
            BasculaBoton.BackColor = Color.Gray;
            RetornoBoton.BackColor = Color.Red;
        }

        private void ActualizarConsolaBasculaAsfalto()

        {
            if (EntradasGlobales.BombaAsfaltoAdelante == 1)
            {
                BombaAsfaltoAdelanteBoton.BackColor = Color.Green;
                BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
            }

            if (EntradasGlobales.BombaAsfaltoAtras == 1)
            {
                BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                BombaAsfaltoAtrasBoton.BackColor = Color.Green;
            }

            if (EntradasGlobales.BombaAsfaltoAdelante == 0 && EntradasGlobales.BombaAsfaltoAtras == 0)
            {
                BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
            }


        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarConsolaBasculaAsfalto();
        }

        private void CalibracionBombaAsfalto_Load(object sender, EventArgs e)
        {

        }
    }
}
