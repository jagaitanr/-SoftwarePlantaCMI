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

    
    public partial class ControlMotores : Form
    
    {
        

        public ControlMotores()
        {
            InitializeComponent();
        }


        private void DrumBypassOnBoton_Click(object sender, EventArgs e)
        {

           // DrumBypassOnBoton.BackColor = Color.Green;
            //DrumBypassOffBoton.BackColor = Color.Gray;
            VariablesGlobales.DrumBypass = 1;
            VariablesGlobales.IndDrumBypassOn = 1;
            VariablesGlobales.IndDrumBypassOff = 0;

        }

        private void DrumBypassOffBoton_Click(object sender, EventArgs e)
        {
            //DrumBypassOnBoton.BackColor = Color.Gray;
            //DrumBypassOffBoton.BackColor = Color.Red;
            VariablesGlobales.DrumBypass = 0;
            VariablesGlobales.IndDrumBypassOn = 0;
            VariablesGlobales.IndDrumBypassOff = 1;
        }
        
        private void BandaInclinadaOnBoton_Click(object sender, EventArgs e)
        {
            if (MotoresGlobalesSimulados.SlingerAdelante==1 ||MotoresGlobalesSimulados.SlingerAtras=='1' ||  EntradasGlobales.SlingerAtras == '1' || EntradasGlobales.SlingerAdelante=='1')
            {
                if (VariablesGlobales.Simulador == true)
                { MotoresGlobalesSimulados.BandaAlimentadora = 1; }
                else
                { MotoresGlobales.BandaAlimentadora = 1; }
            }
            else
                MessageBox.Show("Prenda Slinger");
        }

        private void BandaInclinadaOffBoton_Click(object sender, EventArgs e)
        {

            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaAlimentadora = 0; }
            else
            { MotoresGlobales.BandaAlimentadora = 0; }
           }

        
        private void ZarandaOnBoton_Click_1(object sender, EventArgs e)
        {
            
                if (VariablesGlobales.Simulador == true && MotoresGlobalesSimulados.BandaAlimentadora == 1)
                { MotoresGlobalesSimulados.Zaranda = 1; }
                else
                {
                    if (VariablesGlobales.Simulador == true)
                    MessageBox.Show("Prenda Banda Inclinada");
                }

                if (VariablesGlobales.Simulador == false && EntradasGlobales.BandaAlimentadora == '1')
                { MotoresGlobales.Zaranda = 1; }
                else
                {
                    if (VariablesGlobales.Simulador == false)
                    MessageBox.Show("Prenda Banda Inclinada");
                }
            
        }

        private void ZarandaOffBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.Zaranda = 0; }
            else
            { MotoresGlobales.Zaranda = 0; }
        }

       
        private void BandaColectoraOnBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true && MotoresGlobalesSimulados.Zaranda == 1)
            { MotoresGlobalesSimulados.BandaColectora = 1; }
            else
            {
                if (VariablesGlobales.Simulador == true)
                    MessageBox.Show("Prenda la Zaranda");
            }

            if (VariablesGlobales.Simulador == false && EntradasGlobales.Zaranda == '1')
            { MotoresGlobales.BandaColectora = 1; }
            else
            {
                if (VariablesGlobales.Simulador == false)
                    MessageBox.Show("Prenda La Zaranda");
            }

        }

        private void BandaColectoraOffBoton_Click(object sender, EventArgs e)
        {
                if (VariablesGlobales.Simulador == true)
                { MotoresGlobalesSimulados.BandaColectora = 0; }
                else
                { MotoresGlobales.BandaColectora = 0; }
        }

        private void BotonAgregados1OnBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true && MotoresGlobalesSimulados.BandaColectora == 1)
            { MotoresGlobalesSimulados.BandaAgregados1 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == true)
                    MessageBox.Show("Prenda Banda Colectora");
            }

            if (VariablesGlobales.Simulador == false && EntradasGlobales.BandaColectora == '1')
            { MotoresGlobales.BandaAgregados1 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == false)
                    MessageBox.Show("Prenda Banda Colectora");
            }
        }

        private void BotonAgregados1OffBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaAgregados1 = 0; }
            else
            { MotoresGlobales.BandaAgregados1 = 0; }
        }

        private void BandaAgregados2OnBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true && MotoresGlobalesSimulados.BandaColectora == 1)
            { MotoresGlobalesSimulados.BandaAgregados2 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == true)
                    MessageBox.Show("Prenda Banda Colectora");
            }

            if (VariablesGlobales.Simulador == false && EntradasGlobales.BandaColectora == '1')
            { MotoresGlobales.BandaAgregados2 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == false)
                    MessageBox.Show("Prenda Banda Colectora");
            }
        }

        private void BandaAgregados2OffBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaAgregados2 = 0; }
            else
            { MotoresGlobales.BandaAgregados2 = 0; }
        }

        private void BandaAgregados3OnBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true && MotoresGlobalesSimulados.BandaColectora == 1)
            { MotoresGlobalesSimulados.BandaAgregados3 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == true)
                    MessageBox.Show("Prenda Banda Colectora");
            }

            if (VariablesGlobales.Simulador == false && EntradasGlobales.BandaColectora == '1')
            { MotoresGlobales.BandaAgregados3 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == false)
                    MessageBox.Show("Prenda Banda Colectora");
            }
        }

        private void BandaAgregados3OffBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaAgregados3 = 0; }
            else
            { MotoresGlobales.BandaAgregados3 = 0; }
        }

        private void BandaAgregados4OnBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true && MotoresGlobalesSimulados.BandaColectora == 1)
            { MotoresGlobalesSimulados.BandaAgregados4 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == true)
                    MessageBox.Show("Prenda Banda Colectora");
            }

            if (VariablesGlobales.Simulador == false && EntradasGlobales.BandaColectora == '1')
            { MotoresGlobales.BandaAgregados4 = 1; }
            else
            {
                if (VariablesGlobales.Simulador == false)
                    MessageBox.Show("Prenda Banda Colectora");
            }
        }

        private void BandaAgregados4OffBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaAgregados4 = 0; }
            else
            { MotoresGlobales.BandaAgregados4 = 0; }
        }

        private void CompuertaRecicladoBotonSecador_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.CompuertaReciclado = 1; }
            else
            { MotoresGlobales.CompuertaReciclado = 1; }
       
        }

        private void CompuertaRecicladoBotonRechazo_Click(object sender, EventArgs e)
        {
            CompuertaRecicladoBotonSecador.BackColor = Color.Gray;
            CompuertaRecicladoBotonRechazo.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.CompuertaReciclado = 0; }
            else
            { MotoresGlobales.CompuertaReciclado = 0; }
//            VariablesGlobales.IndBotonSecadorCompuertaReciclado = 0;
//            VariablesGlobales.IndBotonRechazoCompuertaReciclado = 1;

        }


        private void BandaRecicladoOnBoton_Click(object sender, EventArgs e)
        {
            BandaRecicladoOnBoton.BackColor = Color.Green;
            BandaRecicladoOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaInclinadaReciclado = 1; }
            else
            { MotoresGlobales.BandaInclinadaReciclado = 1; }
//            VariablesGlobales.IndBotonOnBandaInclinadaReciclado = 1;
//            VariablesGlobales.IndBotonOffBandaInclinadaReciclado = 0;

        }

        private void BandaRecicladoOffBoton_Click(object sender, EventArgs e)
        {
            BandaRecicladoOnBoton.BackColor = Color.Gray;
            BandaRecicladoOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaInclinadaReciclado = 0; }
            else
            { MotoresGlobales.BandaInclinadaReciclado = 0; }
 //           VariablesGlobales.IndBotonOnBandaInclinadaReciclado = 0;
 //           VariablesGlobales.IndBotonOffBandaInclinadaReciclado = 1;

        }

        private void MotortrituradoOnBoton_Click(object sender, EventArgs e)
        {
            MotorTrituradoOnBoton.BackColor = Color.Green;
            MotorTrituradoOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.MotorTrituradoReciclado = 1; }
            else
            { MotoresGlobales.MotorTrituradoReciclado = 1; }
   //         VariablesGlobales.IndBotonOnMotorTrituradoReciclado = 1;
   //         VariablesGlobales.IndBotonOffMotorTrituradoReciclado = 0;

        }

        private void MotortrituradoOffBoton_Click(object sender, EventArgs e)
        {
            MotorTrituradoOnBoton.BackColor = Color.Gray;
            MotorTrituradoOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.MotorTrituradoReciclado = 0; }
            else
            { MotoresGlobales.MotorTrituradoReciclado = 0; }
 //           VariablesGlobales.IndBotonOnMotorTrituradoReciclado = 0;
 //           VariablesGlobales.IndBotonOffMotorTrituradoReciclado = 1;
        }

        
        private void BlowerBHOnBoton_Click(object sender, EventArgs e)
        {
            BlowerBHOnBoton.BackColor = Color.Green;
            BlowerBHOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.MotorBlowerBH = 1; }
            else
            { MotoresGlobales.MotorBlowerBH = 1; }
 //           VariablesGlobales.IndBotonOnMotorBlowerBH = 1;
 //           VariablesGlobales.IndBotonOffMotorBlowerBH = 0;

        }

        private void BlowerBHOffBoton_Click(object sender, EventArgs e)
        {
            BlowerBHOnBoton.BackColor = Color.Gray;
            BlowerBHOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.MotorBlowerBH = 0; }
            else
            { MotoresGlobales.MotorBlowerBH = 0; }
   //         VariablesGlobales.IndBotonOnMotorBlowerBH = 0;
   //         VariablesGlobales.IndBotonOffMotorBlowerBH = 1;

        }

        private void VannerBHOnBoton_Click(object sender, EventArgs e)
        {
            VannerBHOnBoton.BackColor = Color.Green;
            VannerBHOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.MotorVannerBH = 1; }
            else
            { MotoresGlobales.MotorVannerBH = 1; }
  //          VariablesGlobales.IndBotonOnMotorVannerBH = 1;
  //          VariablesGlobales.IndBotonOffMotorVannerBH = 0;

        }

        private void VannerBHOffBoton_Click(object sender, EventArgs e)
        {
            VannerBHOnBoton.BackColor = Color.Gray;
            VannerBHOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.MotorVannerBH = 0; }
            else
            { MotoresGlobales.MotorVannerBH = 0; }
   //         VariablesGlobales.IndBotonOnMotorVannerBH = 0;
   //         VariablesGlobales.IndBotonOffMotorVannerBH = 1;

        }

        private void Colector1BHOnBoton_Click(object sender, EventArgs e)
        {
            Colector1BHOnBoton.BackColor = Color.Green;
            Colector1BHOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.SinFinColector1BH = 1; }
            else
            { MotoresGlobales.SinFinColector1BH = 1; }
     //       VariablesGlobales.IndBotonOnSinFinColector1BH = 1;
     //       VariablesGlobales.IndBotonOffSinFinColector1BH = 0;

        }

        private void Colector1BHOffBoton_Click(object sender, EventArgs e)
        {
            Colector1BHOnBoton.BackColor = Color.Gray;
            Colector1BHOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.SinFinColector1BH = 0; }
            else
            { MotoresGlobales.SinFinColector1BH = 0; }
     //       VariablesGlobales.IndBotonOnSinFinColector1BH = 0;
     //       VariablesGlobales.IndBotonOffSinFinColector1BH = 1;

        }

        private void Colector2BHOnBoton_Click(object sender, EventArgs e)
        {
            Colector2BHOnBoton.BackColor = Color.Green;
            Colector2BHOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.SinFinColector2BH = 1; }
            else
            { MotoresGlobales.SinFinColector2BH = 1; }
  //          VariablesGlobales.IndBotonOnSinFinColector2BH = 1;
  //          VariablesGlobales.IndBotonOffSinFinColector2BH = 0;

        }

        private void Colector2BHOffBoton_Click(object sender, EventArgs e)
        {
            Colector2BHOnBoton.BackColor = Color.Gray;
            Colector2BHOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.SinFinColector2BH = 0; }
            else
            { MotoresGlobales.SinFinColector2BH = 0; }
   //         VariablesGlobales.IndBotonOnSinFinColector2BH = 0;
   //         VariablesGlobales.IndBotonOffSinFinColector2BH = 1;

        }

        private void TransversalBHOnBoton_Click(object sender, EventArgs e)
        {
            TransversalBHOnBoton.BackColor = Color.Green;
            TransversalBHOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.SinFinTransversalBH = 1; }
            else
            { MotoresGlobales.SinFinTransversalBH = 1; }
  //          VariablesGlobales.IndBotonOnSinFinTransversalBH = 1;
  //          VariablesGlobales.IndBotonOffSinFinTransversalBH = 0;

        }

        private void TransversalBHOffBoton_Click(object sender, EventArgs e)
        {
            TransversalBHOnBoton.BackColor = Color.Gray;
            TransversalBHOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.SinFinTransversalBH = 0; }
            else
            { MotoresGlobales.SinFinTransversalBH = 0; }
   //         VariablesGlobales.IndBotonOnSinFinTransversalBH = 0;
//            VariablesGlobales.IndBotonOffSinFinTransversalBH = 1;

        }

        private void RotoresBHOnBoton_Click(object sender, EventArgs e)
        {
            RotoresBHOnBoton.BackColor = Color.Green;
            RotoresBHOffBoton.BackColor = Color.Gray;
            VariablesGlobales.Secuencia_Rotores = 1;
           // VariablesGlobales.IndBotonOnRotoresBH = 1;
            //VariablesGlobales.IndBotonOffRotoresBH = 0;

        }

        private void RotoresBHOffBoton_Click(object sender, EventArgs e)
        {
            RotoresBHOnBoton.BackColor = Color.Gray;
            RotoresBHOffBoton.BackColor = Color.Red;
            VariablesGlobales.Secuencia_Rotores = 0;
  //          VariablesGlobales.IndBotonOnRotoresBH = 0;
  //          VariablesGlobales.IndBotonOffRotoresBH = 1;

        }

        private void CompresorOnBoton_Click(object sender, EventArgs e)
        {
            CompresorOnBoton.BackColor = Color.Green;
            CompresorOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.Compresor = 1; }
            else
            { MotoresGlobales.Compresor = 1; }
   //         VariablesGlobales.IndBotonOnCompresor = 1;
   //         VariablesGlobales.IndBotonOffCompresor = 0;

        }

        private void CompresorOffBoton_Click(object sender, EventArgs e)
        {
            CompresorOnBoton.BackColor = Color.Gray;
            CompresorOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.Compresor = 0; }
            else
            { MotoresGlobales.Compresor = 0; }
//            VariablesGlobales.IndBotonOnCompresor = 0;
//            VariablesGlobales.IndBotonOffCompresor = 1;

        }

        private void BombaAsfaltoAdelanteBoton_Click(object sender, EventArgs e)
        {
            BombaAsfaltoAdelanteBoton.BackColor = Color.Green;
            BombaAsfaltoStopBoton.BackColor = Color.Gray;
            BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            {
                MotoresGlobalesSimulados.BombaAsfaltoAtras = 0;
                MotoresGlobalesSimulados.BombaAsfaltoAdelante = 1;
             }
            else
            {
                MotoresGlobales.BombaAsfaltoAtras = 0;
                MotoresGlobales.BombaAsfaltoAdelante = 1;
            }
 //           VariablesGlobales.IndBotonOnBombaAsfaltoAdelante = 1;
 //           VariablesGlobales.IndBotonOnBombaAsfaltoStop = 0;
 //           VariablesGlobales.IndBotonOnBombaAsfaltoAtras = 0;
        }

        private void BombaAsfaltoStopBoton_Click(object sender, EventArgs e)
        {
            BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
            BombaAsfaltoStopBoton.BackColor = Color.Red;
            BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            {
                MotoresGlobalesSimulados.BombaAsfaltoAtras = 0;
                MotoresGlobalesSimulados.BombaAsfaltoAdelante = 0;
            }
            else
            {
                MotoresGlobales.BombaAsfaltoAtras = 0;
                MotoresGlobales.BombaAsfaltoAdelante = 0;
            }
 //           VariablesGlobales.IndBotonOnBombaAsfaltoAdelante = 0;
 //           VariablesGlobales.IndBotonOnBombaAsfaltoStop = 1;
 //           VariablesGlobales.IndBotonOnBombaAsfaltoAtras = 0;

        }

        private void BombaAsfaltoAtrasBoton_Click(object sender, EventArgs e)
        {
            BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
            BombaAsfaltoStopBoton.BackColor = Color.Gray;
            BombaAsfaltoAtrasBoton.BackColor = Color.Green;
            if (VariablesGlobales.Simulador == true)
            {
                MotoresGlobalesSimulados.BombaAsfaltoAdelante = 0;
                MotoresGlobalesSimulados.BombaAsfaltoAtras = 1;
            }
            else
            {
                MotoresGlobales.BombaAsfaltoAdelante = 0;
                MotoresGlobales.BombaAsfaltoAtras = 1;
            }
   //         VariablesGlobales.IndBotonOnBombaAsfaltoAdelante = 0;
   //         VariablesGlobales.IndBotonOnBombaAsfaltoStop = 0;
   //         VariablesGlobales.IndBotonOnBombaAsfaltoAtras = 1;

        }

        private void ExtractorBHOnBoton_Click(object sender, EventArgs e)
        {
            ExtractorBHOnBoton.BackColor = Color.Green;
            ExtractorBHOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            {
                MotoresGlobalesSimulados.Extractor1BH = 1;
                MotoresGlobalesSimulados.Extractor2BH = 1;
            }
            else
            {
                MotoresGlobales.Extractor1BH = 1;
                MotoresGlobales.Extractor2BH = 1;
            }
   //         VariablesGlobales.IndBotonOnExtractorBH = 1;
   //         VariablesGlobales.IndBotonOffExtractorBH = 0;

        }

        private void ExtractorBHOffBoton_Click(object sender, EventArgs e)
        {
            ExtractorBHOnBoton.BackColor = Color.Gray;
            ExtractorBHOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            {
                MotoresGlobalesSimulados.Extractor1BH = 0;
                MotoresGlobalesSimulados.Extractor2BH = 0;
            }
            else
            {
                MotoresGlobales.Extractor1BH = 0;
                MotoresGlobales.Extractor2BH = 0;
            }
   //         VariablesGlobales.IndBotonOnExtractorBH = 0;
   //         VariablesGlobales.IndBotonOffExtractorBH = 1;

        }

        private void BlowerQuemadorOnBoton_Click(object sender, EventArgs e)
        {
            BlowerQuemadorOnBoton.BackColor = Color.Green;
            BlowerQuemadorOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BlowerQuemador = 1; }
            else
            { MotoresGlobales.BlowerQuemador = 1; }
  //          VariablesGlobales.IndBotonOnBlowerQuemador = 1;
  //          VariablesGlobales.IndBotonOffBlowerQuemador = 0;

        }

        private void BlowerQuemadorOffBoton_Click(object sender, EventArgs e)
        {
            BlowerQuemadorOnBoton.BackColor = Color.Gray;
            BlowerQuemadorOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BlowerQuemador = 0; }
            else
            { MotoresGlobales.BlowerQuemador = 0; }
 //           VariablesGlobales.IndBotonOnBlowerQuemador = 0;
 //           VariablesGlobales.IndBotonOffBlowerQuemador = 1;

        }

        private void ElevadorOnBoton_Click(object sender, EventArgs e)
        {
            ElevadorOnBoton.BackColor = Color.Green;
            ElevadorOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.Elevador = 1; }
            else
            { MotoresGlobales.Elevador = 1; }
  //          VariablesGlobales.IndBotonOnElevador = 1;
  //          VariablesGlobales.IndBotonOffElevador = 0;

        }

        private void ElevadorOffBoton_Click(object sender, EventArgs e)
        {
            ElevadorOnBoton.BackColor = Color.Gray;
            ElevadorOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.Elevador = 0; }
            else
            { MotoresGlobales.Elevador = 0; }
      //      VariablesGlobales.IndBotonOnElevador = 0;
      //      VariablesGlobales.IndBotonOffElevador = 1;

        }

        private void SecadorOnBoton_Click(object sender, EventArgs e)
        {
            SecadorOnBoton.BackColor = Color.Green;
            SecadorOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.Secador = 1; }
            else
            { MotoresGlobales.Secador = 1; }
     //       VariablesGlobales.IndBotonOnSecador = 1;
     //       VariablesGlobales.IndBotonOffSecador = 0;

        }

        private void SecadorOffBoton_Click(object sender, EventArgs e)
        {
            SecadorOnBoton.BackColor = Color.Gray;
            SecadorOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.Secador = 0; }
            else
            { MotoresGlobales.Secador = 0; }
            VariablesGlobales.IndBotonOnSecador = 0;
            VariablesGlobales.IndBotonOffSecador = 1;

        }

        private void SlingerAdelanteBoton_Click(object sender, EventArgs e)
        {
            
                SlingerAdelanteBoton.BackColor = Color.Green;
                SlingerStopBoton.BackColor = Color.Gray;
                SlingerAtrasBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            {
                MotoresGlobalesSimulados.SlingerAtras = 0;
                MotoresGlobalesSimulados.SlingerAdelante = 1;
            }
            else
            {
                MotoresGlobales.SlingerAtras = 0;
                MotoresGlobales.SlingerAdelante = 1;
            }
     //           VariablesGlobales.IndBotonSlingerAdelante = 1;
     //           VariablesGlobales.IndBotonSlingerStop = 0;
     //           VariablesGlobales.IndBotonSlingerAtras = 0;
        }

        private void SlingerStopBoton_Click(object sender, EventArgs e)
        {
            SlingerAdelanteBoton.BackColor = Color.Gray;
            SlingerStopBoton.BackColor = Color.Red;
            SlingerAtrasBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            {
                MotoresGlobalesSimulados.SlingerAdelante = 0;
                MotoresGlobalesSimulados.SlingerAtras = 0;
            }
            else
            {
                MotoresGlobales.SlingerAdelante = 0;
                MotoresGlobales.SlingerAtras = 0;
            }
   //         VariablesGlobales.IndBotonSlingerAdelante =0 ;
   //         VariablesGlobales.IndBotonSlingerStop = 1;
   //         VariablesGlobales.IndBotonSlingerAtras = 0;
            
        }

        private void SlingerAtrasBoton_Click(object sender, EventArgs e)
        {
                SlingerAdelanteBoton.BackColor = Color.Gray;
                SlingerStopBoton.BackColor = Color.Gray;
                SlingerAtrasBoton.BackColor = Color.Green;
                if (VariablesGlobales.Simulador == true)
                {
                    MotoresGlobalesSimulados.SlingerAdelante = 0;
                    MotoresGlobalesSimulados.SlingerAtras = 1;
                }
                else
                {
                    MotoresGlobales.SlingerAdelante = 0;
                    MotoresGlobales.SlingerAtras = 1;
                }
    //            VariablesGlobales.IndBotonSlingerAdelante = 0;
    //            VariablesGlobales.IndBotonSlingerStop = 0;
    //            VariablesGlobales.IndBotonSlingerAtras = 1;
            }

        private void BombaCombustibleOnBoton_Click(object sender, EventArgs e)
        {
            BombaCombustibleOnBoton.BackColor = Color.Green;
            BombaCombustibleOffBoton.BackColor = Color.Gray;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BombaCombustible = 1; }
            else
            { MotoresGlobales.BombaCombustible = 1; }
   //         VariablesGlobales.IndBotonOnBombaCombustible = 1;
    //        VariablesGlobales.IndBotonOffBombaCombustible = 0;

        }

        private void BombaCombustibleOffBoton_Click(object sender, EventArgs e)
        {
            BombaCombustibleOnBoton.BackColor = Color.Gray;
            BombaCombustibleOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BombaCombustible = 0; }
            else
            { MotoresGlobales.BombaCombustible = 0; }
   //         VariablesGlobales.IndBotonOnBombaCombustible = 0;
   //         VariablesGlobales.IndBotonOffBombaCombustible = 1;

        }

        private void DamperAutoBoton_Click(object sender, EventArgs e)
        {
            DamperAutoBoton.BackColor = Color.Yellow;
            DamperManualBoton.BackColor = Color.Gray;
            VariablesGlobales.DamperAutomaticoManual = 1;
        }

        private void DamperManualBoton_Click(object sender, EventArgs e)
        {
            DamperAutoBoton.BackColor = Color.Gray;
            DamperManualBoton.BackColor = Color.Yellow;
            VariablesGlobales.DamperAutomaticoManual = 0;
        }

        private void AgregadoRecicladoOnBoton_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaAgregadoReciclado = 1; }
            else
            { MotoresGlobales.BandaAgregadoReciclado = 1; }
  //          VariablesGlobales.IndBotonOnBandaAgregadoReciclado = 1;
  //          VariablesGlobales.IndBotonOffBandaAgregadoReciclado = 0;

        }

        private void AgregadoRecicladoOffBoton_Click(object sender, EventArgs e)
        {
            AgregadoRecicladoOnBoton.BackColor = Color.Gray;
            AgregadoRecicladoOffBoton.BackColor = Color.Red;
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.BandaAgregadoReciclado = 0; }
            else
            { MotoresGlobales.BandaAgregadoReciclado = 0; }
   //         VariablesGlobales.IndBotonOnBandaAgregadoReciclado = 0;
   //         VariablesGlobales.IndBotonOffBandaAgregadoReciclado = 1;

        }

        private void AlimentacionSiloCicloBoton_Click(object sender, EventArgs e)
        {
            AlimentacionSiloCicloBoton.BackColor = Color.Yellow;
            AlimentacionSiloOpenBoton.BackColor = Color.Gray;
            VariablesGlobales.IndBotonSiloOpenCiclo = 0;  // 0 para ciclo 1 para activar válvula
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.AlimentacionSilo = 1; }
            else
            { MotoresGlobales.AlimentacionSilo = 1; }
        }

        private void AlimentacionSiloOpenBoton_Click(object sender, EventArgs e)
        {
            AlimentacionSiloCicloBoton.BackColor = Color.Gray;
            AlimentacionSiloOpenBoton.BackColor = Color.Yellow;
            VariablesGlobales.IndBotonSiloOpenCiclo = 1;  // 0 para ciclo 1 para activar válvula
            if (VariablesGlobales.Simulador == true)
            { MotoresGlobalesSimulados.AlimentacionSilo = 0; }
            else
            { MotoresGlobales.AlimentacionSilo = 0; }
        }

        private void CombustibleAceiteBoton_Click(object sender, EventArgs e)
        {
            CombustibleAceiteBoton.BackColor = Color.Yellow;
            CombustibleGasBoton.BackColor = Color.Gray;
            VariablesGlobales.CombustibleAceiteGas = 1;  // 1 para aceite 0 para Gas
            
        }

        private void CombustibleGasBoton_Click(object sender, EventArgs e)
        {
            CombustibleAceiteBoton.BackColor = Color.Gray;
            CombustibleGasBoton.BackColor = Color.Yellow;
            VariablesGlobales.CombustibleAceiteGas = 0;  // 1 para Aceite 0 para Gas
        }

        private void PilotoBoton_Click(object sender, EventArgs e)
        {
            PilotoBoton.BackColor = Color.Yellow;
            VariablesGlobales.PilotoBoton = 1;
            
        }

        private void LlamaPrincipalBoton_Click(object sender, EventArgs e)
        {
            VariablesGlobales.LlamaPrincipalBoton = 1;
            LlamaPrincipalBoton.BackColor = Color.Yellow;
            if (VariablesGlobales.LlamaPrincipalBoton == 0)
                LlamaPrincipalBoton.BackColor = Color.Gray;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VariablesGlobales.ConsolaOculta = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VariablesGlobales.mediosegundo++; //aumento medio segundo
            ActualizarConsola();

        }


        private void ActualizarConsola()
        {
            if (VariablesGlobales.ConsolaControlMotores == false)
                this.Close();
            if (VariablesGlobales.PilotoBoton == 0)
                PilotoBoton.BackColor = Color.LightGray;
            if (VariablesGlobales.LlamaPrincipalBoton == 0)
                LlamaPrincipalBoton.BackColor = Color.LightGray;
            if (VariablesGlobales.mediosegundo != 2)//
            {
                VariablesGlobales.ResetPilotoLlamaPrincipal = 0; // paso medio segundo para resetear el R8090 en el metodo de Visualizar motores Piloto LLama
                VariablesGlobales.mediosegundo = 0;//para no dejar crecer esta variable
            }

          /*  else
            {
                AgregadoRecicladoOnBoton.BackColor = Color.Gray;
                AgregadoRecicladoOffBoton.BackColor = Color.Red;
            }
    */        
    /////////////////***********actualiza los colores de los botones de acuerdo al estado de los motores**********\\\\\\\\\\
            if (VariablesGlobales.Simulador == true)
            {
                if (MotoresGlobalesSimulados.BandaAlimentadora == 1)
                {
                   BandaInclinadaOnBoton.BackColor = Color.Green;
                   BandaInclinadaOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BandaInclinadaOnBoton.BackColor = Color.Gray;
                    BandaInclinadaOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.Zaranda == 1)
                {
                    ZarandaOnBoton.BackColor = Color.Green;
                    ZarandaOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    ZarandaOnBoton.BackColor = Color.Gray;
                    ZarandaOffBoton.BackColor = Color.Red;
                }


                if (MotoresGlobalesSimulados.BandaColectora == 1)
                {
                    BandaColectoraOnBoton.BackColor = Color.Green;
                    BandaColectoraOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BandaColectoraOnBoton.BackColor = Color.Gray;
                    BandaColectoraOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.BandaAgregados1 == 1)
                {
                    BandaAgregados1OnBoton.BackColor = Color.Green;
                    BandaAgregados1OffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BandaAgregados1OnBoton.BackColor = Color.Gray;
                    BandaAgregados1OffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.BandaAgregados2 == 1)
                {
                    BandaAgregados2OnBoton.BackColor = Color.Green;
                    BandaAgregados2OffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BandaAgregados2OnBoton.BackColor = Color.Gray;
                    BandaAgregados2OffBoton.BackColor = Color.Red;
                }
                if (MotoresGlobalesSimulados.BandaAgregados3 == 1)
                {
                    BandaAgregados3OnBoton.BackColor = Color.Green;
                    BandaAgregados3OffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BandaAgregados3OnBoton.BackColor = Color.Gray;
                    BandaAgregados3OffBoton.BackColor = Color.Red;
                }
                if (MotoresGlobalesSimulados.BandaAgregados4 == 1)
                {
                    BandaAgregados4OnBoton.BackColor = Color.Green;
                    BandaAgregados4OffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BandaAgregados4OnBoton.BackColor = Color.Gray;
                    BandaAgregados4OffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.CompuertaReciclado == 1)
                {
                    CompuertaRecicladoBotonSecador.BackColor = Color.Green;
                    CompuertaRecicladoBotonRechazo.BackColor = Color.Gray;
                }
                else
                {
                    CompuertaRecicladoBotonSecador.BackColor = Color.Gray;
                    CompuertaRecicladoBotonRechazo.BackColor = Color.Red;
                }


                if (MotoresGlobalesSimulados.BandaInclinadaReciclado == 1)
                {
                    BandaRecicladoOnBoton.BackColor = Color.Green;
                    BandaRecicladoOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BandaRecicladoOnBoton.BackColor = Color.Gray;
                    BandaRecicladoOffBoton.BackColor = Color.Red;
                }


                if (MotoresGlobalesSimulados.MotorTrituradoReciclado == 1)
                {
                    MotorTrituradoOnBoton.BackColor = Color.Green;
                    MotorTrituradoOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    MotorTrituradoOnBoton.BackColor = Color.Gray;
                    MotorTrituradoOffBoton.BackColor = Color.Red;
                }


                if (MotoresGlobalesSimulados.BandaAgregadoReciclado == 1)
                {
                    AgregadoRecicladoOnBoton.BackColor = Color.Green;
                    AgregadoRecicladoOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    AgregadoRecicladoOnBoton.BackColor = Color.Gray;
                    AgregadoRecicladoOffBoton.BackColor = Color.Red;
                }


                if (VariablesGlobales.CombustibleAceiteGas == 1)
                {
                    CombustibleAceiteBoton.BackColor = Color.Yellow;
                    CombustibleGasBoton.BackColor = Color.Gray;
                }
                else
                {
                    CombustibleAceiteBoton.BackColor = Color.Gray;
                    CombustibleGasBoton.BackColor = Color.Yellow;
                }

                if (MotoresGlobalesSimulados.BombaCombustible == 1)
                {
                    BombaCombustibleOnBoton.BackColor = Color.Green;
                    BombaCombustibleOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BombaCombustibleOnBoton.BackColor = Color.Gray;
                    BombaCombustibleOffBoton.BackColor = Color.Red;
                }


                if (MotoresGlobalesSimulados.MotorBlowerBH == 1)
                {
                    BlowerBHOnBoton.BackColor = Color.Green;
                    BlowerBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BlowerBHOnBoton.BackColor = Color.Gray;
                    BlowerBHOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.MotorVannerBH == 1)
                {
                    VannerBHOnBoton.BackColor = Color.Green;
                    VannerBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    VannerBHOnBoton.BackColor = Color.Gray;
                    VannerBHOffBoton.BackColor = Color.Red;
                }


                if (MotoresGlobalesSimulados.SinFinTransversalBH == 1)
                {
                    TransversalBHOnBoton.BackColor = Color.Green;
                    TransversalBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    TransversalBHOnBoton.BackColor = Color.Gray;
                    TransversalBHOffBoton.BackColor = Color.Red;
                }


                if (MotoresGlobalesSimulados.SinFinColector1BH == 1)
                {
                    Colector1BHOnBoton.BackColor = Color.Green;
                    Colector1BHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    Colector1BHOnBoton.BackColor = Color.Gray;
                    Colector1BHOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.SinFinColector2BH == 1)
                {
                    Colector2BHOnBoton.BackColor = Color.Green;
                    Colector2BHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    Colector2BHOnBoton.BackColor = Color.Gray;
                    Colector2BHOffBoton.BackColor = Color.Red;
                }

                if (VariablesGlobales.Secuencia_Rotores == 1)
                {
                    RotoresBHOnBoton.BackColor = Color.Green;
                    RotoresBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    RotoresBHOnBoton.BackColor = Color.Gray;
                    RotoresBHOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.Compresor == 1)
                {
                    CompresorOnBoton.BackColor = Color.Green;
                    CompresorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    CompresorOnBoton.BackColor = Color.Gray;
                    CompresorOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.BombaAsfaltoAdelante == 0 && MotoresGlobalesSimulados.BombaAsfaltoAtras == 0)
                {
                    BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                    BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
                    BombaAsfaltoStopBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.BombaAsfaltoAdelante == 1)
                {
                    BombaAsfaltoAdelanteBoton.BackColor = Color.Green;
                    BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
                    BombaAsfaltoStopBoton.BackColor = Color.Gray;
                }

                if (MotoresGlobalesSimulados.BombaAsfaltoAtras == 1)
                {
                    BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                    BombaAsfaltoAtrasBoton.BackColor = Color.Green;
                    BombaAsfaltoStopBoton.BackColor = Color.Gray;
                }

                if (MotoresGlobalesSimulados.SlingerAdelante == 0 && MotoresGlobales.SlingerAtras == 0)
                {
                    SlingerAdelanteBoton.BackColor = Color.Gray;
                    SlingerAtrasBoton.BackColor = Color.Gray;
                    SlingerStopBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.SlingerAdelante == 1)
                {
                    SlingerAdelanteBoton.BackColor = Color.Green;
                    SlingerAtrasBoton.BackColor = Color.Gray;
                    SlingerStopBoton.BackColor = Color.Gray;
                }

                if (MotoresGlobalesSimulados.SlingerAtras == 1)
                {
                    SlingerAdelanteBoton.BackColor = Color.Gray;
                    SlingerAtrasBoton.BackColor = Color.Green;
                    SlingerStopBoton.BackColor = Color.Gray;
                }


                if (MotoresGlobalesSimulados.Extractor1BH == 1 && MotoresGlobalesSimulados.Extractor2BH == 1)
                {
                    ExtractorBHOnBoton.BackColor = Color.Green;
                    ExtractorBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    ExtractorBHOnBoton.BackColor = Color.Gray;
                    ExtractorBHOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.BlowerQuemador == 1 )
                {
                    BlowerQuemadorOnBoton.BackColor = Color.Green;
                    BlowerQuemadorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BlowerQuemadorOnBoton.BackColor = Color.Gray;
                    BlowerQuemadorOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.Elevador == 1)
                {
                    ElevadorOnBoton.BackColor = Color.Green;
                    ElevadorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    ElevadorOnBoton.BackColor = Color.Gray;
                    ElevadorOffBoton.BackColor = Color.Red;
                }

                if (MotoresGlobalesSimulados.Secador == 1)
                {
                    SecadorOnBoton.BackColor = Color.Green;
                    SecadorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    SecadorOnBoton.BackColor = Color.Gray;
                    SecadorOffBoton.BackColor = Color.Red;
                }


                if (VariablesGlobales.DrumBypass == 1)
                {
                    DrumBypassOnBoton.BackColor = Color.Green;
                    DrumBypassOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    DrumBypassOnBoton.BackColor = Color.Gray;
                    DrumBypassOffBoton.BackColor = Color.Red;
                }





            }

            else
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

                if (EntradasGlobales.CompuertaReciclado == '1')
                {
                    CompuertaRecicladoBotonSecador.BackColor = Color.Green;
                    CompuertaRecicladoBotonRechazo.BackColor = Color.Gray;
                }
                else
                {
                    CompuertaRecicladoBotonSecador.BackColor = Color.Gray;
                    CompuertaRecicladoBotonRechazo.BackColor = Color.Red;
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


                if (VariablesGlobales.CombustibleAceiteGas == 1)
                {
                    CombustibleAceiteBoton.BackColor = Color.Yellow;
                    CombustibleGasBoton.BackColor = Color.Gray;
                }
                else
                {
                    CombustibleAceiteBoton.BackColor = Color.Gray;
                    CombustibleGasBoton.BackColor = Color.Yellow;
                }

                if (EntradasGlobales.BombaCombustible == '1')
                {
                    BombaCombustibleOnBoton.BackColor = Color.Green;
                    BombaCombustibleOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BombaCombustibleOnBoton.BackColor = Color.Gray;
                    BombaCombustibleOffBoton.BackColor = Color.Red;
                }


                if (EntradasGlobales.MotorBlowerBH == '1')
                {
                    BlowerBHOnBoton.BackColor = Color.Green;
                    BlowerBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BlowerBHOnBoton.BackColor = Color.Gray;
                    BlowerBHOffBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.MotorVannerBH == '1')
                {
                    VannerBHOnBoton.BackColor = Color.Green;
                    VannerBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    VannerBHOnBoton.BackColor = Color.Gray;
                    VannerBHOffBoton.BackColor = Color.Red;
                }


                if (EntradasGlobales.SinFinTransversalBH == '1')
                {
                    TransversalBHOnBoton.BackColor = Color.Green;
                    TransversalBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    TransversalBHOnBoton.BackColor = Color.Gray;
                    TransversalBHOffBoton.BackColor = Color.Red;
                }


                if (EntradasGlobales.SinFinColector1BH == '1')
                {
                    Colector1BHOnBoton.BackColor = Color.Green;
                    Colector1BHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    Colector1BHOnBoton.BackColor = Color.Gray;
                    Colector1BHOffBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.SinFinColector2BH == '1')
                {
                    Colector2BHOnBoton.BackColor = Color.Green;
                    Colector2BHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    Colector2BHOnBoton.BackColor = Color.Gray;
                    Colector2BHOffBoton.BackColor = Color.Red;
                }

                if (VariablesGlobales.Secuencia_Rotores == 1)
                {
                    RotoresBHOnBoton.BackColor = Color.Green;
                    RotoresBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    RotoresBHOnBoton.BackColor = Color.Gray;
                    RotoresBHOffBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.Compresor == '1')
                {
                    CompresorOnBoton.BackColor = Color.Green;
                    CompresorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    CompresorOnBoton.BackColor = Color.Gray;
                    CompresorOffBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.BombaAsfaltoAdelante == '0' && EntradasGlobales.BombaAsfaltoAtras == '0')
                {
                    BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                    BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
                    BombaAsfaltoStopBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.BombaAsfaltoAdelante == '1')
                {
                    BombaAsfaltoAdelanteBoton.BackColor = Color.Green;
                    BombaAsfaltoAtrasBoton.BackColor = Color.Gray;
                    BombaAsfaltoStopBoton.BackColor = Color.Gray;
                }

                if (EntradasGlobales.BombaAsfaltoAtras == '1')
                {
                    BombaAsfaltoAdelanteBoton.BackColor = Color.Gray;
                    BombaAsfaltoAtrasBoton.BackColor = Color.Green;
                    BombaAsfaltoStopBoton.BackColor = Color.Gray;
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


                if (EntradasGlobales.Extractor1BH == '1' && EntradasGlobales.Extractor2BH == '1')
                {
                    ExtractorBHOnBoton.BackColor = Color.Green;
                    ExtractorBHOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    ExtractorBHOnBoton.BackColor = Color.Gray;
                    ExtractorBHOffBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.BlowerQuemador == '1')
                {
                    BlowerQuemadorOnBoton.BackColor = Color.Green;
                    BlowerQuemadorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    BlowerQuemadorOnBoton.BackColor = Color.Gray;
                    BlowerQuemadorOffBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.Elevador == '1')
                {
                    ElevadorOnBoton.BackColor = Color.Green;
                    ElevadorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    ElevadorOnBoton.BackColor = Color.Gray;
                    ElevadorOffBoton.BackColor = Color.Red;
                }

                if (EntradasGlobales.Secador == '1')
                {
                    SecadorOnBoton.BackColor = Color.Green;
                    SecadorOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    SecadorOnBoton.BackColor = Color.Gray;
                    SecadorOffBoton.BackColor = Color.Red;
                }


                if (VariablesGlobales.DrumBypass == 1)
                {
                    DrumBypassOnBoton.BackColor = Color.Green;
                    DrumBypassOffBoton.BackColor = Color.Gray;
                }
                else
                {
                    DrumBypassOnBoton.BackColor = Color.Gray;
                    DrumBypassOffBoton.BackColor = Color.Red;
                }


            }



        }

        private void ResetPilotoLLamaBoton_Click(object sender, EventArgs e)
        {
            VariablesGlobales.ResetPilotoLlamaPrincipal = 1;
            VariablesGlobales.mediosegundo++;
        }
        

        private void ControlMotores_Load(object sender, EventArgs e)
        {

        }
    }
}
