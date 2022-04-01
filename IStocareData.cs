using System;
using System.Collections.Generic;
using System.IO;

namespace Biblioteca
{
    public class IStocareData
    {

        Carte[] carti = new Carte[50];
        int nrCarti = 0;
        Persoana[] persoane = new Persoana[50];
        int nrPersoane = 0;
        int ok = 1;
        public void citireCartiFisier(string fileName)
        {
            StreamReader s = new StreamReader(fileName);
            String line = "";
            while((line = s.ReadLine())!= null)
            {
                string[] p = line.Split(',');
                this.carti[nrCarti] = new Carte(p[0], p[1], p[2], Convert.ToInt32(p[3]), Convert.ToInt32(p[4]), Convert.ToInt32(p[5]), Convert.ToInt32(p[6]));
                nrCarti += 1;
            }
        }

        public void citirePersoaneFisier(string fileName)
        {
            StreamReader s = new StreamReader(fileName);
            String line = "";
            while ((line = s.ReadLine()) != null)
            {
                string[] p = line.Split(',');
                this.persoane[nrPersoane] = new Persoana(p[0], p[1], Convert.ToInt32(p[2]), Convert.ToInt32(p[3]), p[4], p[5], Convert.ToInt32(p[6]));
                nrPersoane += 1;
            }
        }

        public void scriereFisierCarti(string fileName)
        {
            StreamWriter s = new StreamWriter(fileName);
            for(int i = 0; i < nrCarti; i++)
            {
                s.WriteLine(i+1 + ". " + carti[i].Info());
            }
            s.Close();
        }
        public void scriereFisierPersoane(string fileName)
        {
            StreamWriter s = new StreamWriter(fileName);
            for (int i = 0; i < nrPersoane; i++)
            {
                s.WriteLine(i + 1 + ". " + persoane[i].InfoPersoana());
            }
            s.Close();
        }

        public void cautareDupaTitlu(string Nume)
        {
            foreach(Carte c in carti)
            {
                if (c.Nume == Nume)
                {
                    Console.WriteLine(c.Info());
                }
            }
            if (ok == 0) 
                Console.WriteLine("Nu exista cartea cu acest titlu");
        }

        public void cautareDupaNume(string Nume)
        {
            foreach(Persoana p in persoane)
            {
                if (p.Nume == Nume)
                {
                    Console.WriteLine(p.InfoPersoana());
                }
            }
            if (ok == 0)
            {
                Console.WriteLine("Nu exista persoana cu acest nume");
            }
        }
    }
}