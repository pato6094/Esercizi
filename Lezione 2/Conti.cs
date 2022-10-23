namespace Lezione_2
{
    public class Conti{

        private int _numeroconto;
        private int _saldo;
        private string _iban;
        private int _debito;
        private string _codicefil;

        public Conti (int numeroconto, int saldo, string iban, int debito, string codicefil)
        {
            _numeroconto = numeroconto;
            _saldo = saldo;
            _iban = iban;
            _debito = debito;
            _codicefil = codicefil;
        }
    }

}

