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

    public partial class DiseñoMezclas : Form
    {
        public DiseñoMezclas()
        {
            string path = "C:\\Users\\MHC\\Documents\\Programas planta CMI\\Implementación semiautomatico planta CMI\\WindowsFormsApplication5_copia Dic2017\\Mezclas\\";
            //string path = "C:\\Users\\USUARIO\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication5\\Mezclas\\";
            InitializeComponent();
            MezclasDisponibles(path);

        }


        private void ActualizarBoton_Click(object sender, EventArgs e)
        {
            try //codigo protegido contra error de formato en el llenado de campos
            {
                VariablesGlobales.PorcentajeIngresadoAgregado1 = double.Parse(PorcentajeAgregado1.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoAgregado2 = double.Parse(PorcentajeAgregado2.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoAgregado3 = double.Parse(PorcentajeAgregado3.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoAgregado4 = double.Parse(PorcentajeAgregado4.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoReciclado = double.Parse(PorcentajeReciclado.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoAsfalto = double.Parse(PorcentajeAsfalto.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoHumedadAgregado1 = double.Parse(HumedadAgregado1.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoHumedadAgregado2 = double.Parse(HumedadAgregado2.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoHumedadAgregado3 = double.Parse(HumedadAgregado3.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoHumedadAgregado4 = double.Parse(HumedadAgregado4.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoHumedadReciclado = double.Parse(HumedadReciclado.Text);// conversión de string a double
                VariablesGlobales.PorcentajeIngresadoAsfaltoReciclado = double.Parse(PorcentajeAsfaltoReciclado.Text);// conversión de string a double
                VariablesGlobales.TiempoInicioAgregado1 = double.Parse(TiempoInicioAgregado1.Text);
                VariablesGlobales.TiempoInicioAgregado2 = double.Parse(TiempoInicioAgregado2.Text);
                VariablesGlobales.TiempoInicioAgregado3 = double.Parse(TiempoInicioAgregado3.Text);
                VariablesGlobales.TiempoInicioAgregado4 = double.Parse(TiempoInicioAgregado4.Text);
                VariablesGlobales.TiempoInicioReciclado = double.Parse(TiempoInicioReciclado.Text);
                VariablesGlobales.TiempoPararAgregado1 = double.Parse(TiempoPararAgregado1.Text);
                VariablesGlobales.TiempoPararAgregado2 = double.Parse(TiempoPararAgregado2.Text);
                VariablesGlobales.TiempoPararAgregado3 = double.Parse(TiempoPararAgregado3.Text);
                VariablesGlobales.TiempoPararAgregado4 = double.Parse(TiempoPararAgregado4.Text);
                VariablesGlobales.TiempoPararReciclado = double.Parse(TiempoPararReciclado.Text);

                //** CÁLCULOS**
                if (VariablesGlobales.PorcentajeIngresadoAgregado1 + VariablesGlobales.PorcentajeIngresadoAgregado2 + VariablesGlobales.PorcentajeIngresadoAgregado3 + VariablesGlobales.PorcentajeIngresadoAgregado4 + VariablesGlobales.PorcentajeIngresadoReciclado == 100)

                {
                    if (VariablesGlobales.PorcentajeIngresadoHumedadAgregado1 <= 99 && VariablesGlobales.PorcentajeIngresadoHumedadAgregado2 <= 99 && VariablesGlobales.PorcentajeIngresadoHumedadAgregado3 <= 99 && VariablesGlobales.PorcentajeIngresadoHumedadAgregado4 <= 99 && (VariablesGlobales.PorcentajeIngresadoHumedadReciclado + VariablesGlobales.PorcentajeIngresadoAsfaltoReciclado <= 99))
                    {
                        VariablesGlobales.Asfaltoen100kg = VariablesGlobales.PorcentajeIngresadoAsfalto - (VariablesGlobales.PorcentajeIngresadoAsfaltoReciclado * VariablesGlobales.PorcentajeIngresadoReciclado / 100);
                        InfAsfalto.Text = VariablesGlobales.Asfaltoen100kg.ToString();
                        VariablesGlobales.Agregado1en100kg = (VariablesGlobales.PorcentajeIngresadoAgregado1 * ((100 - VariablesGlobales.Asfaltoen100kg) / 100)) * (1 / (1 - (VariablesGlobales.PorcentajeIngresadoHumedadAgregado1 / 100)));
                        InfAgregado1.Text = VariablesGlobales.Agregado1en100kg.ToString();
                        VariablesGlobales.Agregado2en100kg = (VariablesGlobales.PorcentajeIngresadoAgregado2 * ((100 - VariablesGlobales.Asfaltoen100kg) / 100)) * (1 / (1 - (VariablesGlobales.PorcentajeIngresadoHumedadAgregado2 / 100)));
                        InfAgregado2.Text = VariablesGlobales.Agregado2en100kg.ToString();
                        VariablesGlobales.Agregado3en100kg = (VariablesGlobales.PorcentajeIngresadoAgregado3 * ((100 - VariablesGlobales.Asfaltoen100kg) / 100)) * (1 / (1 - (VariablesGlobales.PorcentajeIngresadoHumedadAgregado3 / 100)));
                        InfAgregado3.Text = VariablesGlobales.Agregado3en100kg.ToString();
                        VariablesGlobales.Agregado4en100kg = (VariablesGlobales.PorcentajeIngresadoAgregado4 * ((100 - VariablesGlobales.Asfaltoen100kg) / 100)) * (1 / (1 - (VariablesGlobales.PorcentajeIngresadoHumedadAgregado4 / 100)));
                        InfAgregado4.Text = VariablesGlobales.Agregado4en100kg.ToString();
                        VariablesGlobales.Recicladoen100kg = (VariablesGlobales.PorcentajeIngresadoReciclado * ((100 - VariablesGlobales.Asfaltoen100kg) / 100)) * (1 / (1 - (VariablesGlobales.PorcentajeIngresadoHumedadReciclado / 100) - (VariablesGlobales.PorcentajeIngresadoAsfaltoReciclado / 100)));
                        InfReciclado.Text = VariablesGlobales.Recicladoen100kg.ToString();
                    }
                    else
                        MessageBox.Show("El valor de la humedad debe ser menor al 100%, revisar humedades ");

                }
                else
                    MessageBox.Show("La suma entre agregados y reciclado debe sumar 100% ");
            }

            catch (System.FormatException) //captura del error por llenado de campos con texto y no numeros
            {
                MessageBox.Show("Todos los campos requieren\n números,  corrija error");
            }

        }

      
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NombreMezcla.Text))
                MessageBox.Show("campo vacío");
            else
            {
                VariablesGlobales.TextoParaConfirmación = "Está seguro que desea cambiar los datos de éste diseño";
                mensajeConfirmación frm2 = new WindowsFormsApplication5.mensajeConfirmación();
                frm2.Visible = false;
                if (frm2.ShowDialog(this) == DialogResult.OK) // revisa si el mensaje de borrar mezcla fue confirmado
                {
                    string path = "C:\\Users\\MHC\\Documents\\Programas planta CMI\\Implementación semiautomatico planta CMI\\WindowsFormsApplication5_copia Dic2017\\Mezclas\\";

                    //string path = "C:\\Users\\USUARIO\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication5\\Mezclas\\";
                    FileStream archivo = new FileStream(path + NombreMezcla.Text + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter escribir = new StreamWriter(archivo);
                    escribir.WriteLine(NombreMezcla.Text);
                    escribir.WriteLine(Convert.ToString(PorcentajeAgregado1.Text));
                    escribir.WriteLine(Convert.ToString(PorcentajeAgregado2.Text));
                    escribir.WriteLine(Convert.ToString(PorcentajeAgregado3.Text));
                    escribir.WriteLine(Convert.ToString(PorcentajeAgregado4.Text));
                    escribir.WriteLine(Convert.ToString(PorcentajeReciclado.Text));
                    escribir.WriteLine(Convert.ToString(PorcentajeAsfalto.Text));
                    escribir.WriteLine(Convert.ToString(HumedadAgregado1.Text));
                    escribir.WriteLine(Convert.ToString(HumedadAgregado2.Text));
                    escribir.WriteLine(Convert.ToString(HumedadAgregado3.Text));
                    escribir.WriteLine(Convert.ToString(HumedadAgregado4.Text));
                    escribir.WriteLine(Convert.ToString(HumedadReciclado.Text));
                    escribir.WriteLine(Convert.ToString(PorcentajeAsfaltoReciclado.Text));
                    escribir.WriteLine(Convert.ToString(TiempoInicioAgregado1.Text));
                    escribir.WriteLine(Convert.ToString(TiempoInicioAgregado2.Text));
                    escribir.WriteLine(Convert.ToString(TiempoInicioAgregado3.Text));
                    escribir.WriteLine(Convert.ToString(TiempoInicioAgregado4.Text));
                    escribir.WriteLine(Convert.ToString(TiempoInicioReciclado.Text));
                    escribir.WriteLine(Convert.ToString(TiempoPararAgregado1.Text));
                    escribir.WriteLine(Convert.ToString(TiempoPararAgregado2.Text));
                    escribir.WriteLine(Convert.ToString(TiempoPararAgregado3.Text));
                    escribir.WriteLine(Convert.ToString(TiempoPararAgregado4.Text));
                    escribir.WriteLine(Convert.ToString(TiempoPararReciclado.Text));
                    escribir.Close();
                    cmbMezclas.Items.Add(NombreMezcla.Text);//adiciona cada mezcla guardada en ésta carpeta
                }
                VariablesGlobales.Confirmado = false;

            }

        }

        private void cmbMezclas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "C:\\Users\\MHC\\Documents\\Programas planta CMI\\Implementación semiautomatico planta CMI\\WindowsFormsApplication5_copia Dic2017\\Mezclas\\";
            //C:\\Users\\USUARIO\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication5\\Mezclas\\";

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path + cmbMezclas.Text); //seleccionamos el archivo
                NombreMezcla.Text = file.ReadLine();
                PorcentajeAgregado1.Text = file.ReadLine();
                PorcentajeAgregado2.Text = file.ReadLine();
                PorcentajeAgregado3.Text = file.ReadLine();
                PorcentajeAgregado4.Text = file.ReadLine();
                PorcentajeReciclado.Text = file.ReadLine();
                PorcentajeAsfalto.Text = file.ReadLine();
                HumedadAgregado1.Text = file.ReadLine();
                HumedadAgregado2.Text = file.ReadLine();
                HumedadAgregado3.Text = file.ReadLine();
                HumedadAgregado4.Text = file.ReadLine();
                HumedadReciclado.Text = file.ReadLine();
                PorcentajeAsfaltoReciclado.Text = file.ReadLine();
                TiempoInicioAgregado1.Text = file.ReadLine();
                TiempoInicioAgregado2.Text = file.ReadLine();
                TiempoInicioAgregado3.Text = file.ReadLine();
                TiempoInicioAgregado4.Text = file.ReadLine();
                TiempoInicioReciclado.Text = file.ReadLine();
                TiempoPararAgregado1.Text = file.ReadLine();
                TiempoPararAgregado2.Text = file.ReadLine();
                TiempoPararAgregado3.Text = file.ReadLine();
                TiempoPararAgregado4.Text = file.ReadLine();
                TiempoPararReciclado.Text = file.ReadLine();
                file.Close();
                cmbMezclas.Enabled = false;
                NombreMezcla.Enabled = false;
            }

            catch
            {
                MessageBox.Show("error en la ruta de acceso al archivo, \n se debe modificar directorio de acceos en el programa");

            }

        }


        private void MezclasDisponibles(string CarpetaRaiz)
        {

            string[] fileEntries = Directory.GetFiles(CarpetaRaiz); // se crea una lista (array) en fileEntries con el nombre de los archivos

            foreach (string a in fileEntries)   // para cada elemento existente en el array FileEntries se crea un item
            {
                cmbMezclas.Items.Add(Path.GetFileName(a));    // llena solo con el nombre del archivo, cada uno de los elementos encontrados
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\MHC\\Documents\\Programas planta CMI\\Implementación semiautomatico planta CMI\\WindowsFormsApplication5_copia Dic2017\\Mezclas\\";   
           // C:\\Users\\USUARIO\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication5\\Mezclas\\";

                VariablesGlobales.TextoParaConfirmación = ("Está seguro que desea borrar: "+cmbMezclas.Text); 
            mensajeConfirmación frm2 = new WindowsFormsApplication5.mensajeConfirmación();
            
            frm2.Visible = false;

            if (frm2.ShowDialog(this)==DialogResult.OK) // revisa si el mensaje de borrar mezcla fue confirmado
            {

                System.IO.File.Delete(path + cmbMezclas.Text);
            }
            VariablesGlobales.Confirmado = false; // resetea esta variable para dejar habilitado para otros mensajes
        }

        
    }

}
  