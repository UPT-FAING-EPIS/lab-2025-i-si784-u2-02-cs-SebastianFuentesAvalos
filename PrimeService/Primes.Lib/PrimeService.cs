using System;

namespace Primes.Lib
{
    /// <summary>
    /// Proporciona métodos relacionados con la verificación de números primos.
    /// </summary>
    public class PrimeService
    {
        /// <summary>
        /// Determina si el número proporcionado es un número primo.
        /// </summary>
        /// <param name="candidate">Número entero a evaluar.</param>
        /// <returns>
        /// Devuelve <c>true</c> si el número es primo; de lo contrario, <c>false</c>.
        /// </returns>
        public bool IsPrime(int candidate)
        {
            if (candidate < 2) return false;

            for (int i = 2; i <= Math.Sqrt(candidate); i++)
            {
                if (candidate % i == 0)
                    return false;
            }

            return true;
        }
    }
}
