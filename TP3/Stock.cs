using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Stock
    {
        List<Article> articles;

        public Stock()
        {
            this.articles = new List<Article>();
        }

        public bool GetArticle(int id)
        {
            bool trouve = false;
            foreach (var article in this.articles)
            {
                if (article.NumReference == id)
                {
                    Console.WriteLine(article.ToString());
                    return true;
                }
            }
            return false;
        }

        public void AddArticle(Article article)
        {
            if (!GetArticle(article.NumReference))
            {
                this.articles.Add(article);
                Console.WriteLine("Article bien ajouté patron ");
            }
            else { Console.WriteLine("Article existe deja habibi "); }
        }

        public void RemoveArticle(int id)
        {
            bool supp = false;
            for (int i = 0; i < this.articles.Count; i++)
            {
                if (this.articles[i].NumReference == id)
                {
                    this.articles.RemoveAt(i);
                    supp = true;
                    break;
                }
            }
            if (supp) { Console.WriteLine("Article supprimer"); }
            else { Console.WriteLine("Article n'existe pas"); }
        }

        //public bool chercherArticle(int id)
        //{

        //    foreach (var article in this.articles)
        //    {
        //        if (article.NumReference == id)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}
        public void modifierArticle(int id)
        {
            bool modif = false;
            foreach (var article in this.articles)
            {
              
                if (article.NumReference == id)
                {
                    // num reference ne doit pas etre changer ( clé primaire comme ci lol ) 
                    Console.WriteLine("Nouveau Nom Produit : ");
                    article.NomProduit = Console.ReadLine();
                    Console.WriteLine("Nouveau Prix Produit: ");
                    article.PrixProduit = double.Parse(Console.ReadLine());
                    Console.WriteLine("Nouveau Quantite Stock : ");
                    article.QuantiteStock = int.Parse(Console.ReadLine());
                    Console.WriteLine("Modification avec succés: " + article.ToString());
                    modif = true;
                }
            }

            if (!modif) { Console.WriteLine("produit n'existe pas"); }
        }

        public bool chercherArticleParNom(string nomProd)
        {

            foreach (var article in this.articles)
            {
                if (article.NomProduit.Equals(nomProd))
                {
                    Console.WriteLine(article.ToString());
                    return true;
                }
            }
            Console.WriteLine("N'existe pas ye john");
            return false; // n'existe pas 
        }
        public void chercherParIntervalePrix(double prixMin,double prixMax)
        {
            foreach (var article in this.articles) {
                if (article.PrixProduit <= prixMax && article.PrixProduit >= prixMin) {
                    Console.WriteLine(article.ToString());
                }
            }

        }

        public void AfficherTous() { 
           this.articles.ForEach(article => { Console.WriteLine(article.ToString()); });
        
        }






    }
    }
