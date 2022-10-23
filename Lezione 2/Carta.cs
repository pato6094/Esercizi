namespace Lezione_2
{
    public class Carta
    {
        public long _numerocarta;
        public string _datas;
        public string _datae;
        private int _cvv;

        public Carta(long numerocarta, string datascadenza, string dataemissione, int cvv)
        {
            _numerocarta = numerocarta;
            _datas = datascadenza;
            _datae = dataemissione;
            _cvv = cvv;


        }
    }

    
         
}

