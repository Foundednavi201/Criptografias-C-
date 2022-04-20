using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia_Cesar
{
    internal class Metodo_Cesar
    {
        private string _strMcla;

        public string Mcla
        {
            get { return _strMcla; }
            set { _strMcla = value; }
        }

        private string[] _strAlfabeto;

        public string[] Alfabeto
        {
            get { return _strAlfabeto; }
            set { _strAlfabeto = value; }
        }

        private string _strMsjProcesado;

        public string MsjProcesado
        {
            get { return _strMsjProcesado; }
            set { _strMsjProcesado = value; }
        }

        //Unidades que se usaran para desplazarse en el alfabeto
        const int Desplazamiento = 2;

        //Método para cifrar el mensaje en claro
        public string Cifrar(string Msj)
        {

            return "hola";
        }

        //Método para descifrar el Criptograma
        public string Descifrar(string Msj)
        {
            return "hola";
        }
    }
}
