using System;

namespace oop
{
    public class CuentaCorriente
    {
        public decimal Saldo { get; private set; } = 0;

        public void Depositar(decimal unaCantidadDeDinero)
        {
            Saldo += unaCantidadDeDinero;
        }
    }
}