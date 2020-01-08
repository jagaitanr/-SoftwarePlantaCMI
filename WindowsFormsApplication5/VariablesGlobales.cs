using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class VariablesGlobales
    {
        public static bool PlantaActiva = false;
        public static bool ConsolaControlMotores = false;  //indica si ya hay una consola creada para no crear más
        public static int IndBotonBandaInclinadaOn = 0;
        public static int IndBotonBandaInclinadaOff = 0;
        public static bool ConsolaOculta { get; internal set; } // indica si la consola esta oculta(true) o visible(false)

        public static int IndBotonOnZaranda = 0;
        public static int IndBotonOnBandaColectora = 0;
        public static int IndBotonOnPesoPruebaBandaAlimentadora = 0;
        public static int IndBotonOnBandaAgregados1 = 0;
        public static int IndBotonOnBandaAgregados2 = 0;
        public static int IndBotonOnBandaAgregados3 = 0;
        public static int IndBotonOnBandaAgregados4 = 0;
        public static int IndBotonOnBandaInclinadaReciclado = 0;
        public static int IndBotonOnBandaAgregadoReciclado = 0;
        public static int IndBotonOnMotorTrituradoReciclado = 0;  //scalper
        public static int IndBotonOnPesoPruebaBandaReciclado = 0;
        public static int IndBotonSecadorCompuertaReciclado = 0;
        public static int IndBotonOnMotorBlowerBH = 0;
        public static int IndBotonOnMotorVannerBH = 0;
        public static int IndBotonOnSinFinColector1BH = 0;
        public static int IndBotonOnSinFinColector2BH = 0;
        public static int IndBotonOnSinFinTransversalBH = 0;
        public static int IndBotonOnRotoresBH = 0;
        public static int IndBotonOnCompresor = 0;
        public static int IndBotonOnBombaAsfaltoAdelante = 0;
        public static int IndBotonOnBombaAsfaltoAtras = 0;
        public static int IndBotonOnBombaAsfaltoStop = 0;
        public static int IndBotonOnExtractorBH = 0;
        public static int IndBotonOnBlowerQuemador = 0;
        public static int IndBotonOnElevador = 0;
        public static int IndBotonOnCompuertaRechazo = 0;
        public static int IndBotonOnSecador = 0;
        public static int IndBotonSlingerAdelante = 0;
        public static int IndBotonSlingerStop = 0;
        public static int IndBotonSlingerAtras = 0;
        public static int IndBotonOnBombaCombustible = 0;
        public static int IndBotonOnDamper = 0;
        public static int IndBotonOnPilotLlama = 0;
        public static int IndBotonOnMainLlama = 0;

        public static int IndBotonOffZaranda = 0;
        public static int IndBotonOffBandaColectora = 0;
        public static int IndBotonOffPesoPruebaBandaAlimentadora = 0;
        public static int IndBotonOffBandaAgregados1 = 0;
        public static int IndBotonOffBandaAgregados2 = 0;
        public static int IndBotonOffBandaAgregados3 = 0;
        public static int IndBotonOffBandaAgregados4 = 0;
        public static int IndBotonOffBandaInclinadaReciclado = 0;
        public static int IndBotonOffBandaAgregadoReciclado = 0;
        public static int IndBotonOffMotorTrituradoReciclado = 0;  //scalper
        public static int IndBotonOffPesoPruebaBandaReciclado = 0;
        public static int IndBotonRechazoCompuertaReciclado = 0;
        public static int IndBotonOffMotorBlowerBH = 0;
        public static int IndBotonOffMotorVannerBH = 0;
        public static int IndBotonOffSinFinColector1BH = 0;
        public static int IndBotonOffSinFinColector2BH = 0;
        public static int IndBotonOffSinFinTransversalBH = 0;
        public static int IndBotonOffRotoresBH = 0;
        public static int IndBotonOffCompresor = 0;
        public static int IndBotonOffBombaAsfaltoAdelante = 0;
        public static int IndBotonOffBombaAsfaltoAtras = 0;
        public static int IndBotonOffExtractorBH = 0;
        public static int IndBotonOffBlowerQuemador = 0;
        public static int IndBotonOffElevador = 0;
        public static int IndBotonOffCompuertaRechazo = 0;
        public static int IndBotonOffSecador = 0;
        public static int IndBotonOffBombaCombustible = 0;
        public static int IndBotonOffDamper = 0;
        public static int IndBotonOffPilotLlama = 0;
        public static int IndBotonOffMainLlama = 0;

        public static int IndDrumBypassOn = 0;
        public static int IndDrumBypassOff = 0;
        public static int DrumBypass = 0;
        public static int Secuencia_Rotores = 0;
        public static int IndRotor1BH = 0;
        public static int IndRotor2BH = 0;
        public static int IndRotor3BH = 0;
        public static int SensorPosRotor1BH = 0;
        public static int SensorPosRotor2BH = 0;
        public static int SensorPosRotor3BH = 0;
        public static int SecuenciaRotor1 = 0;
        public static int SecuenciaRotor2 = 0;
        public static int SecuenciaRotor3 = 0;
        public static int TiempoSalirSensorRotores = 0;
        public static int Secuencia_RotoresActiva = 0;
        public static int DamperAutomaticoManual = 0;
        public static int DamperAireAutomaticoManual = 0;
       // public static int DamperPosicion = 0;
       // public static int DamperAirePosicion = 0;
        public static int TiempoCicloSilo = 0; //tiempo de 0-23seg para el ciclo de alimentación de la compuerta del silo
        public static int CicloSiloIniciado = 0; //indica si se ha iniciado el ciclo del silo para empezar a correr tiempo ciclo silo
        public static int IndBotonSiloOpenCiclo = 0; //variable que el boton Ciclo u Open cambián para prender la valvula de alimentación de silo o  activar Ciclo

        public static int CombustibleAceiteGas = 1;
        public static int EntradaTemperaturaGanso = 0;  //Valor de la termocupla del Ganso
        public static int SetPointTemperaturaGanso = 0; // valor de apagado de compuerta detectado por la termocupla del ganso
        public static int EntradaPilotoR8090 = 0; // entrada proveniente del control Honeywell
        public static int ContadorParaPiloto = 0; //inicia cuenta para habilitar piloto en modo simulación
        public static int PilotoBoton = 0; //señal que indica que el boton ha sido presionado
        public static int EntradaMainR8090 = 0; //entrada proveniente del Control Honeywell 
        public static int LlamaPrincipalBoton = 0; // variable habilitada por boton llama principal
        public static int ResetPilotoLlamaPrincipal = 0;
        public static int mediosegundo = 0; //para que funcione el reset piloto llama

        ///////////************Variables para las mezclas*************\\\\\\\\\\\\\

        public static double PorcentajeIngresadoAgregado1 = 0;
        public static double PorcentajeIngresadoAgregado2 = 0;
        public static double PorcentajeIngresadoAgregado3 = 0;
        public static double PorcentajeIngresadoAgregado4 = 0;
        public static double PorcentajeIngresadoReciclado = 0;
        public static double PorcentajeIngresadoAsfalto = 0;
        public static double PorcentajeIngresadoHumedadAgregado1 = 0;
        public static double PorcentajeIngresadoHumedadAgregado2 = 0;
        public static double PorcentajeIngresadoHumedadAgregado3 = 0;
        public static double PorcentajeIngresadoHumedadAgregado4 = 0;
        public static double PorcentajeIngresadoHumedadReciclado = 0;
        public static double PorcentajeIngresadoAsfaltoReciclado = 0;
        public static double TiempoInicioAgregado1 = 0;
        public static double TiempoInicioAgregado2 = 0;
        public static double TiempoInicioAgregado3 = 0;
        public static double TiempoInicioAgregado4 = 0;
        public static double TiempoInicioReciclado = 0;
        public static double TiempoInicioAsfalto = 0;
        public static double TiempoPararAgregado1 = 0;
        public static double TiempoPararAgregado2 = 0;
        public static double TiempoPararAgregado3 = 0;
        public static double TiempoPararAgregado4 = 0;
        public static double TiempoPararReciclado = 0;
        public static double TiempoPararAsfalto = 0;

        public static double Agregado1en100kg = 0;
        public static double Agregado2en100kg = 0;
        public static double Agregado3en100kg = 0;
        public static double Agregado4en100kg = 0;
        public static double Recicladoen100kg = 0;
        public static double Asfaltoen100kg = 0;

        public static double TPH_HzAgregado1 = 1;  //constante adquirida en la calibración para ver a cuantas TPH equivale 1Hz
        public static double TPH_HzAgregado2 = 1;  //constante adquirida en la calibración para ver a cuantas TPH equivale 1Hz
        public static double TPH_HzAgregado3 = 1;  //constante adquirida en la calibración para ver a cuantas TPH equivale 1Hz
        public static double TPH_HzAgregado4 = 1;  //constante adquirida en la calibración para ver a cuantas TPH equivale 1Hz
        public static double TPH_HzReciclado = 1;  //constante adquirida en la calibración para ver a cuantas TPH equivale 1Hz
        public static double TPH_HzAsfalto = 1;   //constante adquirida en la calibración para ver a cuantas TPH equivale 1Hz
                                         // estas variables se inicializan en 1 para evitar el erro de división por cero


        public static double TPH_Maximo = 0;  // velocidad máxima para producción
        public static double MasterMezcla = 0; //indica el porcentaje general de la producción

        public static double IndicadorBasculaAgregados = 0;
        public static double IndicadorBasculaReciclado = 0;
        public static double IndicadorBasculaAsfalto = 0;
        public static bool Simulador = false; //modo simulador 1/ modo real 0
        public static bool numeroPar = true; // para visualizar los dos datos de envío, cada segundo uno diferente

        public static bool DiseñoMezclasOculta = false; // Para ver o ocultar la ventana de Diseño de Mezclas
        public static bool ConsolaDiseñoMezclas = false; // Variable para indicar que hay creada una windows Form y no es necesario crear una nueva

        public static bool DiagramaPlantaOculta = false; // Para ver o ocultar la ventana de Planta de Asfalto
        public static bool ConsolaDiagramaPlanta = false; // Variable para indicar que hay creada una windows Form y no es necesario crear una nueva

        public static double VelocidadAgregado1TPH = 0; // velocidad que será enviada al microcontrolador * el factor de TPH-Hz
        public static double VelocidadAgregado2TPH = 0; // velocidad que será enviada al microcontrolador * el factor de TPH-Hz
        public static double VelocidadAgregado3TPH = 0; // velocidad que será enviada al microcontrolador * el factor de TPH-Hz
        public static double VelocidadAgregado4TPH = 0; // velocidad que será enviada al microcontrolador * el factor de TPH-Hz
        public static double VelocidadRecicladoTPH = 0; // velocidad que debe tener la banda de reciclado * el factor de TPH-Hz
        public static double VelocidadAsfaltoTPH = 0; // velocidad de la bomba de asfalto al microcontrolador *  el factor de TPH-Hz despues del tiempo de desfase
        public static double VelocidadAsfaltoTempTPH = 0;// velocidad de la bomba de asfalto al microcontrolador* el factor de TPH-Hz
        public static double TPH_BandaPrincipalSimulada = 0; //suma y muestra en modo simulado el aporte de cada banda
        public static double TPH_BandaRecicladoSimulada = 0; 
        public static double TPH_BasculaAsfaltoSimulada = 0; 

        public static string PuertoSerieEscogido = "COM1";
        public static char []DatoRecibido;
        public static char[] Dato_a_enviar;
        public static string DatoRx;
        public static string DatoTx;   // dato para actualizar prendido y apagado de motores
        public static string DatoTx2;  //dato de envío de las frecuencias
        public static bool ErrorComunicacion = false;// se genera cuando hay un error durante la comunicación
        public static int TiempoDesfaseAsfalto = 0;
        public static double [] datoAsfalto = new double[100];
        public static string DatoPBHRx;  //Dato recibido presión casa de bolsas
        public static string DatoTBHRx;  //Dato recibido temperatura casa de bolsas
        public static string DatoTMzRx;  //Dato recibido temperatura Mezcla
        public static string DatoTExausthRx; //temperatura exausth
        public static string DatoTasfRx;  // temperatura asfalto
        public static string DatoTAsRx;  //Dato recibido temperatura Asfalto
        public static string DatoPDQRx;  //Dato recibido posición Damper Quemador
        public static string DatoPDERx;  //presión casa de posición Damper Extractor Casa de Bolsas
        

        //***datos análogos***\\
        public static double PresionCasadeBolsas = 0;
        public static double TemperaturaCasadeBolsas = 0;
        public static double TemperaturaMezcla = 0;
        public static double PosicionDamperQuemador = 0;     //posición que ingresa el operador y quiere obtener
        public static double PosicionRealDamperQuemador = 0; //posición que entrega el reostato y lee el microcontrolador
        public static double PosicionDamperExtractorBH = 0;   //posición que ingresa el operadora
        public static double PosicionRealDamperExtractorBH = 0;  // posición que entrega el reostato del damper y lee el microcont.
        public static string DatoFlameEye;
        public static string DatoIndAgregados; // valor de 0-1023 proveniente del valor del indicador de agregados formato string
        public static string DatoIndAsfalto; // valor de 0-123 proveniente del valor del indicador del asfalto formato string
        public static string DatoIndReciclado; //valor de 0-123 proveniente del valor del indicador del reciclado formato string
        public static int FlameEye; // valor de 0-1023 proveniete del valor del indicador de agregados 
        public static int IndAgregados;// valor de 0-1023 proveniente dle valor del indicador de agregados
        public static int IndAsfalto;// valor de 0-1023 proveniente dle valor del indicador de asfalto
        public static int IndReciclado;    // valor de 0-1023 proveniente dle valor del indicador de reciclado

        public static double Valor_mA_Agregados; // valor en mA leido del indicador de la báscula
        public static double ValorCeroBasAgregados; //valor capturado cuando se oprime el cero de la calibración de la báscula
        public static double ValorSpamBasAgregados; //valor capturado cuando se oprime el cero de la calibración de la báscula
        public static double ValorIngresadoSpamAgregados; // valor ingresado del spam
        public static double ConstanteBasAgregados; // valor de la constante para determinar las TPH

        public static double Valor_mA_Reciclado; // valor en mA leido del indicador de la báscula
        public static double ValorCeroBasReciclado; //valor capturado cuando se oprime el cero de la calibración de la báscula
        public static double ValorSpamBasReciclado; //valor capturado cuando se oprime el cero de la calibración de la báscula
        public static double ValorIngresadoSpamReciclado; // valor ingresado del spam
        public static double ConstanteBasReciclado; // valor de la constante para determinar las TPH

        public static double Valor_mA_Asfalto; // valor en mA leido del indicador de la báscula
        public static double ValorCeroBasAsfalto; //valor capturado cuando se oprime el cero de la calibración de la báscula
        public static double ValorSpamBasAsfalto; //valor capturado cuando se oprime el cero de la calibración de la báscula
        public static double ValorIngresadoSpamAsfalto; // valor ingresado del spam
        public static double ConstanteBasAsfalto; // valor de la constante para determinar las TPH

        public static int FreqAgregado1; // valor de la frecuencia enviada hacia el micro maestro de 0-600 para el variador del agregado1 (0-60Hz)
        public static int FreqAgregado2; // valor de la frecuencia enviada hacia el micro maestro de 0-600 para el variador del agregado1 (0-60Hz)
        public static int FreqAgregado3; // valor de la frecuencia enviada hacia el micro maestro de 0-600 para el variador del agregado1 (0-60Hz)
        public static int FreqAgregado4; // valor de la frecuencia enviada hacia el micro maestro de 0-600 para el variador del agregado1 (0-60Hz)
        public static int FreqReciclado; // valor de la frecuencia enviada hacia el micro maestro de 0-600 para el variador del agregado1 (0-60Hz)
        public static int FreqAsfalto; // valor de la frecuencia enviada hacia el micro maestro de 0-600 para el variador del agregado1 (0-60Hz)
        public static Boolean MensajeError1; // se pone verdadero cuando hay un mensaje de error activado, y falso cuando se desactiva
        public static Boolean MensajeError2; // se pone verdadero cuando hay un mensaje de error activado, y falso cuando se desactiva
        public static Boolean MensajeError3; // se pone verdadero cuando hay un mensaje de error activado, y falso cuando se desactiva
        public static Boolean MensajeError4; // se pone verdadero cuando hay un mensaje de error activado, y falso cuando se desactiva
        public static Boolean MensajeError5; // se pone verdadero cuando hay un mensaje de error activado, y falso cuando se desactiva
        public static Boolean MensajeError6; // se pone verdadero cuando hay un mensaje de error activado, y falso cuando se desactiva
        public static string [] Observaciones ;  // arreglo tipo String para guardar las observaciones que vayan saliendo 
        public static string ObservacionesTemp;

        public static double AsfaltoParcial = 0;
        public static double RecicladoParcial = 0;
        public static double Agregado1Parcial = 0;
        public static double Agregado2Parcial = 0;
        public static double Agregado3Parcial = 0;
        public static double Agregado4Parcial = 0;
        public static double MezclaAsfalticaParcial = 0;

        public static string TextoParaConfirmación;
        public static bool Confirmado = false;
        public static bool RecibiendoDatos = true; // variable para que no permita cerrar puerto serie si esta recibiendo datos

    }
}
