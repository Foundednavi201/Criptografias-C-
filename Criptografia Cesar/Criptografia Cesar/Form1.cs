using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia_Cesar
{
    public partial class frmPrincipal : Form
    {
        public static string AlfabetoIngles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string mensaje = "";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Botones
        private void btnCifrar_Click(object sender, EventArgs e)
        {
            mensaje = txtMcla.Text;
            txtCriptograma.Text = Cifrar();
        }
        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            mensaje = txtMcla.Text;
            txtCriptograma.Text = Descifrar();
        }

        //Método para cifrar el mensaje en claro
        public string Cifrar()
        {
            //Variables locales
            string msjProcesado = "";
            int desplazamiento = 3;

            
            //Recorremos los caracteres del mensaje 
            for(int i = 0; i < mensaje.Length; i++)
            {
                int posicion = PosicionAlfabeto(mensaje[i]);
                if(posicion != -1)
                {
                    int pos = (posicion + desplazamiento) % 26; //Fórmula para determinar el caracter
                    while(pos >= AlfabetoIngles.Length)
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
            return msjProcesado;
        }

        //Método para descifrar el criptograma
        public string Descifrar()
        {
            //Variables locales
            string msjProcesado = "";
            int desplazamiento = 3;
            
            //Recorremos los caracteres del mensaje
            for (int i = 0; i < mensaje.Length; i++)
            {
                int posicion = PosicionAlfabeto(mensaje[i]);
                if (posicion != -1)
                {
                    int pos = (posicion - desplazamiento) % 26; //Fórmula para determinar el caracter

                    if(pos <= 2)// si la posición resulta negativa entonces se le suman 26
                    {
                        pos = pos + 26;
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
            return msjProcesado;
        }

        //Método que determina la posicion del caracter en el alfabeto
        static int PosicionAlfabeto(char caracter)
        {
            for(int i = 0; i <AlfabetoIngles.Length; i++)
            {
                if(caracter == AlfabetoIngles[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
