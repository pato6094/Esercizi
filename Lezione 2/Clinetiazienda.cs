namespace Lezione_2
{
    public class Clinetiazienda : Pgiuridica
    {

        private string _codcliente;


        public Clinetiazienda(string nome, string cf, string PIVA, string indirizzo, string codicecliente):base(nome,cf,PIVA,indirizzo) {
            _codcliente = codicecliente;


        }
    }



}

