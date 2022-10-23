namespace Lezione_2
{
    public class Clientefisico : Pfisica
    {
    
        private string _codcliente;


        public Clientefisico(string nome, string cognome, string cf, string Datanascita, string residenza,string codicecliente):base(nome,cognome,cf,Datanascita,residenza){

            _codcliente = codicecliente;


        }


    }




    

}

