namespace CuentaBancaria
{
    public abstract class Cuenta
    {
        protected Saldo Saldo { get; set; }

        public void Depositar(SumaDeDinero unaCantidadDeDinero) =>
            Saldo = Saldo.Agregar(unaCantidadDeDinero);

        public void Extraer(SumaDeDinero unaCantidadDeDinero) =>
            Saldo = Saldo.Sustraer(unaCantidadDeDinero);

        public decimal ConsultarSaldo() => Saldo.Total;
    }
}