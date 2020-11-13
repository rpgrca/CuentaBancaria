namespace oop
{
    public class Cajero
    {
        public decimal ConsultarSaldoDe(Cuenta cuenta) =>
            cuenta.Saldo;

        public void DepositarEn(Cuenta cuenta, SumaDeDinero unaSumaDeDinero) =>
            cuenta.Depositar(unaSumaDeDinero);

        public void ExtraderDe(Cuenta cuenta, SumaDeDinero unaSumaDeDinero) =>
            cuenta.Extraer(unaSumaDeDinero);
    }
}