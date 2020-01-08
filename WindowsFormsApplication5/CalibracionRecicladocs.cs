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
    public partial class CalibracionRecicladocs : Form
    {
        public CalibracionRecicladocs()
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

        private void RecicladoCalcularBoton_Click(object sender, EventArgs e)
        {
            try
            {
                VariablesGlobales.IndicadorBasculaReciclado = double.Parse(IndBasculaReciclado.Text);// conversión de string a double
                VariablesGlobales.TPH_HzReciclado = (VariablesGlobales.IndicadorBasculaReciclado / 48);
                TPH_HzReciclado.Text = VariablesGlobales.TPH_HzReciclado.ToString();
            }
            catch (System.FormatException) //captura del error por llenado de campos con texto y no numeros
            {
                MessageBox.Show("Todos los campos requieren números, \n corrija error o verifique datos del indicador");
            }
        }

        private void CompuertaRecicladoBotonSecador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coloque la compuerta en rechazo");
            CompuertaRecicladoBotonSecador.BackColor = Color.Gray;

        }

        private void CompuertaRecicladoBotonRechazo_Click(object sender, EventArgs e)
        {
            MotoresGlobales.CompuertaReciclado = 0;//secador 1      rechazo  0
            CompuertaRecicladoBotonSecador.BackColor = Color.Gray;
            CompuertaRecicladoBotonRechazo.BackColor = Color.Green;
        }

        private void BandaRecicladoOnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.CompuertaReciclado == '0')
                MotoresGlobales.BandaInclinadaReciclado = 1;
            else
                MessageBox.Show("Coloque en rechazo la compuerta de reciclado");
        }

        private void BandaRecicladoOffBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BandaInclinadaReciclado = 0;
            MotoresGlobales.BandaAgregadoReciclado = 0;
            MotoresGlobales.MotorTrituradoReciclado = 0;
        }

        private void MotorTrituradoOnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.BandaInclinadaReciclado == '1')
                MotoresGlobales.MotorTrituradoReciclado = 1;
            else
                MessageBox.Show("Prenda Banda Inclinada de Reciclado");
        }

        private void MotorTrituradoOffBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.MotorTrituradoReciclado = 0;
            MotoresGlobales.BandaAgregadoReciclado = 0;
        }

        private void AgregadoRecicladoOnBoton_Click(object sender, EventArgs e)
        {
            if (EntradasGlobales.MotorTrituradoReciclado == '1')
                MotoresGlobales.BandaAgregadoReciclado = 1;
            else
                MessageBox.Show("Prenda Crusher de la banda de triturado");
        }

        private void AgregadoRecicladoOffBoton_Click(object sender, EventArgs e)
        {
            MotoresGlobales.BandaAgregadoReciclado = 0;
        }

        private void PesoPruebaAbajo_Click(object sender, EventArgs e)
        {
            MotoresGlobales.PesoPruebaBandaReciclado = 1;
            PesoPruebaAbajo.BackColor = Color.Yellow;
            PesodePruebaArriba.BackColor = Color.Gray;
        }

        private void PesodePruebaArriba_Click(object sender, EventArgs e)
        {
            MotoresGlobales.PesoPruebaBandaReciclado = 0;
            PesodePruebaArriba.BackColor = Color.Yellow;
            PesoPruebaAbajo.BackColor = Color.Gray;
        }


        private void ActualizarConsolaReciclado()
        {
            if (EntradasGlobales.CompuertaReciclado == '0')
            {
                CompuertaRecicladoBotonSecador.BackColor = Color.Gray;
                CompuertaRecicladoBotonRechazo.BackColor = Color.Green;
            }
            else
            {
                CompuertaRecicladoBotonSecador.BackColor = Color.Red;
                CompuertaRecicladoBotonRechazo.BackColor = Color.Gray;
            }

            if (EntradasGlobales.BandaInclinadaReciclado == '1')
            {
                BandaRecicladoOnBoton.BackColor = Color.Green;
                BandaRecicladoOffBoton.BackColor = Color.Gray;
            }
            else
            {
                BandaRecicladoOnBoton.BackColor = Color.Gray;
                BandaRecicladoOffBoton.BackColor = Color.Red;
            }

            if (EntradasGlobales.MotorTrituradoReciclado == '1')
            {
                MotorTrituradoOnBoton.BackColor = Color.Green;
                MotorTrituradoOffBoton.BackColor = Color.Gray;
            }
            else
            {
                MotorTrituradoOnBoton.BackColor = Color.Gray;
                MotorTrituradoOffBoton.BackColor = Color.Red;
            }

            if (EntradasGlobales.BandaAgregadoReciclado == '1')
            {
                AgregadoRecicladoOnBoton.BackColor = Color.Green;
                AgregadoRecicladoOffBoton.BackColor = Color.Gray;
            }
            else
            {
                AgregadoRecicladoOnBoton.BackColor = Color.Gray;
                AgregadoRecicladoOffBoton.BackColor = Color.Red;
            }

            try
            {
                VariablesGlobales.Valor_mA_Reciclado = Convert.ToInt32(VariablesGlobales.DatoIndReciclado) * 0.015625 + 4;
            }
            catch
            {
                MessageBox.Show("error en trama de comunicación\n error en conversión\ncierre esta ventana");
            } 
            Ind_mAmpRec.Text = Convert.ToString(VariablesGlobales.Valor_mA_Reciclado);
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarConsolaReciclado();
            ComunicacionSerial();
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

            VariablesGlobales.DatoRecibido = new char[50];
            VariablesGlobales.DatoRecibido = VariablesGlobales.DatoRx.ToCharArray();
            // IndDatoRx.Text = "DatoRx:" + VariablesGlobales.DatoRx;
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
                IndBasculaReciclado.Text = "error";
                }
                IndBasculaReciclado.Text = Convert.ToString(VariablesGlobales.ConstanteBasReciclado * (VariablesGlobales.Valor_mA_Reciclado - 4));

        }

        private void CalibracionRecicladocs_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();

        }



        //******************************FIN COMUNICACIÓN SERIAL*************\\\\\\\\\\\\\
        //*****************************************************************************\\




        private void CeroBotonRec_Click(object sender, EventArgs e)
        {
            VariablesGlobales.ValorCeroBasReciclado = VariablesGlobales.Valor_mA_Reciclado;
        }

        private void SpamBotonRec_Click(object sender, EventArgs e)
        {
            try
            {
                VariablesGlobales.ValorSpamBasReciclado = VariablesGlobales.Valor_mA_Reciclado;
                VariablesGlobales.ValorIngresadoSpamReciclado = double.Parse(IndSpamRec.Text);
                IndSpamRec.Text = ("");
            }

            catch
            {
                MessageBox.Show("introduzca un valor númerico");
            }

        }

        private void CalibrarBotonRec_Click(object sender, EventArgs e)
        {

            try
            {
                VariablesGlobales.ConstanteBasReciclado = (VariablesGlobales.ValorIngresadoSpamReciclado / (VariablesGlobales.ValorSpamBasReciclado - VariablesGlobales.ValorCeroBasReciclado));
                MessageBox.Show("Constante de calibración", Convert.ToString(VariablesGlobales.ConstanteBasReciclado));
            }
            catch
            {
                MessageBox.Show("el valor del SPAM debe ser mayor al valor del Cero");

            }
        }

       
    }
}

