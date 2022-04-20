using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia_Desplazamiento
{
    public partial class frmPrincipal : Form
    {

        public static string AlfabetoIngles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Alfabeto
        //Variables globales
        string mensaje = "";
        int desplazamiento = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Botónes
        private void btnCifrar_Click(object sender, EventArgs e)
        {
            if(txtMensaje.Text == "")
            {
                MessageBox.Show("Ingresa un mensaje a cifrar/descifrar !!!","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(txtLlave.Text == "")
                {
                    MessageBox.Show("Ingrese una Llave !!!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    mensaje = txtMensaje.Text;
                    desplazamiento = int.Parse(txtLlave.Text);
                    txtMsjProcesado.Text = Cifrar();
                }
            }
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "")
            {
                MessageBox.Show("Ingresa un mensaje a cifrar/descifrar !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtLlave.Text == "")
                {
                    MessageBox.Show("Ingrese una Llave !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    mensaje = txtMensaje.Text;
                    desplazamiento = int.Parse(txtLlave.Text);
                    txtMsjProcesado.Text = Descifrar();
                }
            }
        }


        //Método para cifrar el mensaje en claro
        public string Cifrar()
        {
            //Variable local
            string msjProcesado = "";

            
            if (desplazamiento > 0 && desplazamiento < AlfabetoIngles.Length)
            {
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posicion = PosicionAlfabeto(mensaje[i]);
                    if (posicion != -1)
                    {
                        int pos = (posicion + desplazamiento) % 26; //Fórmula para determinar el caracter
                        while (pos >= AlfabetoIngles.Length)
                        {
                            pos = pos - AlfabetoIngles.Length;
                        }
                        msjProcesado += AlfabetoIngles[pos];
                    }
                    else
                    {
                        msjProcesado += mensaje[i];
                    }
                }
            }
            return msjProcesado;
        }

        //Método para descifrar el criptograma
        public string Descifrar()
        {
            //Variable local
            string msjProcesado = "";

            if (desplazamiento > 0 && desplazamiento < AlfabetoIngles.Length)
            {
                //Recorremos los caracteres del mensaje
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posicion = PosicionAlfabeto(mensaje[i]);
                    if (posicion != -1)
                    {
                        int pos = (posicion - desplazamiento) % 26;//Fórmula para determinar el caracter

                        if(pos < 0) //Si la posición resulta negativa entonces se le suman 26
                        {
                            pos += 26;
                        }

                        while (pos >= AlfabetoIngles.Length)
                        {
                            pos = pos - AlfabetoIngles.Length;
                        }
                        msjProcesado += AlfabetoIngles[pos];
                    }
                    else
                    {
                        msjProcesado += mensaje[i];
                    }
                }
            }
            return msjProcesado;
        }

        //Método que determina la posicion del caracter en el alfabeto
        static int PosicionAlfabeto(char caracter)
        {
            for (int i = 0; i < AlfabetoIngles.Length; i++)
            {
                if (caracter == AlfabetoIngles[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
