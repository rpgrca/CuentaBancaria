namespace CuentaBancaria
{
    public class Cajero
    {
        public decimal ConsultarSaldoDe(Cuenta cuenta) =>
            cuenta.ConsultarSaldo();

        public void DepositarEn(Cuenta cuenta, SumaDeDinero unaSumaDeDinero) =>
            cuenta.Depositar(unaSumaDeDinero);

        public void ExtraderDe(Cuenta cuenta, SumaDeDinero unaSumaDeDinero) =>
            cuenta.Extraer(unaSumaDeDinero);
    }
}