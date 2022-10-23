using System.Globalization;

namespace Lezione_2
{
    public class Pgiuridica
    {

        private string _name;
        private string _cf;
        private string _piva;
        private string _indirizzo;


        public Pgiuridica (string nome, string cf, string PIVA, string indirizzo)
        {
            _name = nome;
            _cf = cf;
            _piva = PIVA;
            _indirizzo = indirizzo;

        }

    }

}

