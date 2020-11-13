namespace oop
{
    public class Cajero
    {
        public decimal ConsultarSaldoDe(CajaDeAhorro cajaDeAhorro)
        {
            return cajaDeAhorro.Saldo;
        }

        public void DepositarEn(CajaDeAhorro cajaDeAhorro, decimal unaSumaDeDinero)
        {
            cajaDeAhorro.Depositar(unaSumaDeDinero);
        }

        public void ExtraderDe(CajaDeAhorro cajaDeAhorro, decimal unaSumaDeDinero)
        {
            cajaDeAhorro.Extraer(unaSumaDeDinero);
        }
    }
}