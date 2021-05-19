namespace ConsoleApp1
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Efectivo { get; private set; }
        public double Saldo => Efectivo+Cuenta.Saldo;
        public int Cbu => Cuenta.Cbu;

        public Cuenta Cuenta { get; set; }
        public Cliente()
        {
            Cuenta = new Cuenta();
            Efectivo = 0;
        }
        public void Acreditar(double monto)
        {
            Efectivo = Saldo + monto * 0.8;
            Cuenta.Acreditar(monto * 0.2);
        }
        public void Debitar(double monto)
        {
            Efectivo = Saldo - monto * 0.8;
            Cuenta.Debitar(monto * 0.2);
        }
        public bool TieneAlMenos(double monto) => Saldo >= monto;
    }
}
