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

            Carte c1 = new Carte("Mandrie si Prejudecata", "Jane Austin", "Corint", 2014, 3, 132, 3);
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
        }
    }
}