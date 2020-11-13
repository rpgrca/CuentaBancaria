using System;

namespace oop
{
    public class CuentaCorriente : Cuenta
    {
        public const string NO_SE_PUEDE_EXTRAER_MAS_ALLA_DEL_LIMITE = "No se puede extraer más allá del límite negativo.";

        public CuentaCorriente() =>
            Saldo = Saldo.DeMasDe(-1000, 0, () => throw new ArgumentException(NO_SE_PUEDE_EXTRAER_MAS_ALLA_DEL_LIMITE));
    }
}