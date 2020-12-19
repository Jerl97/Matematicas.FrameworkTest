using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matematicas.FrameworkTest
{
    [TestClass]
    public class UnitTest1
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        // [DataRow(2, -3, -1)]
        // [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
        // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        // @"|C:\Data|\data\data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void AumentarEntero(int numeroEntero1, int numeroEntero2, int esperado)
        {
            // var numeroEntero1 = Convert.ToInt32(TestContext.DataRow["PrimerNumero"]);
            // var numeroEntero2 = Convert.ToInt32(TestContext.DataRow["SegundoNumero"]);
            // var esperado = Convert.ToInt32(TestContext.DataRow["ResultadoSuma"]);

            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEntero(numeroEntero1, numeroEntero2, esperado);

            Assert.AreEqual(esperado, resultado, "numeroEntero1:<{0}> numeroEntero2:<{1}>",
            new object[] { numeroEntero1, numeroEntero2 });


            }

        // [TestMethod]
        // [DeploymentItem("\Data\\\data.csv")]
        // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //  @"|DataDirectory|\Data\data.csv", "data#csv", DataAccessMethod.Sequential),
        //  DeploymentItem("data.csv")]

        //public void AnadirEntero()
        // {
            // var numeroEntero1 = Convert.ToInt32(TestContext.DataRow["PrimerNumero"]);
            // var numeroEntero2 = Convert.ToInt32(TestContext.DataRow["SegundoNumero"]);
            // var esperado = Convert.ToInt32(TestContext.DataRow["ResultadoSuma"]);

            // var calculadora = new Calculadora();
            // int resultado = calculadora.AumentarEntero(numeroEntero1, numeroEntero2);

            // Assert.AreEqual(esperado, resultado);

        // }

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroPositivoObtengoPositivo()
        {
            var numero1 = 25;
            var esperado = 5;

            var calculadora = new Calculadora();
            var resultado = calculadora.RaizCuadrada(numero1);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroNegativo()
        {
            var numero1 = -25;
     
            var calculadora = new Calculadora();
            
            Assert.ThrowsException<ArgumentException>(()=> calculadora.RaizCuadrada(numero1));
        }

        [TestMethod]
        public void RegionesDelEcuador()
        {
            var regionCosta = 7;
            var regionSierra = 10;
            var regionAmazonica = 6;
            var regionInsular = 1;
            var esperado = 24;

            var calculadora = new Calculadora();
            var resultado = calculadora.PaisEcuador(regionCosta,regionSierra,regionAmazonica,regionInsular);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void NoEsElEcuador()
        {
            var regionCosta = 6;
            var regionSierra = 9;
            var regionAmazonica = 7;
            var regionInsular = -1;

            var calculadora = new Calculadora();

            Assert.ThrowsException<ArgumentException>(() => calculadora.PaisEcuador(regionCosta, regionSierra, regionAmazonica, regionInsular));
        }


    }
}