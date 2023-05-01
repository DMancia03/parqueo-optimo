using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_de_parqueo.Clases
{
    internal class Encriptar

    {
        private const string Pattern = "^\\d{8}-\\d$";

        public Boolean verificarDui(String dui)
        {
            Boolean resultado = false;
            if (string.IsNullOrWhiteSpace(dui)) {
                resultado = false;
                return resultado;
            }
            else
            {
                try
                {
                    if (Regex.IsMatch(dui,Pattern))
                    {
                        resultado = true;

                    }
                    else
                    {
                        resultado= false;
                    }

                }
                catch (Exception)
                {

                    resultado = false;
                }
            }
           
            return resultado;
        }
    }
}
