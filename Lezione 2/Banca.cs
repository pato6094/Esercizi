namespace Lezione_2
{
    public class Banca{
        public string _name;
        public string _indirizzo;
        public int _numerofiliale;
        public string _piva;
        public int _numerodip;
        public int _capitalesociale;

        public Banca(string Name, string Indirizzo, int Numerofiliale, string Piva,int Numerodip, int Capitalesociale)
        {
            _name = Name;
            _indirizzo = Indirizzo;
            _numerofiliale = Numerofiliale;
            _piva = Piva;   
            _numerodip = Numerodip;
            _capitalesociale = Capitalesociale;  

        }    
        
    }
}

