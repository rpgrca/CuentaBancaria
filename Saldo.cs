using System;

namespace oop
{
    public class Saldo
    {
        public const string TOTAL_NO_PUEDE_QUEDAR_POR_DEBAJO_DEL_MINIMO = "El total no puede quedar por debajo del mínimo.";

        public decimal Total { get; }
        private decimal Minimo { get; }

        private Saldo(decimal minimo, decimal valorInicial)
        {
            Minimo = minimo;
            Total = valorInicial;
        }

        public static Saldo DeMasDe(decimal minimo, decimal valorInicial = 0)
        {
            if (valorInicial < minimo) throw new ArgumentException(TOTAL_NO_PUEDE_QUEDAR_POR_DEBAJO_DEL_MINIMO);
            return new Saldo(minimo, valorInicial);
        }

        public Saldo Agregar(SumaDeDinero sumaDeDinero) =>
            DeMasDe(Minimo, Total + sumaDeDinero.Total);

        public bool Es(decimal valor) => Total == valor;

        public Saldo Sustraer(SumaDeDinero sumaDeDinero) =>
            DeMasDe(Minimo, Total - sumaDeDinero.Total);
    }
}