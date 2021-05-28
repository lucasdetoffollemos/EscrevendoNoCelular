using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Teclado
    {
        readonly ConversorDeCaractere conversor = new ConversorDeCaractere();
        public string letras;        
        public string resultado;

        public Teclado(string l)
        {
            letras = l;
            resultado = conversor.NumeroParaLetra(this);
        }
    }
}
