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
            VariablesGlobales.FreqAsfalto = 480;  //se coloca la frecuencia a 48 hz para calibrar la bomba
           // MessageBox.Show("bomba adelante");
        }

        private void BombaAsfaltoStopBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BombaAsfaltoAtras = 0;
            MotoresGlobales.BombaAsfaltoAdelante = 0;
            VariablesGlobales.FreqAsfalto = 0;  //se coloca la frecuencia a 0 hz para parar la bomba
        }

        private void BombaAsfaltoAtrasBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BombaAsfaltoAtras = 1;
            MotoresGlobales.BombaAsfaltoAdelante = 0;
            VariablesGlobales.FreqAsfalto = 480;  //se coloca la frecuencia a 48 hz para mover la bomba hacia atras
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
            if (EntradasGlobales.BombaAsfaltoAdelante == '1')
            {
                BombaAsfaltoAdelanteBoton.BackColor = Color.Green;
                BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
            }

            if (EntradasGlobales.BombaAsfaltoAtras == '1')
            {
                BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                BombaAsfaltoAtrasBoton.BackColor = Color.Green;
            }

            if (EntradasGlobales.BombaAsfaltoAdelante == '0' && EntradasGlobales.BombaAsfaltoAtras == '0')
            {
                BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
            }
            try
            {
                VariablesGlobales.Valor_mA_Asfalto = Convert.ToDouble(Convert.ToInt32(VariablesGlobales.DatoIndAsfalto) * 0.015625 + 4);
                Ind_mA_Asf.Text = Convert.ToString(VariablesGlobales.Valor_mA_Asfalto);
            }

            catch
            {
                MessageBox.Show("error interno, cierre esta ventana y continue");
            }


        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            ComunicacionSerial2();
            ActualizarConsolaBasculaAsfalto();
            System.Threading.Thread.Sleep(00);
            ComunicacionSerial();
            
        }

        private void CalibracionBombaAsfalto_Load(object sender, EventArgs e)
        {

        }



        //**************COMUNICACION SERIAL********************\\\\\\\\\\\\\\\\
        //**********************************************************************
        private void ComunicacionSerial()
        {

            VariablesGlobales.Dato_a_enviar = new char[46];
            VariablesGlobales.Dato_a_enviar[0] = 'd';
            VariablesGlobales.Dato_a_enviar[1] = 'a';
            VariablesGlobales.Dato_a_enviar[2] = 't';
            VariablesGlobales.Dato_a_enviar[3] = 'o';
            VariablesGlobales.Dato_a_enviar[4] = '2';
            VariablesGlobales.Dato_a_enviar[5] = Convert.ToChar(MotoresGlobales.BandaAlimentadora+48);
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
            VariablesGlobales.Dato_a_enviar[43] = Convert.ToChar(MotoresGlobales.ValvulaGas + 48);
            VariablesGlobales.Dato_a_enviar[44] = Convert.ToChar(MotoresGlobales.CompuertaGanso + 48);
            VariablesGlobales.Dato_a_enviar[45] = Convert.ToChar(MotoresGlobales.R8090ControlLLama + 48);
            VariablesGlobales.DatoTx = new string(VariablesGlobales.Dato_a_enviar);

            try
            {
                serialPort1.Write(VariablesGlobales.DatoTx);
            }
            catch
            {
                if (VariablesGlobales.ErrorComunicacion == false)
                    MessageBox.Show("Error de comunicación en envío, verifique conexiones\n cierre Diagrama de calibraciones, escoja un puerto disponible o\n apague y prenda el puerto para que quede disponible en el menu de comunicaciones");
                VariablesGlobales.ErrorComunicacion = true;
            }
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
                   // MessageBox.Show("el dato recibido es:"+ VariablesGlobales.DatoRecibido[5]);

                }
            }

            catch
            {
                MessageBox.Show("error interno en la matriz1 dato2");
            }

            try
            {
                if (VariablesGlobales.DatoRecibido[0] == 'd' && VariablesGlobales.DatoRecibido[1] == 'a' && VariablesGlobales.DatoRecibido[2] == 't' && VariablesGlobales.DatoRecibido[3] == 'o' && VariablesGlobales.DatoRecibido[4] == '3')
                {
                    try
                    {
                        //VariablesGlobales.DatoRx = serialPort1.ReadLine();
                        VariablesGlobales.DatoPBHRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoTBHRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoTMzRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoPDQRx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoPDERx = serialPort1.ReadLine();  //presión casa de bolsas
                        VariablesGlobales.DatoFlameEye = serialPort1.ReadLine(); // valor de 0-1023 del porcentaje de llama
                        VariablesGlobales.DatoIndAgregados = serialPort1.ReadLine();// valor de 0-1023 proveniente dle valor del indicador de agregados
                        VariablesGlobales.DatoIndAsfalto = serialPort1.ReadLine(); // valor de 0-123 proveniente del valor del indicador del asfalto
                        VariablesGlobales.DatoIndReciclado = serialPort1.ReadLine(); //valor de 0-123 proveniente del valor del indicador del reciclado
                    }
                    catch
                    {
                        MessageBox.Show("Error de recepción\nRevise conexiones  del puerto serial");
                    }
                }
                else
                {
                    IndBasculaAsfalto.Text = "error";
                }
                IndBasculaAsfalto.Text = Convert.ToString(VariablesGlobales.ConstanteBasAsfalto * (VariablesGlobales.Valor_mA_Asfalto - 4));
            }
            catch
            {
                MessageBox.Show("error interno en la matriz1 analogas");
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
                // MessageBox.Show(VariablesGlobales.DatoTx2);

            }
            catch
            {
                if (VariablesGlobales.ErrorComunicacion == false)
                    MessageBox.Show("Error de comunicación en envío, verifique conexiones\n cierre Diagrama de planta, escoja un puerto disponible o\n apague y prenda el puerto para que quede disponible en el menu de comunicaciones");
                VariablesGlobales.ErrorComunicacion = true;
                //IndPuertoCOM.Text = "No hay acceso al puerto";
                //IndPuertoCOM.BackColor = Color.LightGray;
            }
            //serialPort1.Close();
        }


        //******************************FIN COMUNICACIÓN SERIAL*************\\\\\\\\\\\\\
        //*****************************************************************************\\




        private void CeroBotonAsf_Click(object sender, EventArgs e)
        {
            VariablesGlobales.ValorCeroBasAsfalto = VariablesGlobales.Valor_mA_Asfalto;
        }

        private void SpamBotonAsf_Click(object sender, EventArgs e)
        {
            try
            {
                VariablesGlobales.ValorSpamBasAsfalto = VariablesGlobales.Valor_mA_Asfalto;
                VariablesGlobales.ValorIngresadoSpamAsfalto = double.Parse(IndSpamAsf.Text);
                IndSpamAsf.Text = ("");

            }
            catch
            {
                MessageBox.Show("introduzca un valor númerico");
            }

        }

        private void CalibrarBotonAsf_Click(object sender, EventArgs e)
        {
            try
            {
                VariablesGlobales.ConstanteBasAsfalto = (VariablesGlobales.ValorIngresadoSpamAsfalto / (VariablesGlobales.ValorSpamBasAsfalto - VariablesGlobales.ValorCeroBasAsfalto));
                MessageBox.Show("Constante de calibración", Convert.ToString(VariablesGlobales.ConstanteBasAsfalto));
            }
            catch
            {
                MessageBox.Show("el valor del SPAM debe ser mayor al valor del Cero");
            }

        }

        private void CalibracionBombaAsfalto_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
