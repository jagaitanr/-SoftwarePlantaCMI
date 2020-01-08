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
            try
            {
                serialPort1.PortName = VariablesGlobales.PuertoSerieEscogido;
                serialPort1.Open();//para capturar la excepción de apertura del puerto
            }
            catch
            {
                MessageBox.Show("Seleccione otro puerto, Puerto NO disponible\n Cierre El diagrama de Calibraciones y escoja Puerto  en el menú de Comunicaciones");
            }

        }

        private void Agregado1CalcularBoton_Click(object sender, EventArgs e)
        {
            try
            { if (EntradasGlobales.BandaAgregados1 == '1')
                {
                    VariablesGlobales.IndicadorBasculaAgregados = double.Parse(IndBasculaAgregados.Text);// conversión de string a double
                    VariablesGlobales.TPH_HzAgregado1 = (VariablesGlobales.IndicadorBasculaAgregados / 48);
                    TPH_HzAgregado1Label.Text = VariablesGlobales.TPH_HzAgregado1.ToString();
                }
                else
                    MessageBox.Show("Banda de agragados 1 apagada,\n prenda la banda para hacer calibración");
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

        private void BandaInclinadaOnBoton_Click_1(object sender, EventArgs e)
        {
            BandaInclinadaOnBoton.BackColor = Color.Green;
            BandaInclinadaOffBoton.BackColor = Color.Gray;
            MotoresGlobales.BandaAlimentadora = 1;

        }

        private void BandaInclinadaOffBoton_Click_1(object sender, EventArgs e)
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

        private void BandaInclinadaOnBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.DrumBypass == 1 && EntradasGlobales.SlingerAtras == '1')
            {
                BandaInclinadaOnBoton.BackColor = Color.Green;
                BandaInclinadaOffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAlimentadora = 1;
            }
            else
                MessageBox.Show("Active el Drum Bypass y el slinger hacia atras");
        }

        private void BandaInclinadaOffBoton_Click(object sender, EventArgs e)
        {
            BandaInclinadaOnBoton.BackColor = Color.Gray;
            BandaInclinadaOffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAlimentadora = 0;
        }

        private void ZarandaOnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaAlimentadora == '1')
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
            if (EntradasGlobales.Zaranda == '1' && EntradasGlobales.BandaAlimentadora == '1')
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
            if (EntradasGlobales.BandaColectora == '1' && EntradasGlobales.BandaAgregados2 == '0' && EntradasGlobales.BandaAgregados3 == '0' && EntradasGlobales.BandaAgregados4 == '0')
            {
                BandaAgregados1OnBoton.BackColor = Color.Green;
                BandaAgregados1OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados1 = 1;
                VariablesGlobales.FreqAgregado1 = 480;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados1OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados1OnBoton.BackColor = Color.Gray;
            BandaAgregados1OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados1 = 0;
            VariablesGlobales.FreqAgregado1 = 0;

        }

        private void BandaAgregados2OnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaColectora == '1' && EntradasGlobales.BandaAgregados1 == '0' && EntradasGlobales.BandaAgregados3 == '0' && EntradasGlobales.BandaAgregados4 == '0')
            {
                BandaAgregados2OnBoton.BackColor = Color.Green;
                BandaAgregados2OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados2 = 1;
                VariablesGlobales.FreqAgregado2 = 300;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados2OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados2OnBoton.BackColor = Color.Gray;
            BandaAgregados2OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados2 = 0;
            VariablesGlobales.FreqAgregado2 = 0;

        }

        private void BandaAgregados3OnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaColectora == '1' && EntradasGlobales.BandaAgregados1 == '0' && EntradasGlobales.BandaAgregados2 == '0' && EntradasGlobales.BandaAgregados4 == '0')
            {
                BandaAgregados3OnBoton.BackColor = Color.Green;
                BandaAgregados3OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados3 = 1;
                VariablesGlobales.FreqAgregado3 = 480;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados3OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados3OnBoton.BackColor = Color.Gray;
            BandaAgregados3OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados3 = 0;
            VariablesGlobales.FreqAgregado3 = 0;

        }

        private void BandaAgregados4OnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaColectora == '1' && EntradasGlobales.BandaAgregados1 == '0' && EntradasGlobales.BandaAgregados2 == '0' && EntradasGlobales.BandaAgregados3 == '0')
            {
                BandaAgregados4OnBoton.BackColor = Color.Green;
                BandaAgregados4OffBoton.BackColor = Color.Gray;
                MotoresGlobales.BandaAgregados4 = 1;
                VariablesGlobales.FreqAgregado4 = 480;
            }
            else
                MessageBox.Show("Prenda Banda Colectora y verifique que ninguna otra banda \n de agregados este prendida");

        }

        private void BandaAgregados4OffBoton_Click(object sender, EventArgs e)
        {
            BandaAgregados4OnBoton.BackColor = Color.Gray;
            BandaAgregados4OffBoton.BackColor = Color.Red;
            MotoresGlobales.BandaAgregados4 = 0;
            VariablesGlobales.FreqAgregado4 = 0;

        }

        private void SlingerAdelanteBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.DrumBypass == 1 && EntradasGlobales.SlingerAtras == '0')
            {
                MessageBox.Show("Precaución, Banda Hacia adelante"); //ya que se supone la calibración debe hacerse hacia atras
                //SlingerAdelanteBoton.BackColor = Color.Green;
                //SlingerStopBoton.BackColor = Color.Gray;
                //SlingerAtrasBoton.BackColor = Color.Gray;
                MotoresGlobales.SlingerAtras = 0;
                MotoresGlobales.SlingerAdelante = 1;
            }
            else
                MessageBox.Show("Precaución, Banda Hacia adelante, Active DrummBypass");

        }

        private void SlingerAtrasBoton_Click(object sender, EventArgs e)
        {

            if (VariablesGlobales.DrumBypass == 1 && EntradasGlobales.SlingerAdelante == '0')
            {
                // SlingerAdelanteBoton.BackColor = Color.Gray;
                // SlingerStopBoton.BackColor = Color.Gray;
                // SlingerAtrasBoton.BackColor = Color.Green;
                MotoresGlobales.SlingerAdelante = 0;
                MotoresGlobales.SlingerAtras = 1;
            }
            else
                MessageBox.Show("Active Drum Bypass y verifique que el motor esté detenido");
        }

        private void SlingerStopBoton_Click(object sender, EventArgs e)
        {
            //  SlingerAdelanteBoton.BackColor = Color.Gray;
            //  SlingerStopBoton.BackColor = Color.Red;
            //  SlingerAtrasBoton.BackColor = Color.Gray;
            MotoresGlobales.SlingerAdelante = 0;
            MotoresGlobales.SlingerAtras = 0;

        }



        //**************COMUNICACION SERIAL********************\\\\\\\\\\\\\\\\
        //**********************************************************************
        private void ComunicacionSerial()
        {

            VariablesGlobales.Dato_a_enviar = new char[47];
            VariablesGlobales.Dato_a_enviar[0] = 'd';
            VariablesGlobales.Dato_a_enviar[1] = 'a';
            VariablesGlobales.Dato_a_enviar[2] = 't';
            VariablesGlobales.Dato_a_enviar[3] = 'o';
            VariablesGlobales.Dato_a_enviar[4] = '2';
            VariablesGlobales.Dato_a_enviar[5] = Convert.ToChar(MotoresGlobales.BandaAlimentadora + 48);
            VariablesGlobales.Dato_a_enviar[6] = Convert.ToChar(MotoresGlobales.Zaranda + 48);
            VariablesGlobales.Dato_a_enviar[7] = Convert.ToChar(MotoresGlobales.BandaColectora + 48);
            VariablesGlobales.Dato_a_enviar[8] = Convert.ToChar(MotoresGlobales.PesoPruebaBandaAlimentadora + 48);
            VariablesGlobales.Dato_a_enviar[9] = Convert.ToChar(MotoresGlobales.BandaAgregados1 + 48);
            VariablesGlobales.Dato_a_enviar[10] = Convert.ToChar(MotoresGlobales.BandaAgregados2 + 48);
            VariablesGlobales.Dato_a_enviar[11] = Convert.ToChar(MotoresGlobales.BandaAgregados3 + 48);
            VariablesGlobales.Dato_a_enviar[12] = Convert.ToChar(MotoresGlobales.BandaAgregados4 + 48);
            VariablesGlobales.Dato_a_enviar[13] = Convert.ToChar(MotoresGlobales.BandaInclinadaReciclado + 48);
            VariablesGlobales.Dato_a_enviar[14] = Convert.ToChar(MotoresGlobales.BandaAgregadoReciclado + 48);
            VariablesGlobales.Dato_a_enviar[15] = Convert.ToChar(MotoresGlobales.MotorTrituradoReciclado + 48);
            VariablesGlobales.Dato_a_enviar[16] = Convert.ToChar(MotoresGlobales.PesoPruebaBandaReciclado + 48);
            VariablesGlobales.Dato_a_enviar[17] = Convert.ToChar(MotoresGlobales.CompuertaReciclado + 48);
            VariablesGlobales.Dato_a_enviar[18] = Convert.ToChar(MotoresGlobales.MotorBlowerBH + 48);
            VariablesGlobales.Dato_a_enviar[19] = Convert.ToChar(MotoresGlobales.MotorVannerBH + 48);
            VariablesGlobales.Dato_a_enviar[20] = Convert.ToChar(MotoresGlobales.SinFinColector1BH + 48);
            VariablesGlobales.Dato_a_enviar[21] = Convert.ToChar(MotoresGlobales.SinFinColector2BH + 48);
            VariablesGlobales.Dato_a_enviar[22] = Convert.ToChar(MotoresGlobales.SinFinTransversalBH + 48);
            VariablesGlobales.Dato_a_enviar[23] = Convert.ToChar(MotoresGlobales.Compresor + 48);
            VariablesGlobales.Dato_a_enviar[24] = Convert.ToChar(MotoresGlobales.BombaAsfaltoAdelante + 48);
            VariablesGlobales.Dato_a_enviar[25] = Convert.ToChar(MotoresGlobales.BombaAsfaltoAtras + 48);
            VariablesGlobales.Dato_a_enviar[26] = Convert.ToChar(MotoresGlobales.Extractor1BH + 48);
            VariablesGlobales.Dato_a_enviar[27] = Convert.ToChar(MotoresGlobales.Extractor2BH + 48);
            VariablesGlobales.Dato_a_enviar[28] = Convert.ToChar(MotoresGlobales.BlowerQuemador + 48);
            VariablesGlobales.Dato_a_enviar[29] = Convert.ToChar(MotoresGlobales.Elevador + 48);
            VariablesGlobales.Dato_a_enviar[30] = Convert.ToChar(MotoresGlobales.CompuertaRechazo + 48);
            VariablesGlobales.Dato_a_enviar[31] = Convert.ToChar(MotoresGlobales.Secador + 48);
            VariablesGlobales.Dato_a_enviar[32] = Convert.ToChar(MotoresGlobales.SlingerAdelante + 48);
            VariablesGlobales.Dato_a_enviar[33] = Convert.ToChar(MotoresGlobales.SlingerAtras + 48);
            VariablesGlobales.Dato_a_enviar[34] = Convert.ToChar(MotoresGlobales.BombaCombustible + 48);
            VariablesGlobales.Dato_a_enviar[35] = Convert.ToChar(MotoresGlobales.Damper + 48);
            VariablesGlobales.Dato_a_enviar[36] = Convert.ToChar(MotoresGlobales.PilotoValvula + 48);
            VariablesGlobales.Dato_a_enviar[37] = Convert.ToChar(MotoresGlobales.MainLlama + 48);
            VariablesGlobales.Dato_a_enviar[38] = Convert.ToChar(MotoresGlobales.Rotor1BH + 48);
            VariablesGlobales.Dato_a_enviar[39] = Convert.ToChar(MotoresGlobales.Rotor2BH + 48);
            VariablesGlobales.Dato_a_enviar[40] = Convert.ToChar(MotoresGlobales.Rotor3BH + 48);
            VariablesGlobales.Dato_a_enviar[41] = Convert.ToChar(MotoresGlobales.AlimentacionSilo + 48);
            VariablesGlobales.Dato_a_enviar[42] = Convert.ToChar(MotoresGlobales.ValvulaAceite + 48);
            VariablesGlobales.Dato_a_enviar[43] = Convert.ToChar(MotoresGlobales.CompuertaGanso + 48);
            VariablesGlobales.Dato_a_enviar[44] = Convert.ToChar(MotoresGlobales.ValvulaGas + 48);
            VariablesGlobales.Dato_a_enviar[45] = Convert.ToChar(MotoresGlobales.R8090ControlLLama + 48);
            VariablesGlobales.Dato_a_enviar[46] = 'Z';  //finaliza cadena

            VariablesGlobales.DatoTx = new string(VariablesGlobales.Dato_a_enviar);
            try
            {
                serialPort1.Write(VariablesGlobales.DatoTx);
                // serialPort1.Write(Convert.ToString(VariablesGlobales.FreqAgregado1));
            }
            catch
            {
                if (VariablesGlobales.ErrorComunicacion == false)
                    MessageBox.Show("Error de comunicación en envío, verifique conexiones\n cierre Diagrama de calibraciones, escoja un puerto disponible o\n apague y prenda el puerto para que quede disponible en el menu de comunicaciones");
                VariablesGlobales.ErrorComunicacion = true;
            }
        }


        private void CalibracionAgregados_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            try
            { VariablesGlobales.DatoRx = serialPort1.ReadLine(); }
            catch
            {
                MessageBox.Show("Error de recepción\nRevise conexiones del puerto serial");
            }
            VariablesGlobales.ErrorComunicacion = false;

            VariablesGlobales.DatoRecibido = new char[100];
            VariablesGlobales.DatoRecibido = VariablesGlobales.DatoRx.ToCharArray();

            // IndDatoRx.Text = "DatoRx:" + VariablesGlobales.DatoRx;
            try
            {
                if (VariablesGlobales.DatoRecibido[0] == 'd' && VariablesGlobales.DatoRecibido[1] == 'a' && VariablesGlobales.DatoRecibido[2] == 't' && VariablesGlobales.DatoRecibido[3] == 'o' && VariablesGlobales.DatoRecibido[4] == '2')
                {
                    //   IndPuertoCOM.BackColor = Color.LightGreen;
                    //   IndPuertoCOM.Text = VariablesGlobales.PuertoSerieEscogido;
                    EntradasGlobales.BandaAlimentadora = VariablesGlobales.DatoRecibido[5];
                    EntradasGlobales.Zaranda = VariablesGlobales.DatoRecibido[6];
                    EntradasGlobales.BandaColectora = VariablesGlobales.DatoRecibido[7];
                    EntradasGlobales.PesoPruebaBandaAlimentadora = VariablesGlobales.DatoRecibido[8];
                    EntradasGlobales.BandaAgregados1 = VariablesGlobales.DatoRecibido[9];
                    EntradasGlobales.BandaAgregados2 = VariablesGlobales.DatoRecibido[10];
                    EntradasGlobales.BandaAgregados3 = VariablesGlobales.DatoRecibido[11];
                    EntradasGlobales.BandaAgregados4 = VariablesGlobales.DatoRecibido[12];
                    EntradasGlobales.BandaInclinadaReciclado = VariablesGlobales.DatoRecibido[13];
                    EntradasGlobales.BandaAgregadoReciclado = VariablesGlobales.DatoRecibido[14];
                    EntradasGlobales.MotorTrituradoReciclado = VariablesGlobales.DatoRecibido[15];
                    EntradasGlobales.PesoPruebaBandaReciclado = VariablesGlobales.DatoRecibido[16];
                    EntradasGlobales.CompuertaReciclado = VariablesGlobales.DatoRecibido[17];
                    EntradasGlobales.MotorBlowerBH = VariablesGlobales.DatoRecibido[18];
                    EntradasGlobales.MotorVannerBH = VariablesGlobales.DatoRecibido[19];
                    EntradasGlobales.SinFinColector1BH = VariablesGlobales.DatoRecibido[20];
                    EntradasGlobales.SinFinColector2BH = VariablesGlobales.DatoRecibido[21];
                    EntradasGlobales.SinFinTransversalBH = VariablesGlobales.DatoRecibido[22];
                    EntradasGlobales.Compresor = VariablesGlobales.DatoRecibido[23];
                    EntradasGlobales.BombaAsfaltoAdelante = VariablesGlobales.DatoRecibido[24];
                    EntradasGlobales.BombaAsfaltoAtras = VariablesGlobales.DatoRecibido[25];
                    EntradasGlobales.Extractor1BH = VariablesGlobales.DatoRecibido[26];
                    EntradasGlobales.Extractor2BH = VariablesGlobales.DatoRecibido[27];
                    EntradasGlobales.BlowerQuemador = VariablesGlobales.DatoRecibido[28];
                    EntradasGlobales.Elevador = VariablesGlobales.DatoRecibido[29];
                    EntradasGlobales.CompuertaRechazo = VariablesGlobales.DatoRecibido[30];
                    EntradasGlobales.Secador = VariablesGlobales.DatoRecibido[31];
                    EntradasGlobales.SlingerAdelante = VariablesGlobales.DatoRecibido[32];
                    EntradasGlobales.SlingerAtras = VariablesGlobales.DatoRecibido[33];
                    EntradasGlobales.BombaCombustible = VariablesGlobales.DatoRecibido[34];
                    EntradasGlobales.Damper = VariablesGlobales.DatoRecibido[35];
                    EntradasGlobales.PilotoValvula = VariablesGlobales.DatoRecibido[36];
                    EntradasGlobales.MainLlama = VariablesGlobales.DatoRecibido[37];
                    EntradasGlobales.Rotor1BH = VariablesGlobales.DatoRecibido[38];
                    EntradasGlobales.Rotor2BH = VariablesGlobales.DatoRecibido[39];
                    EntradasGlobales.Rotor3BH = VariablesGlobales.DatoRecibido[40];
                    EntradasGlobales.AlimentacionSilo = VariablesGlobales.DatoRecibido[41];
                    EntradasGlobales.ValvulaAceite = VariablesGlobales.DatoRecibido[42];
                    EntradasGlobales.ValvulaGas = VariablesGlobales.DatoRecibido[43];//*/

                }
            }
            catch
            {
                MessageBox.Show("error interno, cierre esta ventana");
            }
            try
            {
                if (VariablesGlobales.DatoRecibido[0] == 'd' && VariablesGlobales.DatoRecibido[1] == 'a' && VariablesGlobales.DatoRecibido[2] == 't' && VariablesGlobales.DatoRecibido[3] == 'o' && VariablesGlobales.DatoRecibido[4] == '3')


                {
                    try
                    {
                        VariablesGlobales.RecibiendoDatos = true;// para que no se cierre el puerto mientras esta recibiendo
                        //VariablesGlobales.DatoRx = serialPort1.ReadLine();
                        VariablesGlobales.DatoPBHRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoTBHRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoTMzRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoTExausthRx = serialPort1.ReadLine();  //temperatura exausth
                        VariablesGlobales.DatoTasfRx = serialPort1.ReadLine();  // temperatura asfalto
                        VariablesGlobales.DatoPDQRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoPDERx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoFlameEye = serialPort1.ReadLine(); // valor de 0-1023 del porcentaje de llama
                        VariablesGlobales.DatoIndAgregados = serialPort1.ReadLine();// valor de 0-1023 proveniente dle valor del indicador de agregados
                        VariablesGlobales.DatoIndAsfalto = serialPort1.ReadLine(); // valor de 0-123 proveniente del valor del indicador del asfalto
                        VariablesGlobales.DatoIndReciclado = serialPort1.ReadLine(); //valor de 0-123 proveniente del valor del indicador del reciclado
                        VariablesGlobales.RecibiendoDatos = false; //para permitir cerrar el puerto
                    }
                    catch
                    {
                        MessageBox.Show("Error de recepción\nRevise conexiones  del puerto serial");
                    }
                }
                else
                {
                    IndBasculaAgregados.Text = "error";
                }
                IndBasculaAgregados.Text = Convert.ToString(VariablesGlobales.ConstanteBasAgregados * (VariablesGlobales.Valor_mA_Agregados - VariablesGlobales.ValorCeroBasAgregados));
            }
            catch
            {
                MessageBox.Show("erro interno, cierre esta ventana");
            }


        }


        private void ComunicacionSerial2()
        {


            try
            {
                // serialPort1.Open();
                VariablesGlobales.DatoTx2 = ("b" + Convert.ToString(VariablesGlobales.FreqAgregado1) + "c" + Convert.ToString(VariablesGlobales.FreqAgregado2)) + "x" + Convert.ToString(VariablesGlobales.FreqAgregado3) + "e" + Convert.ToString(VariablesGlobales.FreqAgregado4) + "f" +
                Convert.ToString(VariablesGlobales.FreqReciclado) + "g" + Convert.ToString(VariablesGlobales.FreqAsfalto) + "h" + Convert.ToString(VariablesGlobales.PosicionDamperExtractorBH) + "i" + Convert.ToString(VariablesGlobales.PosicionDamperQuemador) + "j";
                //  IndDatoTx.Text = VariablesGlobales.DatoTx2;
                serialPort1.Write(VariablesGlobales.DatoTx2);
            }
            catch
            {
                if (VariablesGlobales.ErrorComunicacion == false)
                    MessageBox.Show("Error de comunicación en envío, verifique conexiones\n cierre Diagrama de planta, escoja un puerto disponible o\n apague y prenda el puerto para que quede disponible en el menu de comunicaciones");
                VariablesGlobales.ErrorComunicacion = true;
            }
        }

    
        //******************************FIN COMUNICACIÓN SERIAL*************\\\\\\\\\\\\\
        //*****************************************************************************\\


        private void VisualizarBotones()
        {
            if (EntradasGlobales.BandaAlimentadora == '1')
            {
                BandaInclinadaOnBoton.BackColor = Color.Green;
                BandaInclinadaOffBoton.BackColor = Color.Gray;
            }
            else
            {
                BandaInclinadaOnBoton.BackColor = Color.Gray;
                BandaInclinadaOffBoton.BackColor = Color.Red;
            }

            if (EntradasGlobales.Zaranda == '1')
            {
                ZarandaOnBoton.BackColor = Color.Green;
                ZarandaOffBoton.BackColor = Color.Gray;
            }
            else
            {
                ZarandaOnBoton.BackColor = Color.Gray;
                ZarandaOffBoton.BackColor = Color.Red;
            }


            if (EntradasGlobales.BandaColectora == '1')
            {
                BandaColectoraOnBoton.BackColor = Color.Green;
                BandaColectoraOffBoton.BackColor = Color.Gray;
            }
            else
            {
                BandaColectoraOnBoton.BackColor = Color.Gray;
                BandaColectoraOffBoton.BackColor = Color.Red;
            }

            if (EntradasGlobales.BandaAgregados1 == '1')
            {
                BandaAgregados1OnBoton.BackColor = Color.Green;
                BandaAgregados1OffBoton.BackColor = Color.Gray;
            }
            else
            {
                BandaAgregados1OnBoton.BackColor = Color.Gray;
                BandaAgregados1OffBoton.BackColor = Color.Red;
            }

            if (EntradasGlobales.BandaAgregados2 == '1')
            {
                BandaAgregados2OnBoton.BackColor = Color.Green;
                BandaAgregados2OffBoton.BackColor = Color.Gray;
            }
            else
            {
                BandaAgregados2OnBoton.BackColor = Color.Gray;
                BandaAgregados2OffBoton.BackColor = Color.Red;
            }
            if (EntradasGlobales.BandaAgregados3 == '1')
            {
                BandaAgregados3OnBoton.BackColor = Color.Green;
                BandaAgregados3OffBoton.BackColor = Color.Gray;
            }
            else
            {
                BandaAgregados3OnBoton.BackColor = Color.Gray;
                BandaAgregados3OffBoton.BackColor = Color.Red;
            }
            if (EntradasGlobales.BandaAgregados4 == '1')
            {
                BandaAgregados4OnBoton.BackColor = Color.Green;
                BandaAgregados4OffBoton.BackColor = Color.Gray;
            }
            else
            {
                BandaAgregados4OnBoton.BackColor = Color.Gray;
                BandaAgregados4OffBoton.BackColor = Color.Red;
            }

            if (EntradasGlobales.SlingerAdelante == '0' && MotoresGlobales.SlingerAtras == 0)
            {
                SlingerAdelanteBoton.BackColor = Color.Gray;
                SlingerAtrasBoton.BackColor = Color.Gray;
                SlingerStopBoton.BackColor = Color.Red;
            }

            if (EntradasGlobales.SlingerAdelante == '1')  
            {
                SlingerAdelanteBoton.BackColor = Color.Green;
                SlingerAtrasBoton.BackColor = Color.Gray;
                SlingerStopBoton.BackColor = Color.Gray;
            }
            if (EntradasGlobales.SlingerAtras == '1')
            {  
                SlingerAdelanteBoton.BackColor = Color.Gray;
                SlingerAtrasBoton.BackColor = Color.Green;
                SlingerStopBoton.BackColor = Color.Gray;

            }

            try
            {
                VariablesGlobales.Valor_mA_Agregados = Convert.ToInt32(VariablesGlobales.DatoIndAgregados) * 0.015625 + 4;
                Ind_mAmp.Text = Convert.ToString(VariablesGlobales.Valor_mA_Agregados);
            }

            catch
            {
                MessageBox.Show("error en trama de comunicación, cierre este cuadro de diálogo, \n si persiste el problema comuníquese con el programador");
            }


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            VisualizarBotones();
            ComunicacionSerial();
            
        }

        private void CeroBoton_Click(object sender, EventArgs e)
        {
            VariablesGlobales.ValorCeroBasAgregados = VariablesGlobales.Valor_mA_Agregados;
        }

        private void SpamBoton_Click(object sender, EventArgs e)
        {
           try
            {
                VariablesGlobales.ValorSpamBasAgregados = VariablesGlobales.Valor_mA_Agregados;
                VariablesGlobales.ValorIngresadoSpamAgregados = double.Parse(IndEntradaSpam.Text);
                IndEntradaSpam.Text = ("");
                
            }
           catch
            {
                MessageBox.Show("introduzca un valor númerico");
            }
          }

        private void CalibrarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                VariablesGlobales.ConstanteBasAgregados = (VariablesGlobales.ValorIngresadoSpamAgregados / (VariablesGlobales.ValorSpamBasAgregados - VariablesGlobales.ValorCeroBasAgregados));
                MessageBox.Show("Constante de calibración", Convert.ToString(VariablesGlobales.ConstanteBasAgregados));
            }
            catch
            {
                MessageBox.Show("el valor del SPAM debe ser mayor al valor del Cero");
            }
            }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ComunicacionSerial2();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (VariablesGlobales.RecibiendoDatos == false)
            {
                serialPort1.Close();
                serialPort1.Open();
            }
        }
    }
}
