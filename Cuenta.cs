namespace oop
{
    public abstract class Cuenta
    {
        public decimal Saldo { get; protected set; } = 0;
        public abstract void Depositar(decimal unaCantidadDeDinero);
        public abstract void Extraer(decimal unaCantidadDeDinero);
    }
}