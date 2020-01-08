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
    public partial class Simulador : Form
    {
        public Simulador()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //para controlar las excepciones del puerto serial
            timer1_Visualización.Start();
            timer3_Segundo.Start();

            try
            {
                serialPort1.PortName = VariablesGlobales.PuertoSerieEscogido;
                serialPort1.Open();//para capturar la excepción de apertura del puerto
            }
            catch
            {
                MessageBox.Show("Seleccione otro puerto, Puerto NO disponible\n Cierre El diagrama de Planta y escoja Puerto  en el menú de Comunicaciones");
            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            ControlMotores frmCM = new ControlMotores();    //crea objeto control motores
            frmCM.Show();
            VariablesGlobales.ConsolaControlMotores = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VelocidadMotores()
        {
            if (VariablesGlobales.Simulador == true) //modo simulador

            {
                if (MotoresGlobalesSimulados.BandaAgregados1 == 1)
                    //      VariablesGlobales.VelocidadAgregado1TPH = (VariablesGlobales.MasterMezcla / 100) * (120 * VariablesGlobales.TPH_HzAgregado1) * (VariablesGlobales.Agregado1en100kg / 100);
                    VariablesGlobales.VelocidadAgregado1TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado1en100kg) * 2.5;//significa que al 100% de master y 100% de material, llegaría a los 250TPH
                else
                    VariablesGlobales.VelocidadAgregado1TPH = 0;

                if (MotoresGlobalesSimulados.BandaAgregados2 == 1)
                    VariablesGlobales.VelocidadAgregado2TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado2en100kg) * 2.5;//60 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.VelocidadAgregado2TPH = 0;

                if (MotoresGlobalesSimulados.BandaAgregados3 == 1)
                    VariablesGlobales.VelocidadAgregado3TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado3en100kg) * 2.5;//60 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.VelocidadAgregado3TPH = 0;

                if (MotoresGlobalesSimulados.BandaAgregados4 == 1)
                    VariablesGlobales.VelocidadAgregado4TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado4en100kg) * 2.5;//60 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.VelocidadAgregado4TPH = 0;

                if (MotoresGlobalesSimulados.BandaAgregadoReciclado == 1)
                    VariablesGlobales.TPH_BandaRecicladoSimulada = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Recicladoen100kg) * 2.5;//60 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.TPH_BandaRecicladoSimulada = 0;

                if (MotoresGlobalesSimulados.BombaAsfaltoAdelante == 1)
                    VariablesGlobales.TPH_BasculaAsfaltoSimulada = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Asfaltoen100kg) * 2.5;//60 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.TPH_BasculaAsfaltoSimulada = 0;

            }
        }

        //visualizar prendido de motores

        private void VisualizarMotores()

        {


            if (VariablesGlobales.DiagramaPlantaOculta == false)
            {
                this.Show();
            }

            Ind_Master.Text = VariablesGlobales.MasterMezcla.ToString();

            //********MODO SIMULADOR*****\\\\\\\\\\\\\\

            if (VariablesGlobales.Simulador == true)
            {

                TPH_Agregado1.Text = VariablesGlobales.VelocidadAgregado1TPH.ToString() + " TPH";
                TPH_Agregado2.Text = VariablesGlobales.VelocidadAgregado2TPH.ToString() + " TPH";
                TPH_Agregado3.Text = VariablesGlobales.VelocidadAgregado3TPH.ToString() + " TPH";
                TPH_Agregado4.Text = VariablesGlobales.VelocidadAgregado4TPH.ToString() + " TPH";
                TPH_BandaReciclado.Text = VariablesGlobales.TPH_BandaRecicladoSimulada.ToString() + " TPH";
                //TPH_BasculaAsfalto.Text = VariablesGlobales.TPH_BasculaAsfaltoSimulada.ToString();


                VariablesGlobales.TPH_BandaPrincipalSimulada = VariablesGlobales.VelocidadAgregado1TPH + VariablesGlobales.VelocidadAgregado2TPH + VariablesGlobales.VelocidadAgregado3TPH + VariablesGlobales.VelocidadAgregado4TPH;
                TPH_BandaPrincipal.Text = VariablesGlobales.TPH_BandaPrincipalSimulada.ToString() + " TPH";
                //banda alimentadora
                if (MotoresGlobalesSimulados.BandaAlimentadora == 1)
                {
                    IndBandaInclinada.BackColor = Color.Green;
                    IndBandaInclinada.Text = "ON";
                }
                else
                {
                    IndBandaInclinada.BackColor = Color.Gray;
                    IndBandaInclinada.Text = "OFF";
                }

                //zaranda
                if (MotoresGlobalesSimulados.Zaranda == 1)
                {
                    IndZaranda.BackColor = Color.Green;
                    IndZaranda.Text = "ON";
                }
                else
                {
                    IndZaranda.BackColor = Color.Gray;
                    IndZaranda.Text = "OFF";
                }

                //Banda Colectora
                //zaranda
                if (MotoresGlobalesSimulados.BandaColectora == 1)
                {
                    IndBandaColectora.BackColor = Color.Green;
                    IndBandaColectora.Text = "ON";
                }
                else
                {
                    IndBandaColectora.BackColor = Color.Gray;
                    IndBandaColectora.Text = "OFF";
                }

                //Banda Agregado1
                //zaranda
                if (MotoresGlobalesSimulados.BandaAgregados1 == 1)
                {
                    IndBandaAgregados1.BackColor = Color.Green;
                    IndBandaAgregados1.Text = "ON";
                }
                else
                {
                    IndBandaAgregados1.BackColor = Color.Gray;
                    IndBandaAgregados1.Text = "OFF";
                }

                //Banda Agregado2
                //zaranda
                if (MotoresGlobalesSimulados.BandaAgregados2 == 1)
                {
                    IndBandaAgregados2.BackColor = Color.Green;
                    IndBandaAgregados2.Text = "ON";
                }
                else
                {
                    IndBandaAgregados2.BackColor = Color.Gray;
                    IndBandaAgregados2.Text = "OFF";
                }

                //Banda Agregado3
                //zaranda
                if (MotoresGlobalesSimulados.BandaAgregados3 == 1)
                {
                    IndBandaAgregados3.BackColor = Color.Green;
                    IndBandaAgregados3.Text = "ON";
                }
                else
                {
                    IndBandaAgregados3.BackColor = Color.Gray;
                    IndBandaAgregados3.Text = "OFF";
                }


                //Banda Agregado4
                //zaranda
                if (MotoresGlobalesSimulados.BandaAgregados4 == 1)
                {
                    IndBandaAgregados4.BackColor = Color.Green;
                    IndBandaAgregados4.Text = "ON";
                }
                else
                {
                    IndBandaAgregados4.BackColor = Color.Gray;
                    IndBandaAgregados4.Text = "OFF";
                }


                //Compuerta reciclado
                if (MotoresGlobalesSimulados.CompuertaReciclado == 1)
                {
                    IndCompuertaReciclado.BackColor = Color.Green;
                    IndCompuertaReciclado.Text = "SECADOR";
                }
                else
                {
                    IndCompuertaReciclado.BackColor = Color.Gray;
                    IndCompuertaReciclado.Text = "RECHAZO";
                }


                //DrummBypass  "Permite prender las bandas con el secador apagado"
                if (VariablesGlobales.DrumBypass == 1)
                {
                    IndDrumBypass.BackColor = Color.Green;
                    IndDrumBypass.Text = "Drum\nBypassON";
                }
                else
                {
                    IndDrumBypass.BackColor = Color.Gray;
                    IndDrumBypass.Text = "Drum\nBypassOFF";
                }

                //Indicador banda de Reciclado
                if (MotoresGlobalesSimulados.BandaInclinadaReciclado == 1)
                {
                    IndBandaReciclado.BackColor = Color.Green;
                    IndBandaReciclado.Text = "ON";
                }
                else
                {
                    IndBandaReciclado.BackColor = Color.Gray;
                    IndBandaReciclado.Text = "OFF";
                }

                //Indicador Motor triturado reciclado (Scalper)
                if (MotoresGlobalesSimulados.MotorTrituradoReciclado == 1)
                {
                    IndMotorTrituradoReciclado.BackColor = Color.Green;
                    IndMotorTrituradoReciclado.Text = "ON";
                }
                else
                {
                    IndMotorTrituradoReciclado.BackColor = Color.Gray;
                    IndMotorTrituradoReciclado.Text = "OFF";
                }




                // Indicador Banda Agregado Reciclado
                if (MotoresGlobalesSimulados.BandaAgregadoReciclado == 1)
                {
                    IndAgregadoReciclado.BackColor = Color.Green;
                    IndAgregadoReciclado.Text = "ON";
                }
                else
                {
                    IndAgregadoReciclado.BackColor = Color.Gray;
                    IndAgregadoReciclado.Text = "OFF";
                }

                //Indicador Motor Blower Bag House
                if (MotoresGlobalesSimulados.MotorBlowerBH == 1)
                {
                    IndBlowerBH.BackColor = Color.Green;
                    IndBlowerBH.Text = "ON BLOWER";
                }
                else
                {
                    IndBlowerBH.BackColor = Color.Gray;
                    IndBlowerBH.Text = "OFF BLOWER";
                }


                //Indicador Motor Vanner BH
                if (MotoresGlobalesSimulados.MotorVannerBH == 1)
                {
                    IndVannerBH.BackColor = Color.Green;
                    IndVannerBH.Text = "ON VANNER";
                }
                else
                {
                    IndVannerBH.BackColor = Color.Gray;
                    IndVannerBH.Text = "OFF VANNER";
                }

                //Indicador Motor Colector1 BH
                if (MotoresGlobalesSimulados.SinFinColector1BH == 1)
                {
                    IndColector1BH.BackColor = Color.Green;
                    IndColector1BH.Text = "ON COLECTOR1";
                }
                else
                {
                    IndColector1BH.BackColor = Color.Gray;
                    IndColector1BH.Text = "OFF COLECTOR1";
                }


                //Indicador Motor Colector2 BH
                if (MotoresGlobalesSimulados.SinFinColector2BH == 1)
                {
                    IndColector2BH.BackColor = Color.Green;
                    IndColector2BH.Text = "ON COLECTOR2";
                }
                else
                {
                    IndColector2BH.BackColor = Color.Gray;
                    IndColector2BH.Text = "OFF COLECTOR2";
                }


                //Indicador Motor Transversal BH
                if (MotoresGlobalesSimulados.SinFinTransversalBH == 1)
                {
                    IndTransversalBH.BackColor = Color.Green;
                    IndTransversalBH.Text = "ON TRANSV.";
                }
                else
                {
                    IndTransversalBH.BackColor = Color.Gray;
                    IndTransversalBH.Text = "OFF TRANSV.";
                }

                //Indicador Rotor1BH
                if (MotoresGlobalesSimulados.Rotor1BH == 1)
                {
                    IndRotor1BH_.BackColor = Color.Green;
                    IndRotor1BH_.Text = "ON";
                }
                else
                {
                    IndRotor1BH_.BackColor = Color.Gray;
                    IndRotor1BH_.Text = "OFF";
                }

                //Indicador Rotor2BH
                if (MotoresGlobalesSimulados.Rotor2BH == 1)
                {
                    IndRotor2BH_.BackColor = Color.Green;
                    IndRotor2BH_.Text = "ON";
                }
                else
                {
                    IndRotor2BH_.BackColor = Color.Gray;
                    IndRotor2BH_.Text = "OFF";
                }

                //Indicador Rotor3BH
                if (MotoresGlobalesSimulados.Rotor3BH == 1)
                {
                    IndRotor3BH_.BackColor = Color.Green;
                    IndRotor3BH_.Text = "ON";
                }
                else
                {
                    IndRotor3BH_.BackColor = Color.Gray;
                    IndRotor3BH_.Text = "OFF";
                }


                //Indicador Sensor de posición Rotor1BH
                if (VariablesGlobales.SensorPosRotor1BH == 1 || EntradasGlobales.SensorPosRotor1 == '1')
                {
                    IndSensorPosRotor1.BackColor = Color.Green;
                    IndSensorPosRotor1.Text = "1";
                }
                else
                {
                    IndSensorPosRotor1.BackColor = Color.Gray;
                    IndSensorPosRotor1.Text = "0";
                }
                //Indicador Sensor de posición Rotor2BH
                if (VariablesGlobales.SensorPosRotor2BH == 1 || EntradasGlobales.SensorPosRotor2 == '1')
                {
                    IndSensorPosRotor2.BackColor = Color.Green;
                    IndSensorPosRotor2.Text = "1";
                }
                else
                {
                    IndSensorPosRotor2.BackColor = Color.Gray;
                    IndSensorPosRotor2.Text = "0";
                }
                //Indicador Sensor de posición Rotor3BH
                if (VariablesGlobales.SensorPosRotor3BH == 1 || EntradasGlobales.SensorPosRotor3 == '1')
                {
                    IndSensorPosRotor3.BackColor = Color.Green;
                    IndSensorPosRotor3.Text = "1";
                }
                else
                {
                    IndSensorPosRotor3.BackColor = Color.Gray;
                    IndSensorPosRotor3.Text = "0";
                }


                //Indicador Compresor 
                if (MotoresGlobalesSimulados.Compresor == 1)
                {
                    IndCompresor.BackColor = Color.Green;
                    IndCompresor.Text = "ON";
                }
                else
                {
                    IndCompresor.BackColor = Color.Gray;
                    IndCompresor.Text = "OFF";
                }


                //Indicador Bomba de Asfalto 
                if (MotoresGlobalesSimulados.BombaAsfaltoAdelante == 1)
                {
                    IndBombaAsfalto.BackColor = Color.Green;
                    IndBombaAsfalto.Text = "B.ASFALTO \n ADELANTE";

                }
                else
                {
                    if (MotoresGlobalesSimulados.BombaAsfaltoAtras == 1)
                    {
                        IndBombaAsfalto.BackColor = Color.Green;
                        IndBombaAsfalto.Text = "B.ASFALTO \n ATRAS";
                    }
                    else
                    {
                        IndBombaAsfalto.BackColor = Color.Gray;
                        IndBombaAsfalto.Text = "B.ASFALTO \n STOP";
                    }
                }

                // Indicador Extractor 1 Bag House
                if (MotoresGlobalesSimulados.Extractor1BH == 1)
                {
                    IndExtractor1BH.BackColor = Color.Green;
                    IndExtractor1BH.Text = "ON";
                }
                else
                {
                    IndExtractor1BH.BackColor = Color.Gray;
                    IndExtractor1BH.Text = "OFF";
                }


                // Indicador Extractor 2 Bag House
                if (MotoresGlobalesSimulados.Extractor2BH == 1)
                {
                    IndExtractor2BH.BackColor = Color.Green;
                    IndExtractor2BH.Text = "ON";
                }
                else
                {
                    IndExtractor2BH.BackColor = Color.Gray;
                    IndExtractor2BH.Text = "OFF";
                }

                // Indicador Extractor 2 Bag House
                if (MotoresGlobalesSimulados.BlowerQuemador == 1)
                {
                    IndBlowerQuemador.BackColor = Color.Green;
                    IndBlowerQuemador.Text = "ON";
                }
                else
                {
                    IndBlowerQuemador.BackColor = Color.Gray;
                    IndBlowerQuemador.Text = "OFF";
                }


                // Indicador Elevador
                if (MotoresGlobalesSimulados.Elevador == 1)
                {
                    IndElevador.BackColor = Color.Green;
                    IndElevador.Text = "ON";
                }
                else
                {
                    IndElevador.BackColor = Color.Gray;
                    IndElevador.Text = "OFF";
                }

                // Indicador Secador
                if (MotoresGlobalesSimulados.Secador == 1)
                {
                    IndSecador.BackColor = Color.Green;
                    IndSecador.Text = "ON";
                }
                else
                {
                    IndSecador.BackColor = Color.Gray;
                    IndSecador.Text = "OFF";
                }


                //Indicador Slinger 
                if (MotoresGlobalesSimulados.SlingerAdelante == 1)
                {
                    IndSlinger.BackColor = Color.Green;
                    IndSlinger.Text = "SLINGER \n ADELANTE";

                }
                else
                {
                    if (MotoresGlobalesSimulados.SlingerAtras == 1)
                    {
                        IndSlinger.BackColor = Color.Green;
                        IndSlinger.Text = "SLINGER \n ATRAS";
                    }
                    else
                    {
                        IndSlinger.BackColor = Color.Gray;
                        IndSlinger.Text = "SLINGER \n STOP";
                    }
                }

                // Indicador Bomba de Combustible
                if (MotoresGlobalesSimulados.BombaCombustible == 1)
                {
                    IndBombaCombustible.BackColor = Color.Green;
                    IndBombaCombustible.Text = "ON";
                }
                else
                {
                    IndBombaCombustible.BackColor = Color.Gray;
                    IndBombaCombustible.Text = "OFF";
                }

                //Indicador Damper Manual Automático
                if (VariablesGlobales.DamperAutomaticoManual == 1)
                {
                    //IndDamper.BackColor = Color.Gray;
                    IndDamper.Text = "AUTOMATICO";
                }
                else
                {
                    //IndDamper.BackColor = Color.Gray;
                    IndDamper.Text = "MANUAL";
                }

                //valor posición damper
                IndPosicionDamperQuemador.Text = VariablesGlobales.PosicionDamperQuemador.ToString();
                //valor posición damper aire
                IndPosicionDamperExtractorBH.Text = VariablesGlobales.PosicionDamperExtractorBH.ToString();

                // Ind tipo de combustible
                if (VariablesGlobales.CombustibleAceiteGas == 1)
                    IndCombustible.Text = "ACEITE";
                else
                    IndCombustible.Text = "GAS";

                //////********************** Indicador Pioloto y llama****\\\\\\\\\\\\\\\\\\\\\
                if (MotoresGlobalesSimulados.Compresor == 1 && MotoresGlobalesSimulados.CompuertaGanso == 1 && MotoresGlobalesSimulados.Extractor1BH == 1 && MotoresGlobalesSimulados.Extractor2BH == 1 && MotoresGlobalesSimulados.BombaCombustible == 1 && MotoresGlobalesSimulados.BlowerQuemador == 1 && VariablesGlobales.ResetPilotoLlamaPrincipal == 0)
                {
                    MotoresGlobalesSimulados.R8090ControlLLama = 1;  //encendido del control Honeywell R8090;
                    IndR8090ControlLlama.BackColor = Color.YellowGreen;
                    if (VariablesGlobales.ContadorParaPiloto >= 5 && VariablesGlobales.ContadorParaPiloto <= 15) //** simulación entrada de piloto proveniente de R8090   
                        VariablesGlobales.EntradaPilotoR8090 = 1;//**     simulación de entrada de piloto proveniente de R8090
                    else
                        VariablesGlobales.EntradaPilotoR8090 = 0;//**     simulación de entrada de piloto proveniente de R8090
                }
                else
                {
                    MotoresGlobalesSimulados.R8090ControlLLama = 0;  //apagarcontrol Honeywell R8090;
                    MotoresGlobalesSimulados.ValvulaAceite = 0;  //válvulas cerradas
                    MotoresGlobalesSimulados.ValvulaGas = 0;  // válvulas cerradas
                    IndR8090ControlLlama.BackColor = Color.Gray;
                    VariablesGlobales.ContadorParaPiloto = 0;
                    VariablesGlobales.EntradaPilotoR8090 = 0;//** entrada simulada debe provenir del R8090
                    VariablesGlobales.EntradaMainR8090 = 0;//** simulación entrada del Main
                    IndLlamaPrincipal.Text = "LLAMA PRIN\n CIPAL OFF";// llama apagada
                    IndLlamaPrincipal.BackColor = Color.Gray;// llama apagada
                    VariablesGlobales.PilotoBoton = 0;      //para que el boton de piloto quede gris 
                    VariablesGlobales.LlamaPrincipalBoton = 0; //para que el boton de llama principal quede gris
                }
                if (VariablesGlobales.EntradaPilotoR8090 == 1)
                {
                    IndPiloto.BackColor = Color.GreenYellow;
                    IndPiloto.Text = "PILOTO \n HABILITADO";
                    if (VariablesGlobales.PilotoBoton == 1)
                    {
                        IndPiloto.Text = "PILOTO \n PRESIONADO";
                        MotoresGlobalesSimulados.PilotoValvula = 1;
                        VariablesGlobales.EntradaMainR8090 = 1;//** simulación entrada del Main
                    }
                }
                else
                {
                    IndPiloto.BackColor = Color.Gray;
                    IndPiloto.Text = "PILOTO OFF";
                    VariablesGlobales.PilotoBoton = 0; //resetea piloto boton
                }

                if (VariablesGlobales.EntradaMainR8090 == 1)
                {
                    IndLlamaPrincipal.BackColor = Color.GreenYellow; //hasta que se resetee con el boton
                    if (MotoresGlobalesSimulados.ValvulaAceite == 0 && MotoresGlobalesSimulados.ValvulaGas == 0)// para que muestre el habilitado
                        IndLlamaPrincipal.Text = "LLAMA PRINCIPAL \nHABILITADO";// o si no que muestre con cual esta siendo alimentada la llama
                    if (VariablesGlobales.LlamaPrincipalBoton == 1 && VariablesGlobales.EntradaPilotoR8090 == 1)
                    {

                        if (VariablesGlobales.CombustibleAceiteGas == 1)
                        {
                            MotoresGlobalesSimulados.ValvulaAceite = 1;
                            IndLlamaPrincipal.Text = "LLAMA (Aceite) \nENCENDIDA";

                        }
                        else
                        {


                            MotoresGlobalesSimulados.ValvulaGas = 1;
                            IndLlamaPrincipal.Text = "LLAMA (Gas) \nENCENDIDA";

                        }
                    }

                }


                else
                {
                    IndLlamaPrincipal.BackColor = Color.Gray;
                    IndLlamaPrincipal.Text = "Llama Prin\ncipal OFF";
                    VariablesGlobales.LlamaPrincipalBoton = 0; //resetea piloto boton
                }


                /////////////**************fin controlador piloto y llama principal**************\\\\\\\\\\\\\


                //Comportamiento Ganso
                if (MotoresGlobalesSimulados.Compresor == 1 && MotoresGlobalesSimulados.Extractor1BH == 1 && MotoresGlobalesSimulados.Extractor1BH == 1 && VariablesGlobales.EntradaTemperaturaGanso <= VariablesGlobales.SetPointTemperaturaGanso) //condiciones para abrir o cerrar compuerta del ganso
                {
                    MotoresGlobalesSimulados.CompuertaGanso = 1;//abrir compuerta para ganso
                    IndCompuertaGanso.BackColor = Color.Blue;
                    IndCompuertaGanso.Text = "Compuerta \n Abierta";
                }
                else
                {
                    MotoresGlobalesSimulados.CompuertaGanso = 0;//cerrar compuerta para ganso
                    IndCompuertaGanso.BackColor = Color.Gray;
                    IndCompuertaGanso.Text = "Compuerta \n Cerrada";
                }

            }


            else     //***********MODO REAL metodo de visualización******************\\\\\\\\\\\\\\\\\\\\\\\\\
            {
                //banda alimentadora
                if (EntradasGlobales.BandaAlimentadora == '1')
                {
                    IndBandaInclinada.BackColor = Color.Green;
                    IndBandaInclinada.Text = "ON";
                }
                else
                {
                    IndBandaInclinada.BackColor = Color.Gray;
                    IndBandaInclinada.Text = "OFF";
                }

                //zaranda
                if (EntradasGlobales.Zaranda == '1')
                {
                    IndZaranda.BackColor = Color.Green;
                    IndZaranda.Text = "ON";
                }
                else
                {
                    IndZaranda.BackColor = Color.Gray;
                    IndZaranda.Text = "OFF";
                }

                //Banda Colectora
                //zaranda
                if (EntradasGlobales.BandaColectora == '1')
                {
                    IndBandaColectora.BackColor = Color.Green;
                    IndBandaColectora.Text = "ON";
                }
                else
                {
                    IndBandaColectora.BackColor = Color.Gray;
                    IndBandaColectora.Text = "OFF";
                }

                //Banda Agregado1
                //zaranda
                if (EntradasGlobales.BandaAgregados1 == '1')
                {
                    IndBandaAgregados1.BackColor = Color.Green;
                    IndBandaAgregados1.Text = "ON";
                }
                else
                {
                    IndBandaAgregados1.BackColor = Color.Gray;
                    IndBandaAgregados1.Text = "OFF";
                }

                //Banda Agregado2
                //zaranda
                if (EntradasGlobales.BandaAgregados2 == '1')
                {
                    IndBandaAgregados2.BackColor = Color.Green;
                    IndBandaAgregados2.Text = "ON";
                }
                else
                {
                    IndBandaAgregados2.BackColor = Color.Gray;
                    IndBandaAgregados2.Text = "OFF";
                }

                //Banda Agregado3
                //zaranda
                if (EntradasGlobales.BandaAgregados3 == '1')
                {
                    IndBandaAgregados3.BackColor = Color.Green;
                    IndBandaAgregados3.Text = "ON";
                }
                else
                {
                    IndBandaAgregados3.BackColor = Color.Gray;
                    IndBandaAgregados3.Text = "OFF";
                }


                //Banda Agregado4
                //zaranda
                if (EntradasGlobales.BandaAgregados4 == '1')
                {
                    IndBandaAgregados4.BackColor = Color.Green;
                    IndBandaAgregados4.Text = "ON";
                }
                else
                {
                    IndBandaAgregados4.BackColor = Color.Gray;
                    IndBandaAgregados4.Text = "OFF";
                }


                //Compuerta reciclado
                if (EntradasGlobales.CompuertaReciclado == '1')
                {
                    IndCompuertaReciclado.BackColor = Color.Green;
                    IndCompuertaReciclado.Text = "SECADOR";
                }
                else
                {
                    IndCompuertaReciclado.BackColor = Color.Gray;
                    IndCompuertaReciclado.Text = "RECHAZO";
                }


                //DrummBypass  "Permite prender las bandas con el secador apagado"
                if (VariablesGlobales.DrumBypass == 1)
                {
                    IndDrumBypass.BackColor = Color.Green;
                    IndDrumBypass.Text = "Drum\nBypassON";
                }
                else
                {
                    IndDrumBypass.BackColor = Color.Gray;
                    IndDrumBypass.Text = "Drum\nBypassOFF";
                }

                //Indicador banda de Reciclado
                if (EntradasGlobales.BandaInclinadaReciclado == '1')
                {
                    IndBandaReciclado.BackColor = Color.Green;
                    IndBandaReciclado.Text = "ON";
                }
                else
                {
                    IndBandaReciclado.BackColor = Color.Gray;
                    IndBandaReciclado.Text = "OFF";
                }

                //Indicador Motor triturado reciclado (Scalper)
                if (EntradasGlobales.MotorTrituradoReciclado == '1')
                {
                    IndMotorTrituradoReciclado.BackColor = Color.Green;
                    IndMotorTrituradoReciclado.Text = "ON";
                }
                else
                {
                    IndMotorTrituradoReciclado.BackColor = Color.Gray;
                    IndMotorTrituradoReciclado.Text = "OFF";
                }




                // Indicador Banda Agregado Reciclado
                if (EntradasGlobales.BandaAgregadoReciclado == '1')
                {
                    IndAgregadoReciclado.BackColor = Color.Green;
                    IndAgregadoReciclado.Text = "ON";
                }
                else
                {
                    IndAgregadoReciclado.BackColor = Color.Gray;
                    IndAgregadoReciclado.Text = "OFF";
                }

                //Indicador Motor Blower Bag House
                if (EntradasGlobales.MotorBlowerBH == '1')
                {
                    IndBlowerBH.BackColor = Color.Green;
                    IndBlowerBH.Text = "ON BLOWER";
                }
                else
                {
                    IndBlowerBH.BackColor = Color.Gray;
                    IndBlowerBH.Text = "OFF BLOWER";
                }


                //Indicador Motor Vanner BH
                if (EntradasGlobales.MotorVannerBH == '1')
                {
                    IndVannerBH.BackColor = Color.Green;
                    IndVannerBH.Text = "ON VANNER";
                }
                else
                {
                    IndVannerBH.BackColor = Color.Gray;
                    IndVannerBH.Text = "OFF VANNER";
                }

                //Indicador Motor Colector1 BH
                if (EntradasGlobales.SinFinColector1BH == '1')
                {
                    IndColector1BH.BackColor = Color.Green;
                    IndColector1BH.Text = "ON COLECTOR1";
                }
                else
                {
                    IndColector1BH.BackColor = Color.Gray;
                    IndColector1BH.Text = "OFF COLECTOR1";
                }


                //Indicador Motor Colector2 BH
                if (EntradasGlobales.SinFinColector2BH == '1')
                {
                    IndColector2BH.BackColor = Color.Green;
                    IndColector2BH.Text = "ON COLECTOR2";
                }
                else
                {
                    IndColector2BH.BackColor = Color.Gray;
                    IndColector2BH.Text = "OFF COLECTOR2";
                }


                //Indicador Motor Transversal BH
                if (EntradasGlobales.SinFinTransversalBH == '1')
                {
                    IndTransversalBH.BackColor = Color.Green;
                    IndTransversalBH.Text = "ON TRANSV.";
                }
                else
                {
                    IndTransversalBH.BackColor = Color.Gray;
                    IndTransversalBH.Text = "OFF TRANSV.";
                }

                //Indicador Rotor1BH
                if (EntradasGlobales.Rotor1BH == '1')
                {
                    IndRotor1BH_.BackColor = Color.Green;
                    IndRotor1BH_.Text = "ON";
                }
                else
                {
                    IndRotor1BH_.BackColor = Color.Gray;
                    IndRotor1BH_.Text = "OFF";
                }

                //Indicador Rotor2BH
                if (EntradasGlobales.Rotor2BH == '1')
                {
                    IndRotor2BH_.BackColor = Color.Green;
                    IndRotor2BH_.Text = "ON";
                }
                else
                {
                    IndRotor2BH_.BackColor = Color.Gray;
                    IndRotor2BH_.Text = "OFF";
                }

                //Indicador Rotor3BH
                if (EntradasGlobales.Rotor3BH == '1')
                {
                    IndRotor3BH_.BackColor = Color.Green;
                    IndRotor3BH_.Text = "ON";
                }
                else
                {
                    IndRotor3BH_.BackColor = Color.Gray;
                    IndRotor3BH_.Text = "OFF";
                }


                //Indicador Sensor de posición Rotor1BH
                if (VariablesGlobales.SensorPosRotor1BH == 1 || EntradasGlobales.SensorPosRotor1 == '1')
                {
                    IndSensorPosRotor1.BackColor = Color.Green;
                    IndSensorPosRotor1.Text = "1";
                }
                else
                {
                    IndSensorPosRotor1.BackColor = Color.Gray;
                    IndSensorPosRotor1.Text = "0";
                }
                //Indicador Sensor de posición Rotor2BH
                if (VariablesGlobales.SensorPosRotor2BH == 1 || EntradasGlobales.SensorPosRotor2 == '1')
                {
                    IndSensorPosRotor2.BackColor = Color.Green;
                    IndSensorPosRotor2.Text = "1";
                }
                else
                {
                    IndSensorPosRotor2.BackColor = Color.Gray;
                    IndSensorPosRotor2.Text = "0";
                }
                //Indicador Sensor de posición Rotor3BH
                if (VariablesGlobales.SensorPosRotor3BH == 1 || EntradasGlobales.SensorPosRotor3 == '1')
                {
                    IndSensorPosRotor3.BackColor = Color.Green;
                    IndSensorPosRotor3.Text = "1";
                }
                else
                {
                    IndSensorPosRotor3.BackColor = Color.Gray;
                    IndSensorPosRotor3.Text = "0";
                }


                //Indicador Compresor 
                if (EntradasGlobales.Compresor == '1')
                {
                    IndCompresor.BackColor = Color.Green;
                    IndCompresor.Text = "ON";
                }
                else
                {
                    IndCompresor.BackColor = Color.Gray;
                    IndCompresor.Text = "OFF";
                }


                //Indicador Bomba de Asfalto 
                if (EntradasGlobales.BombaAsfaltoAdelante == '1')
                {
                    IndBombaAsfalto.BackColor = Color.Green;
                    IndBombaAsfalto.Text = "B.ASFALTO \n ADELANTE";

                }
                else
                {
                    if (EntradasGlobales.BombaAsfaltoAtras == '1')
                    {
                        IndBombaAsfalto.BackColor = Color.Green;
                        IndBombaAsfalto.Text = "B.ASFALTO \n ATRAS";
                    }
                    else
                    {
                        IndBombaAsfalto.BackColor = Color.Gray;
                        IndBombaAsfalto.Text = "B.ASFALTO \n STOP";
                    }
                }

                // Indicador Extractor 1 Bag House
                if (EntradasGlobales.Extractor1BH == '1')
                {
                    IndExtractor1BH.BackColor = Color.Green;
                    IndExtractor1BH.Text = "ON";
                }
                else
                {
                    IndExtractor1BH.BackColor = Color.Gray;
                    IndExtractor1BH.Text = "OFF";
                }


                // Indicador Extractor 2 Bag House
                if (EntradasGlobales.Extractor2BH == '1')
                {
                    IndExtractor2BH.BackColor = Color.Green;
                    IndExtractor2BH.Text = "ON";
                }
                else
                {
                    IndExtractor2BH.BackColor = Color.Gray;
                    IndExtractor2BH.Text = "OFF";
                }

                // Indicador Extractor 2 Bag House
                if (EntradasGlobales.BlowerQuemador == '1')
                {
                    IndBlowerQuemador.BackColor = Color.Green;
                    IndBlowerQuemador.Text = "ON";
                }
                else
                {
                    IndBlowerQuemador.BackColor = Color.Gray;
                    IndBlowerQuemador.Text = "OFF";
                }


                // Indicador Elevador
                if (EntradasGlobales.Elevador == '1')
                {
                    IndElevador.BackColor = Color.Green;
                    IndElevador.Text = "ON";
                }
                else
                {
                    IndElevador.BackColor = Color.Gray;
                    IndElevador.Text = "OFF";
                }

                // Indicador Secador
                if (EntradasGlobales.Secador == '1')
                {
                    IndSecador.BackColor = Color.Green;
                    IndSecador.Text = "ON";
                }
                else
                {
                    IndSecador.BackColor = Color.Gray;
                    IndSecador.Text = "OFF";
                }


                //Indicador Slinger 
                if (EntradasGlobales.SlingerAdelante == '1')
                {
                    IndSlinger.BackColor = Color.Green;
                    IndSlinger.Text = "SLINGER \n ADELANTE";

                }
                else
                {
                    if (EntradasGlobales.SlingerAtras == '1')
                    {
                        IndSlinger.BackColor = Color.Green;
                        IndSlinger.Text = "SLINGER \n ATRAS";
                    }
                    else
                    {
                        IndSlinger.BackColor = Color.Gray;
                        IndSlinger.Text = "SLINGER \n STOP";
                    }
                }

                // Indicador Bomba de Combustible
                if (EntradasGlobales.BombaCombustible == '1')
                {
                    IndBombaCombustible.BackColor = Color.Green;
                    IndBombaCombustible.Text = "ON";
                }
                else
                {
                    IndBombaCombustible.BackColor = Color.Gray;
                    IndBombaCombustible.Text = "OFF";
                }

                //Indicador Damper Manual Automático
                if (VariablesGlobales.DamperAutomaticoManual == 1)
                {
                    //IndDamper.BackColor = Color.Gray;
                    IndDamper.Text = "AUTOMATICO";
                }
                else
                {
                    //IndDamper.BackColor = Color.Gray;
                    IndDamper.Text = "MANUAL";
                }

                //valor posición damper
                IndPosicionDamperQuemador.Text = VariablesGlobales.PosicionDamperQuemador.ToString();
                //valor posición damper aire
                IndPosicionDamperExtractorBH.Text = VariablesGlobales.PosicionDamperExtractorBH.ToString();

                // Ind tipo de combustible
                if (VariablesGlobales.CombustibleAceiteGas == 1)
                    IndCombustible.Text = "ACEITE";
                else
                    IndCombustible.Text = "GAS";

                //////********************** Indicador Pioloto y llama****\\\\\\\\\\\\\\\\\\\\\
                if (EntradasGlobales.Compresor == '1' && EntradasGlobales.CompuertaGanso == '1' && EntradasGlobales.Extractor1BH == '1' && EntradasGlobales.Extractor2BH == '1' && EntradasGlobales.BombaCombustible == '1' && EntradasGlobales.BlowerQuemador == '1' && VariablesGlobales.ResetPilotoLlamaPrincipal == 0)
                {
                    EntradasGlobales.R8090ControlLLama = '1';  //encendido del control Honeywell R8090;
                    IndR8090ControlLlama.BackColor = Color.YellowGreen;
                    if (VariablesGlobales.ContadorParaPiloto >= 5 && VariablesGlobales.ContadorParaPiloto <= 15) //** simulación entrada de piloto proveniente de R8090   
                        VariablesGlobales.EntradaPilotoR8090 = 1;//**     simulación de entrada de piloto proveniente de R8090
                    else
                        VariablesGlobales.EntradaPilotoR8090 = 0;//**     simulación de entrada de piloto proveniente de R8090
                }
                else
                {
                    EntradasGlobales.R8090ControlLLama = '0';  //apagarcontrol Honeywell R8090;
                    EntradasGlobales.ValvulaAceite = '0';  //válvulas cerradas
                    EntradasGlobales.ValvulaGas = '0';  // válvulas cerradas
                    IndR8090ControlLlama.BackColor = Color.Gray;
                    VariablesGlobales.ContadorParaPiloto = 0;
                    VariablesGlobales.EntradaPilotoR8090 = 0;//** entrada simulada debe provenir del R8090
                    VariablesGlobales.EntradaMainR8090 = 0;//** simulación entrada del Main
                    IndLlamaPrincipal.Text = "LLAMA PRIN\n CIPAL OFF";// llama apagada
                    IndLlamaPrincipal.BackColor = Color.Gray;// llama apagada
                    VariablesGlobales.PilotoBoton = 0;      //para que el boton de piloto quede gris 
                    VariablesGlobales.LlamaPrincipalBoton = 0; //para que el boton de llama principal quede gris
                }
                if (VariablesGlobales.EntradaPilotoR8090 == 1)
                {
                    IndPiloto.BackColor = Color.GreenYellow;
                    IndPiloto.Text = "PILOTO \n HABILITADO";
                    if (VariablesGlobales.PilotoBoton == 1)
                    {
                        IndPiloto.Text = "PILOTO \n PRESIONADO";
                        EntradasGlobales.PilotoValvula = '1';
                        VariablesGlobales.EntradaMainR8090 = 1;//** simulación entrada del Main
                    }
                }
                else
                {
                    IndPiloto.BackColor = Color.Gray;
                    IndPiloto.Text = "PILOTO OFF";
                    VariablesGlobales.PilotoBoton = 0; //resetea piloto boton
                }

                if (VariablesGlobales.EntradaMainR8090 == 1)
                {
                    IndLlamaPrincipal.BackColor = Color.GreenYellow; //hasta que se resetee con el boton
                    if (EntradasGlobales.ValvulaAceite == '0' && EntradasGlobales.ValvulaGas == '0')// para que muestre el habilitado
                        IndLlamaPrincipal.Text = "LLAMA PRINCIPAL \nHABILITADO";// o si no que muestre con cual esta siendo alimentada la llama
                    if (VariablesGlobales.LlamaPrincipalBoton == 1 && VariablesGlobales.EntradaPilotoR8090 == 1)
                    {

                        if (VariablesGlobales.CombustibleAceiteGas == 1)
                        {
                            EntradasGlobales.ValvulaAceite = '1';
                            IndLlamaPrincipal.Text = "LLAMA (Aceite) \nENCENDIDA";

                        }
                        else
                        {


                            EntradasGlobales.ValvulaGas = '1';
                            IndLlamaPrincipal.Text = "LLAMA (Gas) \nENCENDIDA";

                        }
                    }

                }


                else
                {
                    IndLlamaPrincipal.BackColor = Color.Gray;
                    IndLlamaPrincipal.Text = "Llama Prin\ncipal OFF";
                    VariablesGlobales.LlamaPrincipalBoton = 0; //resetea piloto boton
                }


                /////////////**************fin controlador piloto y llama principal**************\\\\\\\\\\\\\


                //Comportamiento Ganso
                if (EntradasGlobales.Compresor == '1' && EntradasGlobales.Extractor1BH == '1' && EntradasGlobales.Extractor1BH == '1' && VariablesGlobales.EntradaTemperaturaGanso <= VariablesGlobales.SetPointTemperaturaGanso) //condiciones para abrir o cerrar compuerta del ganso
                {
                    EntradasGlobales.CompuertaGanso = '1';//abrir compuerta para ganso
                    IndCompuertaGanso.BackColor = Color.Blue;
                    IndCompuertaGanso.Text = "Compuerta \n Abierta";
                }
                else
                {
                    EntradasGlobales.CompuertaGanso = '0';//cerrar compuerta para ganso
                    IndCompuertaGanso.BackColor = Color.Gray;
                    IndCompuertaGanso.Text = "Compuerta \n Cerrada";
                }

            }


        }

        //***********FIN METODO DE VISUALIZACIÓN*****************\\


        //secuencia de los rotores

        private void Secuencia_Rotores()
        {
            if (VariablesGlobales.Secuencia_Rotores == 1)  //revisa si debe iniciar secuencia de rotores
            {
                if (VariablesGlobales.Secuencia_RotoresActiva == 0)
                {
                    timer2_Rotores.Start();
                    VariablesGlobales.Secuencia_RotoresActiva = 1;
                }


            }
            else
            {
                timer2_Rotores.Stop();
                VariablesGlobales.Secuencia_RotoresActiva = 0;
                if (VariablesGlobales.Simulador == true)
                {
                    MotoresGlobalesSimulados.Rotor1BH = 0;// mantener apagado rotor 1
                    MotoresGlobalesSimulados.Rotor2BH = 0;// mantener apagado rotor 2
                    MotoresGlobalesSimulados.Rotor3BH = 0;// mantener apagado rotor 3
                }
                else
                {
                    MotoresGlobales.Rotor1BH = 0;// mantener apagado rotor 1
                    MotoresGlobales.Rotor2BH = 0;// mantener apagado rotor 2
                    MotoresGlobales.Rotor3BH = 0;// mantener apagado rotor 3
                }
            }
        }

        //secuencia ciclo silo

        private void Secuencia_CicloSilo()
        {
            if (VariablesGlobales.IndBotonSiloOpenCiclo == 1)  // revisa si el boton Open del ciclo no
            {                                               // esta activo, si lo esta abre la compuerta        
                if (VariablesGlobales.Simulador == true)
                { MotoresGlobalesSimulados.AlimentacionSilo = 1; }       // y no entra al ciclo de alimentación Silo
                else
                { MotoresGlobales.AlimentacionSilo = 1; }
                IndAlimentacionSilo.BackColor = Color.Green;
                IndAlimentacionSilo.Text = "Compuerta \n Abierta \n NO CICLO";
            }

            else
            {
                if ((MotoresGlobalesSimulados.Elevador == 1 || EntradasGlobales.Elevador == '1') && VariablesGlobales.CicloSiloIniciado == 0) //revisa si el elevador está prendido ya que inicia el ciclo
                {
                    VariablesGlobales.CicloSiloIniciado = 1;
                    VariablesGlobales.TiempoCicloSilo = 0; //reinicio tiempo para ciclo silo
                }
                else
                {
                    if ((MotoresGlobalesSimulados.Elevador == 1 || EntradasGlobales.Elevador == '1') && VariablesGlobales.TiempoCicloSilo <= 20)// duración de un ciclo
                    {
                        IndAlimentacionSilo.BackColor = Color.Green;
                        IndAlimentacionSilo.Text = "CICLO \n Compuerta \n Cerrada";
                    }
                    else
                    {
                        if ((MotoresGlobalesSimulados.Elevador == 1 || EntradasGlobales.Elevador == '1') && VariablesGlobales.TiempoCicloSilo <= 23) //3 segundos para abrir compuerta
                        {
                            if (VariablesGlobales.Simulador == true)
                            { MotoresGlobalesSimulados.AlimentacionSilo = 1; }
                            else
                            { MotoresGlobales.AlimentacionSilo = 1; }
                            IndAlimentacionSilo.Text = "CICLO \n Compuerta \n Abierta";
                        }
                        else
                        {
                            VariablesGlobales.TiempoCicloSilo = 0;
                            if (VariablesGlobales.Simulador == true)
                            { MotoresGlobalesSimulados.AlimentacionSilo = 0; }
                            else
                            { MotoresGlobales.AlimentacionSilo = 0; } //cierra o mantiene cerrada la alimentación del silo
                            IndAlimentacionSilo.BackColor = Color.Gray;
                            IndAlimentacionSilo.Text = "Compuerta \n Cerrada";
                        }
                    }
                }
            }
        }






        //******************************FIN COMUNICACIÓN SERIAL*************\\\\\\\\\\\\\
        //*****************************************************************************\\


        private void timer1_Tick(object sender, EventArgs e)
        {
            //EnviarDatos();
            VisualizarMotores();  // actualiza interfaz 
            Secuencia_Rotores();  //revisa si debe iniciar secuencia de motores
            Secuencia_CicloSilo(); //revisa si el elevador está prendido para iniciar el ciclo del silo
            EnclavamientoMotores();//revisa si algún motor se apaga y varios depende de el
            VelocidadMotores();// revisa los valores del master y ajusta la velocidad de los motores 
                               // ComunicacionSerial();//envío y recepción de datos;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir paso hacia el secador, o cerrar para rechazar el material de reciclado ");
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("permite prender las bandas con el secador apagado");
        }


        //  Método que se activa cada segundo para revisar los motores

        private void timer2_Rotores_Tick(object sender, EventArgs e)
        {
            if (VariablesGlobales.SecuenciaRotor1 == 0)
            {
                if (VariablesGlobales.TiempoSalirSensorRotores <= 5)  //le da 5 segundos de encendido al motor para que deje de sensar esa posición
                {
                    if (VariablesGlobales.Simulador == true)
                    { MotoresGlobalesSimulados.Rotor1BH = 1; }
                    else
                    { MotoresGlobales.Rotor1BH = 1; }
                    VariablesGlobales.TiempoSalirSensorRotores = VariablesGlobales.TiempoSalirSensorRotores + 1; //incremento 1 segundo
                }
                else
                {
                    if (((VariablesGlobales.SensorPosRotor1BH == 0 && VariablesGlobales.Simulador == true) || (EntradasGlobales.SensorPosRotor1 == '0' && VariablesGlobales.Simulador == false)) && VariablesGlobales.TiempoSalirSensorRotores <= 20) // se oprime el label del sensor en modo simulador o detecta que no hay sensor en modo real
                    {
                        if (VariablesGlobales.Simulador == true)
                        { MotoresGlobalesSimulados.Rotor1BH = 1; }
                        else
                        { MotoresGlobales.Rotor1BH = 1; }
                        VariablesGlobales.TiempoSalirSensorRotores = VariablesGlobales.TiempoSalirSensorRotores + 1; //incremento 1 segundo

                    }
                    else
                    {
                        VariablesGlobales.TiempoSalirSensorRotores = 0;//reseteo temporizador de la secuencia
                        VariablesGlobales.SecuenciaRotor1 = 1; //terminó secuencia 1
                        if (VariablesGlobales.Simulador == true)
                        { MotoresGlobalesSimulados.Rotor1BH = 0; }
                        else
                        { MotoresGlobales.Rotor1BH = 0; }
                    }
                }
            }
            else
            {
                if (VariablesGlobales.SecuenciaRotor2 == 0)
                {
                    if (VariablesGlobales.TiempoSalirSensorRotores <= 5)
                    {
                        if (VariablesGlobales.Simulador == true)
                        { MotoresGlobalesSimulados.Rotor2BH = 1; }
                        else
                        { MotoresGlobales.Rotor2BH = 1; }

                        VariablesGlobales.TiempoSalirSensorRotores = VariablesGlobales.TiempoSalirSensorRotores + 1; //incremento 1 segundo
                    }
                    else
                    {
                        if (((VariablesGlobales.SensorPosRotor2BH == 0 && VariablesGlobales.Simulador == true) || (EntradasGlobales.SensorPosRotor2 == '0' && VariablesGlobales.Simulador == false)) && VariablesGlobales.TiempoSalirSensorRotores <= 20) // se oprime el label del sensor en modo simulador o detecta que no hay sensor en modo real
                        {
                            if (VariablesGlobales.Simulador == true)
                            { MotoresGlobalesSimulados.Rotor2BH = 1; }
                            else
                            { MotoresGlobales.Rotor2BH = 1; }
                            VariablesGlobales.TiempoSalirSensorRotores = VariablesGlobales.TiempoSalirSensorRotores + 1; //incremento 1 segundo

                        }
                        else
                        {
                            VariablesGlobales.TiempoSalirSensorRotores = 0;//reseteo temporizador de la secuencia
                            VariablesGlobales.SecuenciaRotor2 = 1; //terminó secuencia 1
                            if (VariablesGlobales.Simulador == true)
                            { MotoresGlobalesSimulados.Rotor2BH = 0; }
                            else
                            { MotoresGlobales.Rotor2BH = 0; }

                        }
                    }
                }

                else
                {
                    if (VariablesGlobales.SecuenciaRotor3 == 0)
                    {
                        if (VariablesGlobales.TiempoSalirSensorRotores <= 5)
                        {
                            if (VariablesGlobales.Simulador == true)
                            { MotoresGlobalesSimulados.Rotor3BH = 1; }
                            else
                            { MotoresGlobales.Rotor3BH = 1; }

                            VariablesGlobales.TiempoSalirSensorRotores = VariablesGlobales.TiempoSalirSensorRotores + 1; //incremento 1 segundo
                        }
                        else
                        {
                            if (((VariablesGlobales.SensorPosRotor3BH == 0 && VariablesGlobales.Simulador == true) || (EntradasGlobales.SensorPosRotor3 == '0' && VariablesGlobales.Simulador == false)) && VariablesGlobales.TiempoSalirSensorRotores <= 20) // se oprime el label del sensor en modo simulador o detecta que no hay sensor en modo real
                            {
                                if (VariablesGlobales.Simulador == true)
                                { MotoresGlobalesSimulados.Rotor3BH = 1; }
                                else
                                { MotoresGlobales.Rotor3BH = 1; }

                                VariablesGlobales.TiempoSalirSensorRotores = VariablesGlobales.TiempoSalirSensorRotores + 1; //incremento 1 segundo

                            }
                            else
                            {
                                VariablesGlobales.TiempoSalirSensorRotores = 0;//reseteo temporizador de la secuencia
                                VariablesGlobales.SecuenciaRotor3 = 1; //terminó secuencia 1
                                if (VariablesGlobales.Simulador == true)
                                { MotoresGlobalesSimulados.Rotor3BH = 0; }
                                else
                                { MotoresGlobales.Rotor3BH = 0; }

                                VariablesGlobales.SecuenciaRotor1 = 0;
                                VariablesGlobales.SecuenciaRotor2 = 0;
                                VariablesGlobales.SecuenciaRotor3 = 0;
                            }
                        }
                    }
                }

            }

        }


        //***************simulación del sensor de posición del rotor1


        private void IndSensorPosRotor1_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            {
                if (VariablesGlobales.SensorPosRotor1BH == 0)
                    VariablesGlobales.SensorPosRotor1BH = 1;
                else
                    VariablesGlobales.SensorPosRotor1BH = 0;
            }
            else//mensaje que saca si oprime el sensor en el modo real
                MessageBox.Show("Visualiza si detecta el sensor\n Del rotor No 1");
        }

        private void IndSensorPosRotor2_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            {

                if (VariablesGlobales.SensorPosRotor2BH == 0)
                    VariablesGlobales.SensorPosRotor2BH = 1;
                else
                    VariablesGlobales.SensorPosRotor2BH = 0;
            }
            else//mensaje que saca si oprime el sensor en el modo real
                MessageBox.Show("Visualiza si detecta el sensor\n Del rotor No 1");


        }

        private void IndSensorPosRotor3_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            {
                if (VariablesGlobales.SensorPosRotor3BH == 0)
                    VariablesGlobales.SensorPosRotor3BH = 1;
                else
                    VariablesGlobales.SensorPosRotor3BH = 0;
            }

            else//mensaje que saca si oprime el sensor en el modo real
                MessageBox.Show("Visualiza si detecta el sensor\n Del rotor No 1");

        }
        //***************************************\\\\\\\\\\\\\\\\\\\\




        // incremento decremento posición del damper de Quemador
        private void IndIncrementarDamper_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperQuemador < 100 && VariablesGlobales.DamperAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperQuemador = VariablesGlobales.PosicionDamperQuemador + 1;     //incrementa posición del Damper

        }

        private void IndDecrementarDamper_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperQuemador > 0 && VariablesGlobales.DamperAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperQuemador = VariablesGlobales.PosicionDamperQuemador - 1;     //decrementa posición del Damper

        }

        private void IndIncrementoDamper10_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperQuemador < 90 && VariablesGlobales.DamperAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperQuemador = VariablesGlobales.PosicionDamperQuemador + 10;     //incrementa posición del Damper

        }

        private void IndDecrementoDamper10_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperQuemador > 10 && VariablesGlobales.DamperAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperQuemador = VariablesGlobales.PosicionDamperQuemador - 10;     //incrementa posición del Damper

        }



        private void timer3_Segundo_Tick(object sender, EventArgs e)  // cuenta un segundo para diversas variables incluida ciclo silo
        {
            VariablesGlobales.TiempoCicloSilo++; //incrementa en un segundo éste tiempo
            VariablesGlobales.ContadorParaPiloto++; //**incrementa en un segunto el tiempo para piloto en el simulador
            desfaseAsfalto();//hay un desfase de n segundos para indicar el asfalto
        }


        // incremento decremento posición del damper extractor Casa de Bolsas

        private void IndIncrementoDamperAire_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperExtractorBH < 100 && VariablesGlobales.DamperAireAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperExtractorBH = VariablesGlobales.PosicionDamperExtractorBH + 1;     //incrementa posición del Damper

        }

        private void IndincrementoDamperAire10_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperExtractorBH < 90 && VariablesGlobales.DamperAireAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperExtractorBH = VariablesGlobales.PosicionDamperExtractorBH + 10;     //incrementa posición del Damper
        }

        private void IndDecrementoDamperAire_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperExtractorBH > 0 && VariablesGlobales.DamperAireAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperExtractorBH = VariablesGlobales.PosicionDamperExtractorBH - 1;     //incrementa posición del Damper
        }

        private void IndDecrementoDamperAire10_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperExtractorBH > 10 && VariablesGlobales.DamperAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperExtractorBH = VariablesGlobales.PosicionDamperExtractorBH - 10;     //incrementa posición del Damper
        }

        //*********Revisión para enclavamiento de motores*********\\\\\\\\\\\

        private void EnclavamientoMotores()
        {

            if (VariablesGlobales.Simulador == true)
            {
                if (MotoresGlobalesSimulados.Elevador == 0)
                {
                    MotoresGlobalesSimulados.Secador = 0;
                    if (VariablesGlobales.DrumBypass == 0)
                    {
                        MotoresGlobalesSimulados.BombaAsfaltoAdelante = 0;
                        MotoresGlobalesSimulados.BombaAsfaltoAtras = 0;
                        MotoresGlobalesSimulados.BandaAlimentadora = 0;
                        MotoresGlobalesSimulados.Zaranda = 0;
                        MotoresGlobalesSimulados.BandaColectora = 0;
                        MotoresGlobalesSimulados.BandaAgregados1 = 0;
                        MotoresGlobalesSimulados.BandaAgregados2 = 0;
                        MotoresGlobalesSimulados.BandaAgregados3 = 0;
                        MotoresGlobalesSimulados.BandaAgregados4 = 0;
                    }
                }

                if (MotoresGlobalesSimulados.Secador == 0 && VariablesGlobales.DrumBypass == 0)

                {
                    MotoresGlobalesSimulados.BombaAsfaltoAdelante = 0;
                    MotoresGlobalesSimulados.BombaAsfaltoAtras = 0;
                    MotoresGlobalesSimulados.BandaAlimentadora = 0;
                    MotoresGlobalesSimulados.Zaranda = 0;
                    MotoresGlobalesSimulados.BandaColectora = 0;
                    MotoresGlobalesSimulados.BandaAgregados1 = 0;
                    MotoresGlobalesSimulados.BandaAgregados2 = 0;
                    MotoresGlobalesSimulados.BandaAgregados3 = 0;
                    MotoresGlobalesSimulados.BandaAgregados4 = 0;

                }

                if (MotoresGlobalesSimulados.SlingerAdelante == 0 && MotoresGlobalesSimulados.SlingerAtras == 0)

                {
                    MotoresGlobalesSimulados.BandaAlimentadora = 0;
                    MotoresGlobalesSimulados.Zaranda = 0;
                    MotoresGlobalesSimulados.BandaColectora = 0;
                    MotoresGlobalesSimulados.BandaAgregados1 = 0;
                    MotoresGlobalesSimulados.BandaAgregados2 = 0;
                    MotoresGlobalesSimulados.BandaAgregados3 = 0;
                    MotoresGlobalesSimulados.BandaAgregados4 = 0;

                }

                if (MotoresGlobalesSimulados.BandaAlimentadora == 0)

                {
                    MotoresGlobalesSimulados.Zaranda = 0;
                    MotoresGlobalesSimulados.BandaColectora = 0;
                    MotoresGlobalesSimulados.BandaAgregados1 = 0;
                    MotoresGlobalesSimulados.BandaAgregados2 = 0;
                    MotoresGlobalesSimulados.BandaAgregados3 = 0;
                    MotoresGlobalesSimulados.BandaAgregados4 = 0;

                }

                if (MotoresGlobalesSimulados.Zaranda == 0)

                {
                    MotoresGlobalesSimulados.BandaColectora = 0;
                    MotoresGlobalesSimulados.BandaAgregados1 = 0;
                    MotoresGlobalesSimulados.BandaAgregados2 = 0;
                    MotoresGlobalesSimulados.BandaAgregados3 = 0;
                    MotoresGlobalesSimulados.BandaAgregados4 = 0;

                }


                if (MotoresGlobalesSimulados.BandaColectora == 0)

                {
                    MotoresGlobalesSimulados.BandaAgregados1 = 0;
                    MotoresGlobalesSimulados.BandaAgregados2 = 0;
                    MotoresGlobalesSimulados.BandaAgregados3 = 0;
                    MotoresGlobalesSimulados.BandaAgregados4 = 0;

                }

                if (MotoresGlobalesSimulados.MotorBlowerBH == 0)
                {
                    MotoresGlobalesSimulados.MotorVannerBH = 0;
                    MotoresGlobalesSimulados.SinFinTransversalBH = 0;
                    MotoresGlobalesSimulados.SinFinColector1BH = 0;
                    MotoresGlobalesSimulados.SinFinColector2BH = 0;

                }

                if (MotoresGlobalesSimulados.MotorVannerBH == 0)
                {
                    MotoresGlobalesSimulados.SinFinTransversalBH = 0;
                    MotoresGlobalesSimulados.SinFinColector1BH = 0;
                    MotoresGlobalesSimulados.SinFinColector2BH = 0;
                }

                if (MotoresGlobalesSimulados.SinFinTransversalBH == 0)
                {
                    MotoresGlobalesSimulados.SinFinColector1BH = 0;
                    MotoresGlobalesSimulados.SinFinColector2BH = 0;
                }

            }
            //////////enclavamientos motores reales\\\\\\\\\\\\\\
            else
            {

                if (EntradasGlobales.Elevador == '0')
                {
                    MotoresGlobales.Secador = 0;
                    if (VariablesGlobales.DrumBypass == 0)
                    {
                        MotoresGlobales.BombaAsfaltoAdelante = 0;
                        MotoresGlobales.BombaAsfaltoAtras = 0;
                        MotoresGlobales.BandaAlimentadora = 0;
                        MotoresGlobales.Zaranda = 0;
                        MotoresGlobales.BandaColectora = 0;
                        MotoresGlobales.BandaAgregados1 = 0;
                        MotoresGlobales.BandaAgregados2 = 0;
                        MotoresGlobales.BandaAgregados3 = 0;
                        MotoresGlobales.BandaAgregados4 = 0;
                    }
                }

                if (EntradasGlobales.Secador == '0' && VariablesGlobales.DrumBypass == 0)

                {
                    MotoresGlobales.BombaAsfaltoAdelante = 0;
                    MotoresGlobales.BombaAsfaltoAtras = 0;
                    MotoresGlobales.BandaAlimentadora = 0;
                    MotoresGlobales.Zaranda = 0;
                    MotoresGlobales.BandaColectora = 0;
                    MotoresGlobales.BandaAgregados1 = 0;
                    MotoresGlobales.BandaAgregados2 = 0;
                    MotoresGlobales.BandaAgregados3 = 0;
                    MotoresGlobales.BandaAgregados4 = 0;

                }

                if (EntradasGlobales.SlingerAdelante == '0' && EntradasGlobales.SlingerAtras == '0')

                {
                    MotoresGlobales.BandaAlimentadora = 0;
                    MotoresGlobales.Zaranda = 0;
                    MotoresGlobales.BandaColectora = 0;
                    MotoresGlobales.BandaAgregados1 = 0;
                    MotoresGlobales.BandaAgregados2 = 0;
                    MotoresGlobales.BandaAgregados3 = 0;
                    MotoresGlobales.BandaAgregados4 = 0;

                }

                if (EntradasGlobales.BandaAlimentadora == '0')

                {
                    MotoresGlobales.Zaranda = 0;
                    MotoresGlobales.BandaColectora = 0;
                    MotoresGlobales.BandaAgregados1 = 0;
                    MotoresGlobales.BandaAgregados2 = 0;
                    MotoresGlobales.BandaAgregados3 = 0;
                    MotoresGlobales.BandaAgregados4 = 0;

                }

                if (EntradasGlobales.Zaranda == '0')

                {
                    MotoresGlobales.BandaColectora = 0;
                    MotoresGlobales.BandaAgregados1 = 0;
                    MotoresGlobales.BandaAgregados2 = 0;
                    MotoresGlobales.BandaAgregados3 = 0;
                    MotoresGlobales.BandaAgregados4 = 0;

                }


                if (EntradasGlobales.BandaColectora == '0')

                {
                    MotoresGlobales.BandaAgregados1 = 0;
                    MotoresGlobales.BandaAgregados2 = 0;
                    MotoresGlobales.BandaAgregados3 = 0;
                    MotoresGlobales.BandaAgregados4 = 0;

                }

                if (EntradasGlobales.MotorBlowerBH == '0')
                {
                    MotoresGlobales.MotorVannerBH = 0;
                    MotoresGlobales.SinFinTransversalBH = 0;
                    MotoresGlobales.SinFinColector1BH = 0;
                    MotoresGlobales.SinFinColector2BH = 0;

                }

                if (EntradasGlobales.MotorVannerBH == '0')
                {
                    MotoresGlobales.SinFinTransversalBH = 0;
                    MotoresGlobales.SinFinColector1BH = 0;
                    MotoresGlobales.SinFinColector2BH = 0;
                }

                if (EntradasGlobales.SinFinTransversalBH == '0')
                {
                    MotoresGlobales.SinFinColector1BH = 0;
                    MotoresGlobales.SinFinColector2BH = 0;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ConsolaDiseñoMezclas == false)

            {
                DiseñoMezclas frmDM = new DiseñoMezclas();    //crea objeto Diseño de Mezclas
                frmDM.Show();
                VariablesGlobales.ConsolaDiseñoMezclas = true;
            }
            else
            { VariablesGlobales.ConsolaDiseñoMezclas = true; } //indica que ya hay una consola creada para no crear otra

            VariablesGlobales.DiseñoMezclasOculta = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VariablesGlobales.DiagramaPlantaOculta = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.MasterMezcla <= 90)
                VariablesGlobales.MasterMezcla = VariablesGlobales.MasterMezcla + 10;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.MasterMezcla >= 10)
                VariablesGlobales.MasterMezcla = VariablesGlobales.MasterMezcla - 10;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.MasterMezcla <= 99)
                VariablesGlobales.MasterMezcla = VariablesGlobales.MasterMezcla + 1;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.MasterMezcla >= 1)
                VariablesGlobales.MasterMezcla = VariablesGlobales.MasterMezcla - 1;

        }

        private void Planta_Load(object sender, EventArgs e)
        {

        }


        public void SalidasAnalogas()
        {

        }

        public void desfaseAsfalto()
        {
            VariablesGlobales.datoAsfalto[0] = (VariablesGlobales.MasterMezcla) * (VariablesGlobales.Asfaltoen100kg / 100) * 2.5;
            for (int a = VariablesGlobales.TiempoDesfaseAsfalto; a >= 1; a--)
            {
                VariablesGlobales.datoAsfalto[a] = VariablesGlobales.datoAsfalto[a - 1];
            }
            if (VariablesGlobales.Simulador == true && MotoresGlobalesSimulados.BombaAsfaltoAdelante == 1)
                TPH_BasculaAsfalto.Text = (VariablesGlobales.datoAsfalto[VariablesGlobales.TiempoDesfaseAsfalto]).ToString() + " TPH";
        }

        private void timer1_Visualización_Tick(object sender, EventArgs e)
        {
            VisualizarMotores();  // actualiza interfaz 
            Secuencia_Rotores();  //revisa si debe iniciar secuencia de motores
            Secuencia_CicloSilo(); //revisa si el elevador está prendido para iniciar el ciclo del silo
            EnclavamientoMotores();//revisa si algún motor se apaga y varios depende de el
            VelocidadMotores();// revisa los valores del master y ajusta la velocidad de los motores 

        }

        
    }
}