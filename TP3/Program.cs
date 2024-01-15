using System;


namespace TP3
{

    public class Program
    {
        public static void Main(string[] args)
        {


            int rep;
            int reff;
            string nom;
            double prix;
            int qt;
            Stock s = new Stock();
            do
            {
                Console.WriteLine("1. Rechercher un article par reference." +
                       "\n2. Ajouter un article au stock en verifiant l’unicite de la reference." +
                       "\n3. Supprimer un article par reference." +
                       "\n4. Modifier un article par reference." +
                       "\n5. Rechercher un article par nom." +
                       "\n6. Rechercher un article par intervalle de prix de vente." +
                       "\n7. Afficher tous les articles." +
                       "\n8. Quitter");
                rep = int.Parse(Console.ReadLine());

                switch (rep)
                {

                    case 1:
                        Console.WriteLine("Donner ref article a recherche: ");
                        reff = int.Parse(Console.ReadLine());
                        s.GetArticle(reff);
                        break;
                    case 2:
                        Console.WriteLine("Donner reference d'article : ");
                        reff = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nouveau Nom Produit : ");
                        nom = Console.ReadLine();
                        Console.WriteLine("Nouveau Prix Produit: ");
                        prix = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nouveau Quantite Stock : ");
                        qt = int.Parse(Console.ReadLine());
                        Article a = new Article(reff,nom,prix,qt);
                        s.AddArticle(a);

                        break;
                    case 3:

                        Console.WriteLine("Donner ref article a supprimer: ");
                        reff = int.Parse(Console.ReadLine());
                        s.RemoveArticle(reff);
                        break;
                    case 4:
                        Console.WriteLine("Donner ref article a recherche: ");
                        reff = int.Parse(Console.ReadLine());
                        s.modifierArticle(reff);
                        break;
                    case 5:
                        Console.WriteLine("Donne nom article a recherche: ");
                        nom = Console.ReadLine();
                        s.chercherArticleParNom(nom); 
                        break;
                    case 6:
                        Console.WriteLine("Interval Prix Produit pour recherche: ");
                        double MinPrix = double.Parse(Console.ReadLine());
                        double MaxPrix = double.Parse(Console.ReadLine());
                        s.chercherParIntervalePrix(MinPrix, MaxPrix);
                        break;
                    case 7:
                        s.AfficherTous();
                        break;
                    case 8: break;
                    default: Console.WriteLine("mauvais saisie"); break;

                }



            } while (!(rep == 8));

        }
    }
}