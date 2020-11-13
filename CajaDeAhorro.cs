using System;

namespace oop
{
    public class CajaDeAhorro
    {
        public const string NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO = "No se puede extraer más dinero que el saldo existente.";

        public decimal Saldo { get; private set; } = 0;

        public void Depositar(decimal unaCantidadDeDinero)
        {
            Saldo += unaCantidadDeDinero;
        }

        public void Extraer(decimal unaCantidadDeDinero)
        {
            if (Saldo < unaCantidadDeDinero) throw new ArgumentException(NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO);

            Saldo -= unaCantidadDeDinero;
        }
    }
}