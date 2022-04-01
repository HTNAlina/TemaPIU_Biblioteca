using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Persoana
    {

        //Proprietati auto-implemented 
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public int NrCartiImprumutate { get; set; }
        public string NrTelefon { get; set; }
        public string AdresaMail { get; set; }
        public string NumeComplet { get { return Nume + " " + Prenume; } }

        const int NrMaxCarti = 5;

        STATUT statut;

        //Constructor fara parametrii
        public Persoana()
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            Varsta = 0;
            NrCartiImprumutate = 0;
            NrTelefon = string.Empty;
            AdresaMail = string.Empty;
            statut = STATUT.Elev;
        }
        //Constructor cu parametrii
        public Persoana(string _nume, string _prenume, int _varsta, int _NrCartiImprumutate, string _NrTelefon, string _AdresaMail, int _statut)
        {
            Nume = _nume;
            Prenume = _prenume;
            Varsta = _varsta;
            NrCartiImprumutate = _NrCartiImprumutate;
            NrTelefon = _NrTelefon;
            AdresaMail = _AdresaMail;
            statut = (STATUT)_statut;
        }

        //Constructor care primeste un sir unde elementele sunt despartite de ','
        public Persoana(string sirr)
        {
            string[] buff = sirr.Split(',');
            Nume = buff[0];
            Prenume = buff[1];
            Varsta = Convert.ToInt32(buff[2]);
            NrCartiImprumutate = Convert.ToInt32(buff[3]);
            NrTelefon = buff[4];
            AdresaMail = buff[5];
            int _statut = Convert.ToInt32(buff[6]);
            statut = (STATUT)_statut;
        }

        //Citire din linia de comanda
        public Persoana(string []buff)
        {
            Nume = buff[0];
            Prenume = buff[1];
            Varsta = Convert.ToInt32(buff[2]);
            NrCartiImprumutate = Convert.ToInt32(buff[3]);
            NrTelefon = buff[4];
            AdresaMail = buff[5];
            int _statut = Convert.ToInt32(buff[6]);
            statut = (STATUT)_statut;
        }

        //Afisare info persoana
        public string InfoPersoana()
        {
            return string.Format("{0} {1} are varsta {2} de ani, este {6}, numarul de telefon este{3}, adresa de mail este {4} si a imprumutat {5} carti", Nume, Prenume, Varsta, NrTelefon, AdresaMail, NrCartiImprumutate, statut);
        }

    }
}