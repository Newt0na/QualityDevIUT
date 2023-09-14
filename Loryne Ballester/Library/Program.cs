using Data.Code.Medias;
using Loryne_Ballester;
using Loryne_Ballester.Medias;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Library bibliotheque = new Library();

        Livre livre = new Livre("Culpa Mia", 101, 50, "Mercedes Ronn");
        Dvd dvd = new Dvd("After", 201, 26, 106);
        Cd cd = new Cd("Jaipasdinspi", 301, 17, "Jesaispas");

        bibliotheque.AjouterMedia(livre);
        bibliotheque.AjouterMedia(dvd);
        bibliotheque.AjouterMedia(cd);

        Console.WriteLine("Informations sur le livre:\n");
        livre.AfficherInfos();

        Console.WriteLine("\nInformations sur le DVD:\n");
        dvd.AfficherInfos();

        Console.WriteLine("\nInformations sur le CD:\n");
        cd.AfficherInfos();

        Console.WriteLine("\n");

        bibliotheque.EmprunterMedia(livre, "Pierre"); 
        bibliotheque.EmprunterMedia(dvd, "Pauline");   
        bibliotheque.EmprunterMedia(cd, "Maurice");   

        Console.WriteLine("\n");

        //affichage des nouvelles informations avec les nouvelles quantités.
        Console.WriteLine("Informations sur le livre:\n");
        livre.AfficherInfos();

        Console.WriteLine("\nInformations sur le DVD:\n");
        dvd.AfficherInfos();

        Console.WriteLine("\nInformations sur le CD:\n");
        cd.AfficherInfos();

        Console.WriteLine("\n");

        Console.WriteLine("Recherche de médias par titre ou auteur contenant 'Culpa':");
        List<Media> resultatsRecherche = bibliotheque.RechercherMediaParTitre("Culpa");
        foreach (Media media in resultatsRecherche)
        {
            media.AfficherInfos();
            Console.WriteLine();
        }

        /*Console.WriteLine("\nListe des médias empruntés:");
        List<Media> mediasEmpruntes = bibliotheque.ListerMediasEmpruntes();
        foreach (Media media in mediasEmpruntes)
        {
            media.AfficherInfos();
            Console.WriteLine();
        } */

        Console.WriteLine("\nStatistiques de la bibliothèque:");
        bibliotheque.AfficherStatistiques();
    }
}