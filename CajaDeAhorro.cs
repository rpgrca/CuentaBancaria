using System;

namespace oop
{
    public class CajaDeAhorro : Cuenta
    {
        public const string NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO = "No se puede extraer más dinero que el saldo existente.";
        public const string NO_SE_PUEDE_DEPOSITAR_UNA_DEUDA = "No se puede depositar una cantidad negativa de dinero.";
        public const string NO_SE_PUEDE_EXTRAER_UNA_DEUDA = "No se puede extraer una cantidad negativa de dinero.";

        public override decimal Saldo { get; protected set; } = 0;

        public override void Depositar(decimal unaCantidadDeDinero)
        {
            if (unaCantidadDeDinero < 0)
            {
                throw new ArgumentException(NO_SE_PUEDE_DEPOSITAR_UNA_DEUDA);
            }

            Saldo += unaCantidadDeDinero;
        }

        public override void Extraer(decimal unaCantidadDeDinero)
        {
            if (unaCantidadDeDinero < 0) throw new ArgumentException(NO_SE_PUEDE_EXTRAER_UNA_DEUDA);
            if (Saldo < unaCantidadDeDinero) throw new ArgumentException(NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO);

            Saldo -= unaCantidadDeDinero;
        }
    }
}