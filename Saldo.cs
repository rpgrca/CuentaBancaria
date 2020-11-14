using System;

namespace CuentaBancaria
{
    public class Saldo
    {
        public const string TOTAL_NO_PUEDE_QUEDAR_POR_DEBAJO_DEL_MINIMO = "El total no puede quedar por debajo del mínimo.";

        private readonly Action _errorCallback;
        public decimal Total { get; }
        private decimal Minimo { get; }

        private Saldo(decimal minimo, decimal valorInicial, Action errorCallback)
        {
            if (valorInicial < minimo) errorCallback?.Invoke();

            Minimo = minimo;
            Total = valorInicial;
            _errorCallback = errorCallback;
        }

        public static Saldo DeMasDe(decimal minimo, decimal valorInicial, Action errorCallback) =>
            new Saldo(minimo, valorInicial, errorCallback);

        public Saldo Agregar(SumaDeDinero sumaDeDinero) =>
            DeMasDe(Minimo, Total + sumaDeDinero.Total, _errorCallback);

        public Saldo Sustraer(SumaDeDinero sumaDeDinero) =>
            DeMasDe(Minimo, Total - sumaDeDinero.Total, _errorCallback);
    }
}