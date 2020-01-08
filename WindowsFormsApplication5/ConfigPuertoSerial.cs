using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class ConfigPuertoSerial : Form
    {
        public ConfigPuertoSerial()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //para controlar las excepciones del puerto serial
        }

        private void ConfigPuertoSerial_Load(object sender, EventArgs e)
        {
            PuertosDisponibles();
        }

        private void PuertosDisponibles()
        {
            foreach (string PuertosDisponibles in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(PuertosDisponibles);//adiciona cada puerto que detecta disponible del computador
            }
        }

        private void cmbPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbPuertos.Text;//asigna el valor seleccionado en el combobox
            VariablesGlobales.PuertoSerieEscogido = serialPort1.PortName;
           // VariablesGlobales.PuertoDefinido = true;
            cmbPuertos.Enabled = false; //deshabilita el combobox para que no modifiquen el puerto

            try
            {
                serialPort1.Open();//para capturar la excepción de apertura del puerto
            }

            catch 
            {
                MessageBox.Show("Seleccione otro puerto\n Puerto NO disponible");
                cmbPuertos.Enabled = true;// vuelve a habilitar el puerto ya que no estaba disponible
            }

        }

        private void ConfigPuertoSerial_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();//cuando se cierra el formulario, cerrar el puerto serial
        }

        private void EnviarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("dato2");
                serialPort1.Write(Datos_a_Enviar.Text.Trim());
                //DatosRecibidos.Text = serialPort1.ReadLine();

            }
            catch
            {
                MessageBox.Show("No se pudo enviar la información", "error");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                DatosRecibidos.Text = serialPort1.ReadLine();
            }

            catch 
            {
                MessageBox.Show("error de recepción");
            }

            //serialPort1.Close();


        }
    }
}
