namespace Lezione_2
{
    public class Analyst : Personale
    {
        private int _grado;
        public Analyst (string name, string cognome, string cf, string sesso, string datanascita, string mansione, string statosociale, int grado) : base(name, cognome, cf, sesso, datanascita, mansione, statosociale)
        {
            _name = name;
            _cognome = cognome;
            CF = cf;
            _sesso = sesso;
           Datanascita = datanascita;
            _mansione = mansione;
            Statosociale = statosociale;
            _grado = grado;

        }


            
        public int Grado { 
            get 
            {
                return _grado; 
            } 
            set { 
                _grado = value; 
            } 
        }

    }

}

