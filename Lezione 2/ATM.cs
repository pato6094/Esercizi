namespace Lezione_2
{
    public class ATM{

        private double _saldodisponibile;
        public string _indirizzo;
        private string _gps;
        private int _id;

        public ATM(double saldo, string indirizzo, string gps, int id)
        {
            _saldodisponibile = saldo;
            _indirizzo = indirizzo;
            _gps = gps;
            _id = id;
                
        }
    }

   


}

