using System;

namespace Matematicas.FrameworkTest
{
    class Calculadora
    {
        public Calculadora()
        {
        }

        public int AumentarEntero(int numeroEntero1, int numeroEntero2, int esperado)
        {
            int sum = numeroEntero1;
            for (int i = 0; i < numeroEntero2; i++)
            {
                sum += 1;
            }
            return sum;

        }

        internal double RaizCuadrada(double numero1)
        {
            if (numero1<0)
                throw new ArgumentException("No se puede recibir numeros negativos");
            return Math.Sqrt(numero1);
        }

        internal double PaisEcuador(double regionCosta, double regionSierra, double regionAmazonica, double regionInsular)
        {
            
            if (regionCosta < 7)
            {
                throw new ArgumentException("No es el País del Ecuador");
            }
            // return regionCosta;


            if (regionSierra < 10)
            {
                throw new ArgumentException("No es el País del Ecuador");
            }
            // return regionSierra;


            if (regionAmazonica < 6)
            {
                throw new ArgumentException("No es el País del Ecuador");
                
            }
            // return regionAmazonica;

            if (regionInsular < 1) { 
            throw new ArgumentException("No es el País del Ecuador"); 
            }

            return regionCosta + regionInsular +regionAmazonica + regionSierra;


        }
    }
}