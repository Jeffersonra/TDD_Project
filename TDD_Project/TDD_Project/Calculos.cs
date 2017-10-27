using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Project
{
    public class Calculos
    {
        private int resultado;

        public int Somar(int n1, int n2)
        {
            try
            {
                resultado = n1 + n2 -2;

                return resultado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
