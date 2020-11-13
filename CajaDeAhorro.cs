using System;

namespace oop
{
    public class CajaDeAhorro
    {
        public decimal Saldo { get; private set; } = 0;

        public void Depositar(decimal unaCantidadDeDinero)
        {
            Saldo += unaCantidadDeDinero;
        }

        public void Extraer(decimal unaCantidadDeDinero)
        {
            Saldo -= unaCantidadDeDinero;
        }
    }
}