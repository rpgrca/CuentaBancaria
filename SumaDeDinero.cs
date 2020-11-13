namespace oop
{
    public class SumaDeDinero
    {
        public decimal Total { get; }

        private SumaDeDinero(decimal sumaDeDinero) =>
            Total = sumaDeDinero;

        public static SumaDeDinero De(decimal sumaDeDinero)
        {
            return new SumaDeDinero(sumaDeDinero);
        }
    }
}