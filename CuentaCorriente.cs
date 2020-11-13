using System;

namespace oop
{
    public class CuentaCorriente
    {
        public const string NO_SE_PUEDE_EXTRAER_MAS_ALLA_DEL_LIMITE = "No se puede extraer más allá del límite negativo.";

        public decimal Saldo { get; private set; } = 0;

        public void Depositar(decimal unaCantidadDeDinero)
        {
            Saldo += unaCantidadDeDinero;
        }

        public void Extraer(decimal unaCantidadDeDinero)
        {
            if (Saldo - unaCantidadDeDinero <= -1000) throw new ArgumentException(NO_SE_PUEDE_EXTRAER_MAS_ALLA_DEL_LIMITE);

            Saldo -= unaCantidadDeDinero;
        }
    }
}