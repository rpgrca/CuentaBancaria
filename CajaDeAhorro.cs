using System;

namespace oop
{
    public class CajaDeAhorro : Cuenta
    {
        public const string NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO = "No se puede extraer más dinero que el saldo existente.";

        protected override void TieneSaldoParaExtraer(decimal unaCantidadDeDinero)
        {
            if (Saldo < unaCantidadDeDinero) throw new ArgumentException(NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO);
        }
    }
}