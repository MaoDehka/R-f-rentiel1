using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Compte
    {
        private int numero;
        private double solde;

        public Compte(int numeroSai, double soldeSai)
        {
            numero = numeroSai;
            solde = soldeSai;
        }
        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int nouveauNumero)
        {
            numero = nouveauNumero;
        }
        public double GetSolde()
        {
            return solde;
        }
        public void SetSolde(double nouveauSolde)
        {
            solde = nouveauSolde;
        }
        public void afficher()
        {
            Console.WriteLine("Numéro de compte : " + numero + " | " + "Solde : " + solde);
        }
    }
}