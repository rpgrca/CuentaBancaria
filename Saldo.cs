using System;

namespace oop
{
    public class Saldo
    {
        public const string TOTAL_NO_PUEDE_QUEDAR_POR_DEBAJO_DEL_MINIMO = "El total no puede quedar por debajo del mínimo.";

        private readonly Action errorCallback;
        public decimal Total { get; }
        private decimal Minimo { get; }

        private Saldo(decimal minimo, decimal valorInicial, Action errorCallback)
        {
            Minimo = minimo;
            Total = valorInicial;
            this.errorCallback = errorCallback;
        }

        public static Saldo DeMasDe(decimal minimo, decimal valorInicial, Action errorCallback)
        {
            if (valorInicial < minimo) errorCallback?.Invoke();
            return new Saldo(minimo, valorInicial, errorCallback);
        }

        public Saldo Agregar(SumaDeDinero sumaDeDinero) =>
            DeMasDe(Minimo, Total + sumaDeDinero.Total, errorCallback);

        public bool Es(decimal valor) => Total == valor;

        public Saldo Sustraer(SumaDeDinero sumaDeDinero) =>
            DeMasDe(Minimo, Total - sumaDeDinero.Total, errorCallback);
    }
}