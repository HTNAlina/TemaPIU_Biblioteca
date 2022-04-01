using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte
    {
        public string Nume { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        GENCARTE GenCarte;
        int AnAparitie;
        public int NrExemplare { get; set; }
        int IDcarte;

        //Constructor fara parametrii
        public Carte()
        {
            Nume = string.Empty;
            Autor = string.Empty;
            Editura = string.Empty;
            GenCarte = GENCARTE.Copii;
            AnAparitie = 0;
            NrExemplare = 0;
            IDcarte = 0;
        }
        //Constructor cu parametrii
        public Carte(string _nume, string _autor, string _editura, int _AnAparitie, int _NrExemplare, int _id, int n)
        {
            Nume = _nume;
            Autor = _autor;
            Editura = _editura;
            AnAparitie = _AnAparitie;
            NrExemplare = _NrExemplare;
            IDcarte = _id;
            GenCarte = (GENCARTE)(n);
        }
        //Constructor care primeste un sir unde elementele sunt despartite de ','
        public Carte(string sirr)
        {
            string[] buff = sirr.Split(',');
            Nume = buff[0];
            Autor = buff[1];
            Editura = buff[2];
            AnAparitie = Convert.ToInt32(buff[3]);
            NrExemplare = Convert.ToInt32(buff[4]);
            IDcarte = Convert.ToInt32(buff[5]);
            int i = Convert.ToInt32(buff[6]);
            GenCarte = (GENCARTE)(i);
        }

        public string Info()
        {
            return string.Format("Cartea cu numele {0}, scrisa de {1}, publicata la editura {2}, a aparut in anul {3} si o avem disponibila in {4} exemplare ( are ID-ul : {5}).", Nume, Autor, Editura, AnAparitie, NrExemplare, IDcarte);
        }
    }
}
