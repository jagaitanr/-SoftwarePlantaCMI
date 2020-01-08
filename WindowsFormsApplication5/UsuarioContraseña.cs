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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


       




        // método para comprobar usuario y contraseña
        public void Comprobacion_Usuario(object sender, EventArgs e)
        {
            if (TxBxUsuario.Text == "" && TxBxContraseña.Text == "")
                MessageBox.Show("Usuario y Contraseña vacíos");
            else
            { if (TxBxUsuario.Text == "Usuario" && TxBxContraseña.Text == "4321")
                {
                    Application.Run(new MenuPrincipal()); //arranca Menú principal
                    this.Close(); //se cierra la ventana de la validación
                }
                else
                    MessageBox.Show("Usuario y/o contraseña incorrectos");


            }
        }
        private void Boton_Verificación_usuario_Click(object sender, EventArgs e)
        {
            //Comprobacion_Usuario();
            Boton_Verificación_usuario.Enabled = false;
            if (TxBxUsuario.Text == "" && TxBxContraseña.Text == "")
            { MessageBox.Show("Usuario y Contraseña vacíos");
            Boton_Verificación_usuario.Enabled = true; }
                    
            else
            {
                if (TxBxUsuario.Text == "Usuario" && TxBxContraseña.Text == "4321")
                {
                    MenuPrincipal frm = new MenuPrincipal();
                    Boton_Verificación_usuario.Enabled = true;
                    this.Hide();
                    frm.Show();
                }
                else
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                Boton_Verificación_usuario.Enabled = true;

            }
        }
    }
}
