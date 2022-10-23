namespace Lezione_2
{
    public class Pulizie : Personale
    {
        private int _codice;
        internal int _numcomp;

        public Pulizie(string name, string cognome, string cf, string sesso, string datanascita, string mansione, string statosociale,int codice, int numcomp):base(name, cognome, cf, sesso, datanascita, mansione, statosociale)
        {

            _name = name;
            _cognome = cognome;
            CF = cf;
            _sesso = sesso;
            Datanascita = datanascita;
            _mansione = mansione;
            Statosociale = statosociale;
            _codice = codice;
            _numcomp = numcomp;

       
        }

        public int Codice
        {
            get { 
                return _codice; 
            }
            set { 
                
                _codice = value; 
            
            }

        }
    }

}

