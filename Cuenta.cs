namespace oop
{
    public abstract class Cuenta
    {
        public const string NO_SE_PUEDE_DEPOSITAR_UNA_DEUDA = "No se puede depositar una cantidad negativa de dinero.";
        public const string NO_SE_PUEDE_EXTRAER_UNA_DEUDA = "No se puede extraer una cantidad negativa de dinero.";

        public Saldo Saldo { get; protected set; }

        public void Depositar(SumaDeDinero unaCantidadDeDinero) =>
            Saldo = Saldo.Agregar(unaCantidadDeDinero);

        public void Extraer(SumaDeDinero unaCantidadDeDinero) =>
            Saldo = Saldo.Sustraer(unaCantidadDeDinero);
    }
}