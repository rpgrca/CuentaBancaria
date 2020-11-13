namespace oop
{
    public class Cajero
    {
        public decimal ConsultarSaldoDe(Cuenta cuenta) =>
            cuenta.Saldo;

        public void DepositarEn(Cuenta cuenta, decimal unaSumaDeDinero) =>
            cuenta.Depositar(unaSumaDeDinero);

        public void ExtraderDe(Cuenta cuenta, decimal unaSumaDeDinero) =>
            cuenta.Extraer(unaSumaDeDinero);
    }
}