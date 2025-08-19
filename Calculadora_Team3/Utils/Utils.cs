using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Team3.Utils { 
    public class UtilsClass
    {
        public static string realizarInteracao(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }
       

        public static double ValidarEntrada(string input)
        {
            if (double.TryParse(input, out double retorno))
            {
                return retorno;
            }
            else
            {
                throw new FormatException($"Não foi possível converter '{input}' para double.");
            }
        }

        public void BlocoPadraoTryCatch(Action codigo)
        {
            try
            {
                codigo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
