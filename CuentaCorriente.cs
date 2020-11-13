using System;

namespace oop
{
    public class CuentaCorriente : Cuenta
    {
        public const string NO_SE_PUEDE_EXTRAER_MAS_ALLA_DEL_LIMITE = "No se puede extraer más allá del límite negativo.";

        public override void Extraer(decimal unaCantidadDeDinero)
        {
            if (unaCantidadDeDinero < 0) throw new ArgumentException(CajaDeAhorro.NO_SE_PUEDE_EXTRAER_UNA_DEUDA);
            if (Saldo - unaCantidadDeDinero <= -1000) throw new ArgumentException(NO_SE_PUEDE_EXTRAER_MAS_ALLA_DEL_LIMITE);

            Saldo -= unaCantidadDeDinero;
        }
    }
}