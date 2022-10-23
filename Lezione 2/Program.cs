using System;

namespace Lezione_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Analyst Matteo = new Analyst("Matteo", "Verdi", "MMTTSVV29290", "M", "01/09/2001", "ANALYST", "Sposato", 3);
            Console.WriteLine(Matteo._name + " " + Matteo._cognome + " " + Matteo.CF + " " + Matteo._sesso + " " + Matteo.Datanascita + " " + Matteo._mansione + " " + Matteo.Statosociale+" "+Matteo.Grado);
            /* Banca banca = new Banca("Intesa SanPaolo","Via Roma 13",5,"IT34980201",12,200000);
            Console.WriteLine(banca._name + "  " + banca._indirizzo + " " + banca._numerofiliale+ " "+banca._piva+" "+banca._numerodip+" "+banca._capitalesociale ) ;

            Personale personale = new Personale("Matteo", "Rossi", "MTTRR39120CNZX", "M", "01/02/1998", "Servizio Clienti", "Sposato");
            Console.WriteLine(personale._name + " " + personale._cognome + " " + personale._cf + " " + personale._sesso + " " + personale._datanascita + " " + personale._mansione + " " + personale._statosociale);

            Conti conti = new Conti(153, 1000, "IT490284323948023", 399, "ISP3902343");
            Console.WriteLine(conti._codicefil + " " + conti._saldo + " " + conti._iban + " " + conti._debito + " " + conti._codicefil);

            Carta carta = new Carta(52444890280120, "12/23", "01/21", 456);
            Console.WriteLine(carta._numerocarta + " "+carta._datas + " " + carta._datae + " " + carta._cvv);

            ATM atm = new ATM(4890239.56, "Via Ottaviano 12", "Coordinate: 40 50 N 14 15 E", 143);
            Console.WriteLine(atm._saldodisponibile + " " + atm._indirizzo + " "+atm._gps+" "+atm._id);

            Pgiuridica pgiuridica = new Pgiuridica("Armani SRLS", "ARM329090CV39", "IT3490248392", "Via Giorgio 13");
            Console.WriteLine(pgiuridica._name + " " + pgiuridica._cf + " " + pgiuridica._piva + " " + pgiuridica._indirizzo);

            Pfisica pfisica = new Pfisica("Alessio", "Bianchi", "ASSBNI3290183V9", "10/01/1998", "Via Armando Diaz 199");
            Console.WriteLine(pfisica._name+" "+pfisica._cognome+" "+pfisica._cf+" "+pfisica._datanascita+" "+pfisica._residenza);

            Clinetiazienda clinetiazienda = new Clinetiazienda("Armani SRLS", "ARM329090CV39", "IT3490248392", "Via Giorgio 13","Codice Cliente: A032894");
            Console.WriteLine(clinetiazienda._codcliente+" "+clinetiazienda._name);

            Clientefisico clientefisico = new Clientefisico("Alessio", "Bianchi", "ASSBNI3290183V9", "10/01/1998", "Via Armando Diaz 199" ,"Codice Cliente: B0949039");
            Console.WriteLine(clientefisico._codcliente+" "+clientefisico._name+" "+clientefisico._cognome+" "+clientefisico._cf+" "+clientefisico._residenza+" "+clientefisico._codcliente);
           */
        }
    }

}

