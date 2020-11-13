using System;

namespace oop
{
    public abstract class Cuenta
    {
        public const string NO_SE_PUEDE_DEPOSITAR_UNA_DEUDA = "No se puede depositar una cantidad negativa de dinero.";
        public const string NO_SE_PUEDE_EXTRAER_UNA_DEUDA = "No se puede extraer una cantidad negativa de dinero.";

        public decimal Saldo { get; protected set; } = 0;

        public void Depositar(SumaDeDinero unaCantidadDeDinero)
        {
            Saldo += unaCantidadDeDinero.Total;
        }

        public void Extraer(SumaDeDinero unaCantidadDeDinero)
        {
            TieneSaldoParaExtraer(unaCantidadDeDinero);

            Saldo -= unaCantidadDeDinero.Total;
        }

        protected abstract void TieneSaldoParaExtraer(SumaDeDinero unaCantidadDeDinero);
    }
}