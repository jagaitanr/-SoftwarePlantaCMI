using System;
using System.IO;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
             

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            VariablesGlobales.Simulador = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ingreso frm1 = new Ingreso();
            frm1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Planta frm = new WindowsFormsApplication5.Planta();
            //frm.Show();

            if (VariablesGlobales.Simulador == false)
            {
                Planta frm = new WindowsFormsApplication5.Planta();
                frm.Show();
            }
            else
            {
                Simulador frm = new WindowsFormsApplication5.Simulador();
                frm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                DiseñoMezclas frm2 = new WindowsFormsApplication5.DiseñoMezclas();
                frm2.Show();
         }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            VariablesGlobales.Simulador = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalibracionAgregados frm3 = new WindowsFormsApplication5.CalibracionAgregados();
            frm3.Show();
           // this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
                ConfigPuertoSerial frm2 = new WindowsFormsApplication5.ConfigPuertoSerial();
                frm2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalibracionRecicladocs frm4 = new WindowsFormsApplication5.CalibracionRecicladocs();
            frm4.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalibracionBombaAsfalto frm5 = new WindowsFormsApplication5.CalibracionBombaAsfalto();
            frm5.Show();

        }

        private void CargarDatosConfiguración_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("C:\\Users\\MHC\\Documents\\Programas planta CMI\\Implementación semiautomatico planta CMI\\WindowsFormsApplication5_copia Dic2017\\Configuración\\confVel2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(archivo);
            escribir.WriteLine("hola");
            escribir.WriteLine(Convert.ToString(VariablesGlobales.TPH_HzAgregado1));
            escribir.WriteLine(Convert.ToString(VariablesGlobales.TPH_HzAgregado2));
            escribir.WriteLine(Convert.ToString(VariablesGlobales.TPH_HzAgregado3));
            escribir.Close();


        }

        
    }
}
