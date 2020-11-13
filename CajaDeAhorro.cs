using System;

namespace oop
{
    public class CajaDeAhorro : Cuenta
    {
        public const string NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO = "No se puede extraer más dinero que el saldo existente.";

        public CajaDeAhorro() =>
            Saldo = Saldo.DeMasDe(0, 0, () => throw new ArgumentException(NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO));
    }
}