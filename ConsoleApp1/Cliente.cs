namespace ConsoleApp1
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string apellido { get; set; }
        public double Efectivo { get; set; }
        public double saldo { get; set; }
        public int cbu { get; set; } = 0;

        public Cuenta Cuenta { get; set; }
        public Cliente()
        {
            Cuenta = new Cuenta();
            Efectivo = 0;
            saldo = 0;
        }
        public void Acreditar(double monto)
        {
            saldo = saldo + monto * 0.8;
            Cuenta.Acreditar(monto * 0.2);
        }
        public void Debitar()
    }
}
