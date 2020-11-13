using System;

namespace oop
{
    public class SumaDeDinero
    {
        public const string NO_SE_PUEDE_CREAR_UNA_SUMA_DE_DINERO_NEGATIVA = "No se puede crear una suma de dinero negativa.";

        public decimal Total { get; }

        private SumaDeDinero(decimal sumaDeDinero)
        {
            if (sumaDeDinero < 0) throw new ArgumentException(NO_SE_PUEDE_CREAR_UNA_SUMA_DE_DINERO_NEGATIVA);
            Total = sumaDeDinero;
        }

        public static SumaDeDinero De(decimal sumaDeDinero) =>
            new SumaDeDinero(sumaDeDinero);
    }
}