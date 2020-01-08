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
    public partial class CalibracionAgregados : Form
    {
        public CalibracionAgregados()
        {
            InitializeComponent();
        }

        private void Agregado1CalcularBoton_Click(object sender, EventArgs e)
        {
            try
            {
                VariablesGlobales.IndicadorBasculaAgregados = double.Parse(IndBasculaAgregados.Text);// conversión de string a double
                VariablesGlobales.TPH_HzAgregado1 = (VariablesGlobales.IndicadorBasculaAgregados / 48);
                TPH_HzAgregado1Label.Text = VariablesGlobales.TPH_HzAgregado1.ToString();
            }
            catch (System.FormatException) //captura del error por llenado de campos con texto y no numeros
            {
                MessageBox.Show("Todos los campos requieren números, \n corrija error o verifique datos del indicador");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            VariablesGlobales.IndicadorBasculaAgregados = double.Parse(IndBasculaAgregados.Text);// conversión de string a double
            VariablesGlobales.TPH_HzAgregado2 = (VariablesGlobales.IndicadorBasculaAgregados / 48);
            TPH_HzAgregado2Label.Text = VariablesGlobales.TPH_HzAgregado2.ToString();
            }
            catch (System.FormatException) //captura del error por llenado de campos con texto y no numeros
            {
                MessageBox.Show("Todos los campos requieren números, \n corrija error o verifique datos del indicador");
            }

}

private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            VariablesGlobales.IndicadorBasculaAgregados = double.Parse(IndBasculaAgregados.Text);// conversión de string a double
            VariablesGlobales.TPH_HzAgregado3 = (VariablesGlobales.IndicadorBasculaAgregados / 48);
            TPH_HzAgregado3Label.Text = VariablesGlobales.TPH_HzAgregado3.ToString();
            }
            catch (System.FormatException) //captura del error por llenado de campos con texto y no numeros
            {
                MessageBox.Show("Todos los campos requieren números, \n corrija error o verifique datos del indicador");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            { 
            VariablesGlobales.IndicadorBasculaAgregados = double.Parse(IndBasculaAgregados.Text);// conversión de string a double
            VariablesGlobales.TPH_HzAgregado4 = (VariablesGlobales.IndicadorBasculaAgregados / 48);
            TPH_HzAgregado4Label.Text = VariablesGlobales.TPH_HzAgregado4.ToString();
            }
            catch (System.FormatException) //captura del error por llenado de campos con texto y no numeros
            {
                MessageBox.Show("Todos los campos requieren números, \n corrija error o verifique datos del indicador");
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            MotoresGlobales.PesoPruebaBandaAlimentadora = 1;
            PesoPruebaAbajo.BackColor = Color.Yellow;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MotoresGlobales.PesoPruebaBandaAlimentadora = 0;
            PesoPruebaAbajo.BackColor = Color.LightGray;

        }

        private void BandaInclinadaOnBoton_Click(object sender, EventArgs e)
        {
            BandaInclinadaOnBoton.BackColor = Color.Green;
            BandaInclinadaOffBoton.BackColor = Color.Gray;
            MotoresGlobales.BandaAlimentadora = 1;
          
        }

        private void BandaInclinadaOffBoton_Click(object sender, EventArgs e)
        {

            BandaInclinadaOnBoton.BackColor = Color.Gray;
            BandaInclinadaOffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAlimentadora = 0;
        }
    

    private void CalibracionAgregados_Load(object sender, EventArgs e)
    {

    }

        private void DrumBypassOnBoton_Click(object sender, EventArgs e)
        {
            DrumBypassOnBoton.BackColor = Color.Green;
            DrumBypassOffBoton.BackColor = Color.Gray;
            VariablesGlobales.DrumBypass = 1;
        }

        private void DrumBypassOffBoton_Click(object sender, EventArgs e)
        {
            DrumBypassOnBoton.BackColor = Color.Gray;
            DrumBypassOffBoton.BackColor = Color.Red;
            VariablesGlobales.DrumBypass = 0;
        }

        private void BandaInclinadaOnBoton_Click_1(object sender, EventArgs e)
        {
            if (VariablesGlobales.DrumBypass == 1 && EntradasGlobales.SlingerAtras == 1)
            {
                BandaInclinadaOnBoton.BackColor = Color.Green;
                BandaInclinadaOffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAlimentadora = 1;
            }
            else
                MessageBox.Show("Active el Drum Bypass y el slinger hacia atras");
        }

        private void BandaInclinadaOffBoton_Click_1(object sender, EventArgs e)
         {
            BandaInclinadaOnBoton.BackColor = Color.Gray;
            BandaInclinadaOffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAlimentadora = 0;
            }

        private void ZarandaOnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaAlimentadora == 1)
            {
                ZarandaOnBoton.BackColor = Color.Green;
                ZarandaOffBoton.BackColor = Color.Gray;
                MotoresGlobales.Zaranda = 1;
            }
            else
                MessageBox.Show("Prenda Banda Inclinada Principal");
            
        }

        private void ZarandaOffBoton_Click(object sender, EventArgs e)
        {
            ZarandaOnBoton.BackColor = Color.Gray;
            ZarandaOffBoton.BackColor = Color.Red;
            MotoresGlobales.Zaranda = 0;

        }

        private void BandaColectoraOnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.Zaranda == 1 && EntradasGlobales.BandaAlimentadora == 1  )
            {
                BandaColectoraOnBoton.BackColor = Color.Green;
                BandaColectoraOffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaColectora = 1;
            }
            else
                MessageBox.Show("Prenda Zaranda y Banda Alimentadora");

        }

        private void BandaColectoraOffBoton_Click(object sender, EventArgs e)
        {
            BandaColectoraOnBoton.BackColor = Color.Gray;
            BandaColectoraOffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaColectora = 0;
        }

        private void BandaAgregados1OnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaColectora == 1 && EntradasGlobales.BandaAgregados2==0 && EntradasGlobales.BandaAgregados3== 0 && EntradasGlobales.BandaAgregados4==0)
            {
                BandaAgregados1OnBoton.BackColor = Color.Green;
                BandaAgregados1OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados1 = 1;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados1OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados1OnBoton.BackColor = Color.Gray;
            BandaAgregados1OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados1 = 0;

        }

        private void BandaAgregados2OnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaColectora == 1 && EntradasGlobales.BandaAgregados1 == 0 && EntradasGlobales.BandaAgregados3 == 0 && EntradasGlobales.BandaAgregados4 == 0)
            {
                BandaAgregados2OnBoton.BackColor = Color.Green;
                BandaAgregados2OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados2 = 1;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados2OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados2OnBoton.BackColor = Color.Gray;
            BandaAgregados2OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados2 = 0;

        }

        private void BandaAgregados3OnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaColectora == 1 && EntradasGlobales.BandaAgregados1 == 0 && EntradasGlobales.BandaAgregados2 == 0 && EntradasGlobales.BandaAgregados4 == 0)
            {
                BandaAgregados3OnBoton.BackColor = Color.Green;
                BandaAgregados3OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados3 = 1;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados3OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados3OnBoton.BackColor = Color.Gray;
            BandaAgregados3OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados3 = 0;

        }

        private void BandaAgregados4OnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaColectora == 1 && EntradasGlobales.BandaAgregados1 == 0 && EntradasGlobales.BandaAgregados2 == 0 && EntradasGlobales.BandaAgregados3 == 0)
            {
                BandaAgregados4OnBoton.BackColor = Color.Green;
                BandaAgregados4OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados4 = 1;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados4OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados4OnBoton.BackColor = Color.Gray;
            BandaAgregados4OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados4 = 0;

        }

        private void SlingerAdelanteBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.DrumBypass == 1 && EntradasGlobales.SlingerAtras==0)
            {
                MessageBox.Show("Precaución, Banda Hacia adelante");
                SlingerAdelanteBoton.BackColor = Color.Green;
                SlingerStopBoton.BackColor = Color.Gray;
                SlingerAtrasBoton.BackColor = Color.Gray;
                MotoresGlobales.SlingerAtras = 0;
                MotoresGlobales.SlingerAdelante = 1;
            }
            else
                MessageBox.Show("Precaución, Banda Hacia adelante, Active DrummBypass");

        }

        private void SlingerAtrasBoton_Click(object sender, EventArgs e)
        {

            if (VariablesGlobales.DrumBypass == 1 && EntradasGlobales.SlingerAdelante==0)
            {
                SlingerAdelanteBoton.BackColor = Color.Gray;
                SlingerStopBoton.BackColor = Color.Gray;
                SlingerAtrasBoton.BackColor = Color.Green;
                MotoresGlobales.SlingerAdelante = 0;
                MotoresGlobales.SlingerAtras = 1;
            }
            else
                MessageBox.Show("Active Drum Bypass y verifique que el motor esté detenido");
        }

        private void SlingerStopBoton_Click(object sender, EventArgs e)
        {
            SlingerAdelanteBoton.BackColor = Color.Gray;
            SlingerStopBoton.BackColor = Color.Red;
            SlingerAtrasBoton.BackColor = Color.Gray;
            MotoresGlobales.SlingerAdelante = 0;
            MotoresGlobales.SlingerAtras = 0;

        }

       

        
    }
 }
