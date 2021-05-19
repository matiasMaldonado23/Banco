﻿namespace ConsoleApp1
{
    class Cuenta
    {
        private int Contador { get; set; } = 0;
        public int Cbu { get; set; }
        public double Saldo { get; set; }

        public Cuenta()
        {
            Cbu = ++Contador;
            Saldo = 0;
        }
        public void Acreditar(double monto) => Saldo += monto;
        public void Debitar(double monto) => Saldo -= monto;
    }
}
