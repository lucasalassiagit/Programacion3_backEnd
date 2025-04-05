using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1_Programacion3
{
    public static class Validaciones
    {
        public static bool EsCUITValido(string cuit)

        {

            cuit = cuit.Replace("-", "").Trim();



            if (cuit.Length != 11 || !long.TryParse(cuit, out _))

                return false;



            int[] mult = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

            int total = 0;



            for (int i = 0; i < mult.Length; i++)

                total += int.Parse(cuit[i].ToString()) * mult[i];



            int resto = total % 11;

            int digitoVerificador = resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;



            return digitoVerificador == int.Parse(cuit[10].ToString());

        }
    }
}
