using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Planta : Form
    {
        public Planta()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //para controlar las excepciones del puerto serial
            timer1_Visualización.Start();
            VariablesGlobales.Observaciones = new string[6];
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
            //serialPort1.Close(); //se deja cerrado un tiempo el puerto 1 para poder actualizar la pagina HTML con el arduino


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

               //visualizar prendido de motores

        private void VisualizarMotores()

        {


            if (VariablesGlobales.DiagramaPlantaOculta == false)
            {
                this.Show();
            }

            Ind_Master.Text = VariablesGlobales.MasterMezcla.ToString();

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
                if (EntradasGlobales.Compresor == '1' && EntradasGlobales.CompuertaGanso == '1' && EntradasGlobales.Extractor1BH == '1' && EntradasGlobales.Extractor2BH == '1' && EntradasGlobales.BombaCombustible == '1' && EntradasGlobales.BlowerQuemador == '1' && VariablesGlobales.ResetPilotoLlamaPrincipal == '0')
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
                    EntradasGlobales.R8090ControlLLama = '0';  //apagarcontrol Honeywell R8'0'9'0';
                    EntradasGlobales.ValvulaAceite = '0';  //válvulas cerradas
                    EntradasGlobales.ValvulaGas = '0';  // válvulas cerradas
                    IndR8090ControlLlama.BackColor = Color.Gray;
                    VariablesGlobales.ContadorParaPiloto = 0;
                    VariablesGlobales.EntradaPilotoR8090 = '0';//** entrada simulada debe provenir del R8090
                    VariablesGlobales.EntradaMainR8090 = '0';//** simulación entrada del Main
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

            IndAsfaltoParcial.Text = Convert.ToString(VariablesGlobales.AsfaltoParcial);
            IndRecicladoParcial.Text = Convert.ToString(VariablesGlobales.RecicladoParcial);
            IndAgregado1Parcial.Text = Convert.ToString(VariablesGlobales.Agregado1Parcial);
            IndAgregado2Parcial.Text = Convert.ToString(VariablesGlobales.Agregado2Parcial);
            IndAgregado3Parcial.Text = Convert.ToString(VariablesGlobales.Agregado3Parcial);
            IndAgregado4Parcial.Text = Convert.ToString(VariablesGlobales.Agregado4Parcial);
            IndMezclaAsfalticaParcial.Text = Convert.ToString(VariablesGlobales.MezclaAsfalticaParcial);



        }


        //  }

        //***********FIN METODO DE VISUALIZACIÓN*****************\\


        //secuencia de los rotores casa de bolsas

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




        //**************COMUNICACION SERIAL********************\\\\\\\\\\\\\\\\
        //**********************************************************************
        private void ComunicacionSerial1()
        {

            VariablesGlobales.Dato_a_enviar = new char[50];
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
            VariablesGlobales.Dato_a_enviar[46] = Convert.ToChar(MotoresGlobales.IncrementarDamperQuemador + 48);
            VariablesGlobales.Dato_a_enviar[47] = Convert.ToChar(MotoresGlobales.DecrementarDamperQuemador + 48);
            VariablesGlobales.Dato_a_enviar[48] = Convert.ToChar(MotoresGlobales.OpenDamperBH + 48);
            VariablesGlobales.Dato_a_enviar[49] = Convert.ToChar(MotoresGlobales.CloseDamperBH + 48);

            VariablesGlobales.DatoTx = new string(VariablesGlobales.Dato_a_enviar);
            try
            {
                //serialPort1.Open();
                serialPort1.Write(VariablesGlobales.DatoTx);
               // IndDatoTx.Text = "DatoTx" + VariablesGlobales.DatoTx;
                //VariablesGlobales.ErrorComunicacion = false;
            }
            catch
            {
                if (VariablesGlobales.ErrorComunicacion == false)
                MessageBox.Show("Error de comunicación en envío, verifique conexiones\n cierre Diagrama de planta, escoja un puerto disponible o\n apague y prenda el puerto para que quede disponible en el menu de comunicaciones");
                VariablesGlobales.ErrorComunicacion = true;
                IndPuertoCOM.Text = "No hay acceso al puerto";
                IndPuertoCOM.BackColor = Color.LightGray;
            }
           // serialPort1.Close();
        }

        private void ComunicacionSerial2()
        {
            

            try
            {
                // serialPort1.Open();
                VariablesGlobales.DatoTx2 = ("b" + Convert.ToString(VariablesGlobales.FreqAgregado1) + "c" + Convert.ToString(VariablesGlobales.FreqAgregado2)) + "x" + Convert.ToString(VariablesGlobales.FreqAgregado3) + "e" + Convert.ToString(VariablesGlobales.FreqAgregado4) + "f" +
               Convert.ToString(VariablesGlobales.FreqReciclado) + "g" + Convert.ToString(VariablesGlobales.FreqAsfalto) + "h"+ Convert.ToString(VariablesGlobales.PosicionDamperExtractorBH)+ "i" + Convert.ToString(VariablesGlobales.PosicionDamperQuemador)+"j";
              //  IndDatoTx.Text = VariablesGlobales.DatoTx2;
                serialPort1.Write(VariablesGlobales.DatoTx2);
            }
            catch
            {
                if (VariablesGlobales.ErrorComunicacion == false)
                    MessageBox.Show("Error de comunicación en envío, verifique conexiones\n cierre Diagrama de planta, escoja un puerto disponible o\n apague y prenda el puerto para que quede disponible en el menu de comunicaciones");
                VariablesGlobales.ErrorComunicacion = true;
                IndPuertoCOM.Text = "No hay acceso al puerto";
                IndPuertoCOM.BackColor = Color.LightGray;
            }
            //serialPort1.Close();
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
            Rutina_PosicionDamperQuemador();//
            Rutina_PosicionDamperBH(); 
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
                VariablesGlobales.PosicionDamperQuemador=VariablesGlobales.PosicionDamperQuemador+1;     //incrementa posición del Damper

        }

        private void IndDecrementarDamper_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperQuemador > 0 && VariablesGlobales.DamperAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperQuemador=VariablesGlobales.PosicionDamperQuemador -1 ;     //decrementa posición del Damper

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
            if (VariablesGlobales.numeroPar)  //para visualizar un dato de transmisión diferente para cada segundo
            {
                IndDatoTx.Text = "DatoTx" + VariablesGlobales.DatoTx;
                VariablesGlobales.numeroPar = false;
            }

            else
            {
                IndDatoTx.Text = "DatoTx2" + VariablesGlobales.DatoTx2;
                VariablesGlobales.numeroPar = true;
            }

        }


        // incremento decremento posición del damper extractor Casa de Bolsas

        private void IndIncrementoDamperAire_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperExtractorBH < 100 && VariablesGlobales.DamperAireAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperExtractorBH = VariablesGlobales.PosicionDamperExtractorBH+1;     //incrementa posición del Damper

        }

        private void IndincrementoDamperAire10_Click_1(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperExtractorBH < 90 && VariablesGlobales.DamperAireAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperExtractorBH = VariablesGlobales.PosicionDamperExtractorBH + 10;     //incrementa posición del Damper
        }

        private void IndDecrementoDamperAire_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.PosicionDamperExtractorBH > 0 && VariablesGlobales.DamperAireAutomaticoManual == 0)//verifica que el damper sea manual
                VariablesGlobales.PosicionDamperExtractorBH = VariablesGlobales.PosicionDamperExtractorBH -1;     //incrementa posición del Damper
        }

        private void IndDecrementoDamperAire10_Click_1(object sender, EventArgs e)
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

                if (EntradasGlobales.Secador == '0' && VariablesGlobales.DrumBypass == '0')

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
                DiseñoMezclas frmDM = new DiseñoMezclas();    //crea objeto Diseño de Mezclas
                frmDM.Show();
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

        private void Planta_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            VariablesGlobales.ConsolaControlMotores = false;
         
        }
         //************************************************************************************\\
        //*********************************RECIBIO DATO POR EL PUETO SERIE**********************\\
       // \\************************************************************************************//

        
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            { VariablesGlobales.DatoRx = serialPort1.ReadLine(); }
            catch
            {
                MessageBox.Show("Error de recepción\nRevise conexiones del puerto serial");
            }
            VariablesGlobales.ErrorComunicacion = false;

            VariablesGlobales.DatoRecibido = new char[45];
            VariablesGlobales.DatoRecibido = VariablesGlobales.DatoRx.ToCharArray();
            IndDatoRx.Text = "DatoRx:" + VariablesGlobales.DatoRx;
            try
            {
                if (VariablesGlobales.DatoRecibido[0] == 'd' && VariablesGlobales.DatoRecibido[1] == 'a' && VariablesGlobales.DatoRecibido[2] == 't' && VariablesGlobales.DatoRecibido[3] == 'o' && VariablesGlobales.DatoRecibido[4] == '2')
                {
                    IndPuertoCOM.BackColor = Color.LightGreen;
                    IndPuertoCOM.Text = VariablesGlobales.PuertoSerieEscogido;
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
                MessageBox.Show("error en la matriz, cierre esta ventana y continue");
            }
            try
            {
                VariablesGlobales.DatoRx = serialPort1.ReadLine();
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

                /*VariablesGlobales.DatoRx = serialPort1.ReadLine();
                VariablesGlobales.DatoPBHRx = serialPort1.ReadLine();  //presión casa de bolsas
                VariablesGlobales.DatoTBHRx = serialPort1.ReadLine();  //presión casa de bolsas
                VariablesGlobales.DatoTMzRx = serialPort1.ReadLine();  //presión casa de bolsas
                VariablesGlobales.DatoTAsRx = serialPort1.ReadLine();  //presión casa de bolsas
                VariablesGlobales.DatoPDQRx = serialPort1.ReadLine();  //presión casa de bolsas
                VariablesGlobales.DatoPDERx = serialPort1.ReadLine();  //presión casa de bolsas
                VariablesGlobales.DatoFlameEye = serialPort1.ReadLine(); // valor de 0-1023 del porcentaje de llama
                VariablesGlobales.DatoIndAgregados = serialPort1.ReadLine();// valor de 0-1023 proveniente dle valor del indicador de agregados
                VariablesGlobales.DatoIndAsfalto = serialPort1.ReadLine(); // valor de 0-123 proveniente del valor del indicador del asfalto
                VariablesGlobales.DatoIndReciclado = serialPort1.ReadLine(); //valor de 0-123 proveniente del valor del indicador del reciclado
                */        
            }
            catch
            {
                MessageBox.Show("Error de recepción\nRevise conexiones del puerto serial");
            }

            VariablesGlobales.DatoRecibido = new char[5];
            VariablesGlobales.DatoRecibido = VariablesGlobales.DatoRx.ToCharArray();

            if (VariablesGlobales.DatoRecibido[0] == 'd' && VariablesGlobales.DatoRecibido[1] == 'a' && VariablesGlobales.DatoRecibido[2] == 't' && VariablesGlobales.DatoRecibido[3] == 'o' && VariablesGlobales.DatoRecibido[4] == '3')
            {
                try
                {
                    IndPresiónCasadeBolsas.Text = VariablesGlobales.DatoPBHRx;
                    VariablesGlobales.PresionCasadeBolsas=(Convert.ToDouble(VariablesGlobales.DatoPBHRx)/100);//en la conversión quita los decimales y hay que volverlos a poner dividiendo por 100
                    IndTemperaturaCasadeBolsas.Text = VariablesGlobales.DatoTBHRx;
                    VariablesGlobales.TemperaturaCasadeBolsas = (Convert.ToDouble(VariablesGlobales.DatoTBHRx) / 100);//en la conversión quita los decimales y hay que volverlos a poner dividiendo por 100
                    IndTemperaturaMezcla.Text = VariablesGlobales.DatoTMzRx;
                    VariablesGlobales.TemperaturaMezcla = (Convert.ToDouble(VariablesGlobales.DatoTMzRx) / 100);//en la conversión quita los decimales y hay que volverlos a poner dividiendo por 100
                    VariablesGlobales.PosicionRealDamperQuemador = (Convert.ToDouble(VariablesGlobales.DatoPDQRx) / 100);//en la conversión quita los decimales y hay que volverlos a poner dividiendo por 100
                    VariablesGlobales.PosicionRealDamperExtractorBH = (Convert.ToDouble(VariablesGlobales.DatoPDERx) / 100);//en la conversión quita los decimales y hay que volverlos a poner dividiendo por 100
                    VariablesGlobales.Valor_mA_Agregados = Convert.ToDouble(VariablesGlobales.DatoIndAgregados) * 0.015625 + 4;
                    VariablesGlobales.Valor_mA_Asfalto = Convert.ToDouble(VariablesGlobales.DatoIndAsfalto) * 0.015625 + 4;
                    VariablesGlobales.Valor_mA_Reciclado = Convert.ToDouble(VariablesGlobales.DatoIndReciclado) * 0.015625 + 4;

                    TPH_BasculaAsfalto.Text = Convert.ToString(VariablesGlobales.ConstanteBasAsfalto * (VariablesGlobales.Valor_mA_Asfalto - 4)); //Muestra los valores de la báscula de asfalto despu´s de su respectiva calibración
                    TPH_BandaPrincipal.Text = Convert.ToString(VariablesGlobales.ConstanteBasAgregados * (VariablesGlobales.Valor_mA_Agregados - 4)); //Muestra los valores de la báscula de asfalto despu´s de su respectiva calibración
                    TPH_BandaReciclado.Text = Convert.ToString(VariablesGlobales.ConstanteBasReciclado * (VariablesGlobales.Valor_mA_Reciclado - 4)); //Muestra los valores de la báscula de asfalto despu´s de su respectiva calibración

                }
                catch
                {
                    MessageBox.Show("error en la conversión de string a Double");
                }

                //IndPresiónCasadeBolsas.Text = Convert.ToString (VariablesGlobales.PresionCasadeBolsas);
               }

            else
            {
                if (VariablesGlobales.DatoRecibido[0] == 'd' && VariablesGlobales.DatoRecibido[1] == 'a' && VariablesGlobales.DatoRecibido[2] == 't' && VariablesGlobales.DatoRecibido[3] == 'o' )
                {/*/solo si dato2 o dato3 empiezan mal entra a colocar error en protocolo*/ }
                else
                {
                    IndPuertoCOM.BackColor = Color.Gray;
                    IndPuertoCOM.Text = "Datos análogos recibidos";
                }
            }

           
           


        }

        public void VelocidadMotores()
        {
            try

            {


                if (MotoresGlobales.BandaAgregados1 == 1)
                    VariablesGlobales.VelocidadAgregado1TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado1en100kg / 100) * 250;//significa que al 100% de master y 100% de material, llegaría a los 250TPH
                else
                    VariablesGlobales.VelocidadAgregado1TPH = 0;

                if (MotoresGlobales.BandaAgregados2 == 1)
                    VariablesGlobales.VelocidadAgregado2TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado2en100kg / 100) * 250;//250 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.VelocidadAgregado2TPH = 0;

                if (MotoresGlobales.BandaAgregados3 == 1)
                    VariablesGlobales.VelocidadAgregado3TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado3en100kg / 100) * 250;//250 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.VelocidadAgregado3TPH = 0;

                if (MotoresGlobales.BandaAgregados4 == 1)
                    VariablesGlobales.VelocidadAgregado4TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Agregado4en100kg / 100) * 250;//250 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.VelocidadAgregado4TPH = 0;

                if (MotoresGlobales.BandaAgregadoReciclado == 1)
                    VariablesGlobales.VelocidadRecicladoTPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Recicladoen100kg / 100) * 250;//250 es las TPH máximas por cada agregados
                else
                    VariablesGlobales.VelocidadRecicladoTPH = 0;

                //if (MotoresGlobales.BombaAsfaltoAdelante == 1)
                //    VariablesGlobales.VelocidadAsfalto_TPH = (VariablesGlobales.MasterMezcla / 100) * (VariablesGlobales.Asfaltoen100kg/100) * 250;//250 es las TPH máximas por cada agregados
                //else
                //    VariablesGlobales.VelocidadAsfaltoTPH = 0;
                // la velocidad de la bomba de asfalto se calculará por el porcentaje leido en el indicador y retrasado por desfase calibrado
                // ver función desfaseAsfalto();


                TPH_Agregado1.Text = VariablesGlobales.VelocidadAgregado1TPH.ToString();
                TPH_Agregado2.Text = VariablesGlobales.VelocidadAgregado2TPH.ToString();
                TPH_Agregado3.Text = VariablesGlobales.VelocidadAgregado3TPH.ToString();
                TPH_Agregado4.Text = VariablesGlobales.VelocidadAgregado4TPH.ToString();
                TPH_Reciclado.Text = VariablesGlobales.VelocidadRecicladoTPH.ToString();
                TPH_Asfalto.Text = VariablesGlobales.VelocidadAsfaltoTPH.ToString();

                if (Convert.ToInt32(VariablesGlobales.VelocidadAgregado1TPH / VariablesGlobales.TPH_HzAgregado1) <= 60 && Convert.ToInt32(VariablesGlobales.VelocidadAgregado1TPH / VariablesGlobales.TPH_HzAgregado1) >= 0)
                {
                    VariablesGlobales.FreqAgregado1 = Convert.ToInt32(VariablesGlobales.VelocidadAgregado1TPH / VariablesGlobales.TPH_HzAgregado1 * 100);  // entrega un valor de 0 a 600 dependiendo de la velocidad en TPH
                    VariablesGlobales.MensajeError1 = false;
                }
                else
                {
                    if (VariablesGlobales.MensajeError1 == false)
                    {
                        VariablesGlobales.ObservacionesTemp = ("Valor para agregado 1 supera la capacidad del motor \n revise diseño de materiales");
                        Observaciones();
                    }
                    VariablesGlobales.MensajeError1 = true;
                }
                if (Convert.ToInt32(VariablesGlobales.VelocidadAgregado2TPH / VariablesGlobales.TPH_HzAgregado2) <= 60 && Convert.ToInt32(VariablesGlobales.VelocidadAgregado2TPH / VariablesGlobales.TPH_HzAgregado2) >= 0)
                {
                    VariablesGlobales.FreqAgregado2 = Convert.ToInt32(VariablesGlobales.VelocidadAgregado2TPH / VariablesGlobales.TPH_HzAgregado2 * 100);
                    VariablesGlobales.MensajeError2 = false;
                }
                else
                {
                    if (VariablesGlobales.MensajeError2 == false)
                    {
                        VariablesGlobales.ObservacionesTemp = ("Valor para agregado 2 supera la capacidad del motor \n revise diseño de materiales");
                        Observaciones();
                    }
                    VariablesGlobales.MensajeError2 = true;
                }


                if (Convert.ToInt32(VariablesGlobales.VelocidadAgregado3TPH / VariablesGlobales.TPH_HzAgregado3) <= 60 && Convert.ToInt32(VariablesGlobales.VelocidadAgregado3TPH / VariablesGlobales.TPH_HzAgregado3) >= 0)
                {
                    VariablesGlobales.FreqAgregado3 = Convert.ToInt32(VariablesGlobales.VelocidadAgregado3TPH / VariablesGlobales.TPH_HzAgregado3 * 100);
                    VariablesGlobales.MensajeError3 = false;
                }
                else
                {
                    if (VariablesGlobales.MensajeError3 == false)
                    {
                        VariablesGlobales.ObservacionesTemp = ("Valor para agregado 3 supera la capacidad del motor \n revise diseño de materiales");
                        Observaciones();
                    }
                    VariablesGlobales.MensajeError3 = true;
                }


                if (Convert.ToInt32(VariablesGlobales.VelocidadAgregado4TPH / VariablesGlobales.TPH_HzAgregado4) <= 60 && Convert.ToInt32(VariablesGlobales.VelocidadAgregado4TPH / VariablesGlobales.TPH_HzAgregado4) >= 0)
                {
                    VariablesGlobales.FreqAgregado4 = Convert.ToInt32(VariablesGlobales.VelocidadAgregado4TPH / VariablesGlobales.TPH_HzAgregado4 * 100);
                    VariablesGlobales.MensajeError4 = false;
                }
                else
                {
                if (VariablesGlobales.MensajeError4 == false)
                {
                    VariablesGlobales.ObservacionesTemp = ("Valor para agregado 4 supera la capacidad del motor \n revise diseño de materiales");
                    Observaciones();
                }
                VariablesGlobales.MensajeError4 = true;
            }

            if (Convert.ToInt32(VariablesGlobales.VelocidadRecicladoTPH / VariablesGlobales.TPH_HzReciclado) <= 60 && Convert.ToInt32(VariablesGlobales.VelocidadRecicladoTPH / VariablesGlobales.TPH_HzReciclado) >= 0)
                {
                    VariablesGlobales.FreqReciclado = Convert.ToInt32(VariablesGlobales.VelocidadRecicladoTPH / VariablesGlobales.TPH_HzReciclado * 100);
                    VariablesGlobales.MensajeError5 = false;
                }
                else
                {
                    if (VariablesGlobales.MensajeError5 == false)
                    {
                        VariablesGlobales.ObservacionesTemp = ("Valor para Reciclado supera la capacidad del motor \n revise diseño de materiales");
                        Observaciones();
                     }
                    VariablesGlobales.MensajeError5 = true;
                }


                if (Convert.ToInt32(VariablesGlobales.VelocidadAsfaltoTPH / VariablesGlobales.TPH_HzAsfalto) <= 60 && Convert.ToInt32(VariablesGlobales.VelocidadAsfaltoTPH / VariablesGlobales.TPH_HzAgregado1) >= 0)
                {
                    VariablesGlobales.FreqAsfalto = Convert.ToInt32(VariablesGlobales.VelocidadAsfaltoTPH / VariablesGlobales.TPH_HzAsfalto * 100);
                    VariablesGlobales.MensajeError6 = false;
                }
                else
                {
                    if (VariablesGlobales.MensajeError6 == false)
                    {
                        VariablesGlobales.ObservacionesTemp = ("Valor para Asfalto supera la capacidad del motor \n revise diseño de materiales");
                        Observaciones();
                    }
                    VariablesGlobales.MensajeError6 = true;
                }
}

         catch
            {
          MessageBox.Show("división por Cero, revise calibración de materiales");
            }
            IndFrecuenciaAgregado1.Text = Convert.ToString(VariablesGlobales.FreqAgregado1/100);
            IndFrecuenciaAgregado2.Text = Convert.ToString(VariablesGlobales.FreqAgregado2/100);
            IndFrecuenciaAgregado3.Text = Convert.ToString(VariablesGlobales.FreqAgregado3/100);
            IndFrecuenciaAgregado4.Text = Convert.ToString(VariablesGlobales.FreqAgregado4/100);
            IndFrecuenciaAgregadoReciclado.Text = Convert.ToString(VariablesGlobales.FreqReciclado/100);
            IndFrecuenciaBombaAsfalto.Text = Convert.ToString(VariablesGlobales.FreqAsfalto/100);
            //banda alimentadora
            

        }


        

        public void SalidasAnalogas()
        {

        }


        public void desfaseAsfalto()            
        {
            VariablesGlobales.datoAsfalto[0] = ((VariablesGlobales.ConstanteBasAgregados * (VariablesGlobales.Valor_mA_Agregados - 4))+ (VariablesGlobales.ConstanteBasReciclado * (VariablesGlobales.Valor_mA_Reciclado - 4))) * (VariablesGlobales.PorcentajeIngresadoAsfalto/100) - ((VariablesGlobales.ConstanteBasReciclado * (VariablesGlobales.Valor_mA_Reciclado - 4) * VariablesGlobales.PorcentajeIngresadoAsfaltoReciclado / 100));
           // este valor va depender no solamente del % ingresado en el diseño sino ademas de las TPH de los agregados y los TPH del reciclado
            
            //VariablesGlobales.datoAsfalto[0] = (VariablesGlobales.MasterMezcla/100) * (VariablesGlobales.Asfaltoen100kg / 100) * 250;
        for (int a = VariablesGlobales.TiempoDesfaseAsfalto; a>=1; a--)
            {
                VariablesGlobales.datoAsfalto[a] = VariablesGlobales.datoAsfalto[a - 1];
            }
            if (MotoresGlobales.BombaAsfaltoAdelante == 1)
                VariablesGlobales.VelocidadAsfaltoTPH = VariablesGlobales.datoAsfalto[VariablesGlobales.TiempoDesfaseAsfalto];
            else
                VariablesGlobales.VelocidadAsfaltoTPH = 0;
        }


        public void Rutina_PosicionDamperQuemador()
        {

            PosRealDamperQuemador.Text = Convert.ToString (VariablesGlobales.PosicionRealDamperQuemador);
            if (VariablesGlobales.PosicionRealDamperQuemador > (VariablesGlobales.PosicionDamperQuemador + 1)) //2% de histéresis
            {
                MotoresGlobales.IncrementarDamperQuemador = 0;
                MotoresGlobales.DecrementarDamperQuemador = 1;
                IncDecDamperQuemador.Text = "↓";
            }
            else
            {
                if (VariablesGlobales.PosicionRealDamperQuemador < (VariablesGlobales.PosicionDamperQuemador - 1)) //2% de histéresis
                {
                    MotoresGlobales.DecrementarDamperQuemador = 0;
                    MotoresGlobales.IncrementarDamperQuemador = 1;
                    IncDecDamperQuemador.Text = "↑";
                }
                else
                {
                    MotoresGlobales.DecrementarDamperQuemador = 0;
                    MotoresGlobales.IncrementarDamperQuemador = 0;
                    IncDecDamperQuemador.Text = " ";
                }
                
            }
            
        }



        public void Rutina_PosicionDamperBH()
        {

            PosRealDamperBH.Text = Convert.ToString(VariablesGlobales.PosicionRealDamperExtractorBH);
            if (VariablesGlobales.PosicionRealDamperExtractorBH > (VariablesGlobales.PosicionDamperExtractorBH + 1)) //2% de histéresis
            {
                MotoresGlobales.OpenDamperBH = 0;
                MotoresGlobales.CloseDamperBH = 1;
                IncDecDamperBH.Text = "↓";
            }
            else
            {
                if (VariablesGlobales.PosicionRealDamperExtractorBH < (VariablesGlobales.PosicionDamperExtractorBH - 1)) //2% de histéresis
                {
                    MotoresGlobales.CloseDamperBH = 0;
                    MotoresGlobales.OpenDamperBH = 1;
                    IncDecDamperBH.Text = "↑";
                }
                else
                {
                    MotoresGlobales.OpenDamperBH = 0;
                    MotoresGlobales.OpenDamperBH = 0;
                    IncDecDamperBH.Text = " ";
                }

            }

        }




        private void timerComSerial_Tick(object sender, EventArgs e)
        {
            ComunicacionSerial1();//envío y recepción de datos; cada 200 ms
            
        }

        private void timer1ComSerial2_Tick(object sender, EventArgs e)
        {
            ComunicacionSerial2();//envío de análogas;
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void Observaciones()
        {
            VariablesGlobales.Observaciones[5]= VariablesGlobales.Observaciones[4];
            VariablesGlobales.Observaciones[4] = VariablesGlobales.Observaciones[3];
            VariablesGlobales.Observaciones[3] = VariablesGlobales.Observaciones[2];
            VariablesGlobales.Observaciones[2] = VariablesGlobales.Observaciones[1];
            VariablesGlobales.Observaciones[1] = VariablesGlobales.Observaciones[0];
            VariablesGlobales.Observaciones[0] = VariablesGlobales.ObservacionesTemp;
            Observaciones6.Text = VariablesGlobales.Observaciones[5];
            Observaciones5.Text = VariablesGlobales.Observaciones[4];
            Observaciones4.Text = VariablesGlobales.Observaciones[3];
            Observaciones3.Text = VariablesGlobales.Observaciones[2];
            Observaciones2.Text = VariablesGlobales.Observaciones[1];
            Observaciones1.Text = VariablesGlobales.Observaciones[0];


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            VariablesGlobales.Observaciones[5] = " ";
            VariablesGlobales.Observaciones[4] = " ";
            VariablesGlobales.Observaciones[3] = " ";
            VariablesGlobales.Observaciones[2] = " ";
            VariablesGlobales.Observaciones[1] = " ";
            VariablesGlobales.Observaciones[0] = " ";
            VariablesGlobales.ObservacionesTemp = " ";
            Observaciones();

        }

        private void timer1_Parciales_Tick(object sender, EventArgs e)
        {
                if (EntradasGlobales.BombaAsfaltoAdelante == '1') // si la bomba esta prendida suma las toneladas por hora en un segundo y lo va acumulando
                    VariablesGlobales.AsfaltoParcial = VariablesGlobales.AsfaltoParcial + (VariablesGlobales.ConstanteBasAsfalto * (VariablesGlobales.Valor_mA_Asfalto - 4) / 3600);
                if (EntradasGlobales.BandaAgregadoReciclado == '1') //si la banda de agregado reciclado está prendida acumulara segundo a segundo el peso registrado
                    VariablesGlobales.RecicladoParcial = VariablesGlobales.RecicladoParcial + (VariablesGlobales.ConstanteBasReciclado * (VariablesGlobales.Valor_mA_Reciclado - 4) / 3600);
                if (EntradasGlobales.BandaAgregados1 == '1' && VariablesGlobales.PorcentajeIngresadoAgregado1!=0 ) // acumula en 1 segundo el promedio ponderado de las cuatro bandas
                    VariablesGlobales.Agregado1Parcial = VariablesGlobales.Agregado1Parcial + ((VariablesGlobales.ConstanteBasAgregados * (VariablesGlobales.Valor_mA_Agregados - 4) / 3600) * (VariablesGlobales.PorcentajeIngresadoAgregado1 / (VariablesGlobales.PorcentajeIngresadoAgregado4 + VariablesGlobales.PorcentajeIngresadoAgregado3 + VariablesGlobales.PorcentajeIngresadoAgregado2 + VariablesGlobales.PorcentajeIngresadoAgregado1)));
                if (EntradasGlobales.BandaAgregados2 == '1' && VariablesGlobales.PorcentajeIngresadoAgregado2 != 0) // acumula en 1 segundo el promedio ponderado de las cuatro bandas
                    VariablesGlobales.Agregado2Parcial = VariablesGlobales.Agregado2Parcial + ((VariablesGlobales.ConstanteBasAgregados * (VariablesGlobales.Valor_mA_Agregados - 4) / 3600) * (VariablesGlobales.PorcentajeIngresadoAgregado2 / (VariablesGlobales.PorcentajeIngresadoAgregado4 + VariablesGlobales.PorcentajeIngresadoAgregado3 + VariablesGlobales.PorcentajeIngresadoAgregado2 + VariablesGlobales.PorcentajeIngresadoAgregado1)));
                if (EntradasGlobales.BandaAgregados3 == '1' && VariablesGlobales.PorcentajeIngresadoAgregado3 != 0) // acumula en 1 segundo el promedio ponderado de las cuatro bandas
                    VariablesGlobales.Agregado3Parcial = VariablesGlobales.Agregado3Parcial + ((VariablesGlobales.ConstanteBasAgregados * (VariablesGlobales.Valor_mA_Agregados - 4) / 3600) * (VariablesGlobales.PorcentajeIngresadoAgregado3 / (VariablesGlobales.PorcentajeIngresadoAgregado4 + VariablesGlobales.PorcentajeIngresadoAgregado3 + VariablesGlobales.PorcentajeIngresadoAgregado2 + VariablesGlobales.PorcentajeIngresadoAgregado1)));
                if (EntradasGlobales.BandaAgregados4 == '1' && VariablesGlobales.PorcentajeIngresadoAgregado4 != 0) // acumula en 1 segundo el promedio ponderado de las cuatro bandas
                    VariablesGlobales.Agregado4Parcial = VariablesGlobales.Agregado4Parcial + ((VariablesGlobales.ConstanteBasAgregados * (VariablesGlobales.Valor_mA_Agregados - 4) / 3600) * (VariablesGlobales.PorcentajeIngresadoAgregado4 / (VariablesGlobales.PorcentajeIngresadoAgregado4 + VariablesGlobales.PorcentajeIngresadoAgregado3 + VariablesGlobales.PorcentajeIngresadoAgregado2 + VariablesGlobales.PorcentajeIngresadoAgregado1)));
              VariablesGlobales.MezclaAsfalticaParcial = VariablesGlobales.MezclaAsfalticaParcial + ((VariablesGlobales.ConstanteBasAsfalto * (VariablesGlobales.Valor_mA_Asfalto - 4) / 3600 )+ ((VariablesGlobales.Valor_mA_Reciclado - 4) / 3600)+(VariablesGlobales.ConstanteBasAgregados*(VariablesGlobales.Valor_mA_Agregados-4)/3600));

        }

        private void ResetAsfaltoParcial_Click(object sender, EventArgs e)
        {
            VariablesGlobales.AsfaltoParcial = 0;
        }

        private void ResetRecicladoParcial_Click(object sender, EventArgs e)
        {
            VariablesGlobales.RecicladoParcial = 0;
        }

        private void ResetAgregado1Parcial_Click(object sender, EventArgs e)
        {
            VariablesGlobales.Agregado1Parcial = 0;
        }

        private void ResetAgregado2Parcial_Click(object sender, EventArgs e)
        {
            VariablesGlobales.Agregado2Parcial = 0;
        }

        private void ResetAgregado3Parcial_Click(object sender, EventArgs e)
        {
            VariablesGlobales.Agregado3Parcial = 0;
        }

        private void ResetAgregado4Prcial_Click(object sender, EventArgs e)
        {
            VariablesGlobales.Agregado4Parcial = 0;
        }

        private void ResetMezclaAsfalticaParcial_Click(object sender, EventArgs e)
        {
            VariablesGlobales.MezclaAsfalticaParcial = 0;
        }
    }
    }

