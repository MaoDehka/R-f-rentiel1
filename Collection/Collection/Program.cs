using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Agence ag1;
            Compte cpt1;
            int numeroSai;
            string nomASai;
            bool existe;
            double soldeSai;

            Console.WriteLine("Saisir un nom d'agence : ");
            nomASai = Console.ReadLine();

            ag1 = new Agence(nomASai);
            existe = false;

            while (existe == false)
            {
                Console.WriteLine("Saisir un numéro de compte : ");
                string numeroSai1 = Console.ReadLine();
                numeroSai = Convert.ToInt32(numeroSai1);

                Console.WriteLine("Saisir le solde du compte : ");
                string soldeSai1 = Console.ReadLine();
                soldeSai = Convert.ToDouble(soldeSai1);

                cpt1 = new Compte(numeroSai, soldeSai);
                ag1.AjoutCpt(cpt1);

                Console.WriteLine("Saisir le numéro du compte pour vérifier son existence :");
                string num1 = Console.ReadLine();
                int num = Convert.ToInt32(num1);

                ag1.ExisteNumCpt(num);
            }
        }
    }
}
