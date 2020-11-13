using System;

namespace oop
{
    public abstract class Cuenta
    {
        public const string NO_SE_PUEDE_DEPOSITAR_UNA_DEUDA = "No se puede depositar una cantidad negativa de dinero.";

        public decimal Saldo { get; protected set; } = 0;

        public void Depositar(decimal unaCantidadDeDinero)
        {
            if (unaCantidadDeDinero < 0) throw new ArgumentException(NO_SE_PUEDE_DEPOSITAR_UNA_DEUDA);

            Saldo += unaCantidadDeDinero;
        }

        public abstract void Extraer(decimal unaCantidadDeDinero);
    }
}