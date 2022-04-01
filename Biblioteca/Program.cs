using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Carte c1 = new Carte("Mandrie si Prejudecata", "Jane Austin", "Corint", 2014, 3, 132, 3);
            string s1 = c1.Info();
            Console.WriteLine(s1);

            Carte c2 = new Carte("Marele Gatsby","F. Scott Fitzgerald","HUMANITAS",2018,2, 345 ,5);
            string s2 = c2.Info();
            Console.WriteLine(s2);

            Persoana p1 = new Persoana("Hutan", "Alina", 22, 0, "0744", "alinahutan@email.com", 2);
            string s3 = p1.InfoPersoana();
            Console.WriteLine(s3);

            Persoana p2 = new Persoana("Hutan", "Ioana", 20, 4, "09384","hutanioana@gmail.ro",2);
            string s4 = p2.InfoPersoana();
            Console.WriteLine(s4);

            //CITIRE TASTATURA
            Persoana p3 = CitirePersoanaTastatura();
            Carte c3 = CitireCarteTastatura();

            string s5 = p3.InfoPersoana();
            Console.WriteLine(s5);

            string s6 = c3.Info();
            Console.WriteLine(s6);*/

           /* IStocareData i = new IStocareData();
            i.citireCartiFisier("C:\\Users\\blasc\\Desktop\\Biblioteca-Lab2\\Biblioteca\\carti.txt");
            i.scriereFisierCarti("C:\\Users\\blasc\\Desktop\\Biblioteca-Lab2\\Biblioteca\\cartiOut.txt");
            i.citirePersoaneFisier("C:\\Users\\blasc\\Desktop\\Biblioteca-Lab2\\Biblioteca\\persoane.txt");
            i.scriereFisierPersoane("C:\\Users\\blasc\\Desktop\\Biblioteca-Lab2\\Biblioteca\\persoaneOut.txt");*/

            bool gasit;
            for (int i = 65; i < 91; i++)
            {
                gasit = false;

                char a, b;
                for (int j = 0; j < args.Length; j++)
                {
                    b = Convert.ToChar(i);
                    a = args[j].First();
                    //Console.WriteLine("{0},{1}", a, b);
                    if (a == b || a == b + 32)
                    {
                        Console.Write(args[j] + " ");
                        gasit = true;
                    }

                }
                if (gasit == true)
                {
                    Console.WriteLine();
                }
            }
        }

        public static Persoana CitirePersoanaTastatura()
        {
            Console.WriteLine("Numele persoanei: ");
            string nume = Console.ReadLine();
            Console.WriteLine("Prenumele persoanei: ");
            string prenume = Console.ReadLine();
            Console.WriteLine("Varsta persoanei: ");
            int varsta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numar carti imprumutate: ");
            int NrCartiImprumutate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numarul de telefon: ");
            string NrTelefon = Console.ReadLine();
            Console.WriteLine("Adresa de mail: ");
            string AdresaMail = Console.ReadLine();
            Console.WriteLine("Statutul persoanei: ");
            int st = Convert.ToInt32(Console.ReadLine());
            Persoana p = new Persoana(nume, prenume, varsta, NrCartiImprumutate, NrTelefon, AdresaMail, st);
            return p;
        }

        public static Carte CitireCarteTastatura()
        {
            Console.WriteLine("Numele cartii: ");
            string nume = Console.ReadLine();
            Console.WriteLine("Numele autorului: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Numele editurii: ");
            string editura = Console.ReadLine();
            Console.WriteLine("An aparitie: ");
            int AnAparitie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numar exemplare: ");
            int NrExemplare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Id carte: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Genul cartii: ");
            int GenCarte = Convert.ToInt32(Console.ReadLine());
            Carte c = new Carte(nume, autor, editura, AnAparitie, NrExemplare, id, GenCarte);
            return c;
        }
    }
}