using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class ConversorDeCaractere
    {
        public List<string> dois = new List<string>(new string[] { "2", "22", "222" });
        public List<string> tres = new List<string>(new string[] { "3", "33", "333" });
        public List<string> quatro = new List<string>(new string[] { "4", "44", "444" }); 
        public List<string> cinco = new List<string>(new string[] { "5", "55", "555" });
        public List<string> seis = new List<string>(new string[] {"6", "66", "666" });
        public List<string> sete = new List<string>(new string[] { "7", "77", "777", "7777" });
        public List<string> oito = new List<string>(new string[] { "8", "88", "888" });
        public List<string> nove = new List<string>(new string[] { "9", "99", "999", "9999" });
        public string NumeroParaLetra(Teclado teclado)
        {
            string letras = teclado.letras.ToUpper();
            string resultado = teclado.resultado;
            char ultimoNumero;
            char proximoNumero;


            if(Validar(letras) == "valido")
            {
                for (int i = 0; i < letras.Length; i++)
                {

                    if (i > 0)
                    {
                        ultimoNumero = Escrever(letras, i - 1).Last<char>();
                        proximoNumero = Escrever(letras, i).First<char>();

                        if (ultimoNumero == proximoNumero)
                            resultado += "_";
                    }

                    resultado += Escrever(letras, i);
                }
            }

            else
            {
                resultado = Validar(letras);
            }
           

            return resultado;
            
        }

        private string Escrever(string letras, int i)
        {
            string resultado = null;

            if (letras[i] == 'A')
                resultado += dois[0];
            if (letras[i] == 'B')
                resultado += dois[1];
            if (letras[i] == 'C')
                resultado += dois[2];
            if (letras[i] == 'D')
                resultado += tres[0];
            if (letras[i] == 'E')
                resultado += tres[1];
            if (letras[i] == 'F')
                resultado += tres[2];
            if (letras[i] == 'G')
                resultado += quatro[0];
            if (letras[i] == 'H')
                resultado += quatro[1];
            if (letras[i] == 'I')
                resultado += quatro[2];
            if (letras[i] == 'J')
                resultado += cinco[0];
            if (letras[i] == 'K')
                resultado += cinco[1];
            if (letras[i] == 'L')
                resultado += cinco[2];
            if (letras[i] == 'M')
                resultado += seis[0];
            if (letras[i] == 'N')
                resultado += seis[1];
            if (letras[i] == 'O')
                resultado += seis[2];
            if (letras[i] == 'P')
                resultado += sete[0];
            if (letras[i] == 'Q')
                resultado += sete[1];
            if (letras[i] == 'R')
                resultado += sete[2];
            if (letras[i] == 'S')
                resultado += sete[3];
            if (letras[i] == 'T')
                resultado += oito[0];
            if (letras[i] == 'U')
                resultado += oito[1];
            if (letras[i] == 'V')
                resultado += oito[2];
            if (letras[i] == 'W')
                resultado += nove[0];
            if (letras[i] == 'X')
                resultado += nove[1];
            if (letras[i] == 'Y')
                resultado += nove[2];
            if (letras[i] == 'Z')
                resultado += nove[3];
            if (letras[i] == ' ')
                resultado += "0";
            return resultado;
        }


        public string Validar(string letras)
        {
            string valida = "valido";

            if(letras.Length > 255)
            {
                valida = "Quantidade de caracteres superior ao limite";
            }

            return valida;
        }
    }
}
