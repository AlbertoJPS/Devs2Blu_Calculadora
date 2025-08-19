using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Team3.Utils
{
    internal class Utils
    {
        public static bool ValidarEntrada(string input, out double result)
        {
            return double.TryParse(input, out result);
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
