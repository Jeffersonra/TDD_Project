using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Project;

namespace UnitTestTDD_Project
{
    [TestClass]
    public class ValidaCalculos
    {
        public int n1;
        public int n2;
        public int resultado;
        public int resultadoEsperado;

        [TestMethod]
        public void ValidaSoma()
        {
            Random random = new Random();
            try
            {
                n1 = random.Next(0, 1000000);
                n2 = random.Next(0, 1000000);

                resultado = n1 + n2;

                Calculos calcula = new Calculos();

                resultadoEsperado = calcula.Somar(n1,n2);

                Assert.IsTrue(resultado == resultadoEsperado);
            }
            catch
            {
                Assert.Fail();
            }
            
        }
    }
}
