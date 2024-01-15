using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Article
    {

        private int numReference;
        private string nomProduit;
        private double prixProduit;
        private int quantiteStock;

        public Article() { }    
        public Article(int numReference, string nomProduit, double prixProduit, int quantiteStock)
        {
            this.numReference = numReference;
            this.nomProduit = nomProduit;
            this.prixProduit = prixProduit;
            this.quantiteStock = quantiteStock;
        }
        

        public int NumReference { get => numReference; set => numReference = value; }
        public string NomProduit { get => nomProduit; set => nomProduit = value; }
        public double PrixProduit { get => prixProduit; set => prixProduit = value; }
        public int QuantiteStock { get => quantiteStock; set => quantiteStock = value; }

        public override string ToString()
        {
            return this.numReference+ " "+this.NomProduit+" "+this.prixProduit+" "+this.quantiteStock;
        }
    }
}
