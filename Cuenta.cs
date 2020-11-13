namespace oop
{
    public abstract class Cuenta
    {
        public abstract decimal Saldo { get; protected set; }
        public abstract void Depositar(decimal unaCantidadDeDinero);
        public abstract void Extraer(decimal unaCantidadDeDinero);
    }
}