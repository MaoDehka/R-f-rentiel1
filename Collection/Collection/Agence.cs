using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Agence
    {
        private string nomA;
        private List<Compte> LesComptes;

        public Agence(string nomASai)
        {
            nomA = nomASai;
            LesComptes = new List<Compte>(); 
        }
        public string GetNomA()
        {
            return nomA;
        }
        public void SetNom(string nouveauNomA)
        {
            nomA = nouveauNomA;
        }
        public int GetNbCpt()
        {
            return LesComptes.Count;
        }
        public Boolean ExisteNumCpt(int NumCpt)
        {
            int ind = 1;
            Boolean trouve = false;
            
                
            while ((ind <= LesComptes.Count) & (trouve == false))
            {
                
                if (LesComptes[ind].GetNumero() == NumCpt)
                {
                    trouve = true;
                }
                ind = ind + 1;
            }
            return trouve;
        }
        public Boolean ExisteCpt(Compte cpt)
        {
            int ind;
            Boolean trouve;

            trouve = false;
            ind = 1;

            while ((ind <= LesComptes.Count) & (trouve == false))
            {
                if (LesComptes[ind].GetNumero() == LesComptes.Count)
                {
                    trouve = true;
                }
                ind = ind + 1;
            }
            return trouve;
        }
        public void AjoutCpt(Compte cpt)
        {
            LesComptes.Add(cpt);
        }
        public Compte GetCpt(int NumCpt)
        {
            int ind;
            Boolean trouve;
            trouve = false;
            ind = 0;

            while ((ind <= LesComptes.Count) & (trouve == false))
            {
                if (LesComptes[ind].GetNumero() == NumCpt)
                {
                    trouve = true;
                }
                ind = ind + 1;
            }
            if (trouve == true)
            {
                return (LesComptes[ind]);
            }
            else
            {
                return (null);
            }
        }
    }
}
