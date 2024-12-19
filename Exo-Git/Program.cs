///Exercice 8----------Quelle taille choisir-------------
///
using System;
using System.ComponentModel.Design;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Je crée ma liste "List" nommé listNotes dans laquelle je stockerai les notes
            List<double> listNotes = new List<double>();


            do
            {

            //Je crée mon menu
                Console.WriteLine("--- Gestion des notes avec menu ---\n");

                Console.WriteLine("1 ----- Saisir des notes \n");
                Console.WriteLine("2 ----- La plus grande note \n");
                Console.WriteLine("3 ----- La plus petite note \n");
                Console.WriteLine("4 ----- La moyenne des notes \n");
                Console.WriteLine("0 ----- Quitter \n");

                Console.WriteLine(" \n");            
                Console.Write($"Faites votre choix : ");
            //Variable gestionNotes pour récupérer le choix (1, 2, 3 ,4 ,0) via la Console.ReadLine 
                int gestionNotes = int.Parse(Console.ReadLine());

                //Crée le swith case pour exécuter les instructions correspondantes au menu en fonction du choix 
                switch (gestionNotes)
                {
                    case 1:

            //Je récupère la saisi des notes 
                        double note;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n----- Saisir des notes ------ \n");
                        Console.WriteLine("(Tapez 999 pour stoper la saisie) \n");
                        Console.ResetColor();

             //J'initialise  ma variable i (nombre de notes) à 1 pour l'accrémenter plus tard   
                        int i = 1;

            //Je crée ma boucle do...while pour répéter la saisi de notes tant que 999 nest pas tapé
                        do
                        {
                            Console.Write($"- Merci de saisir la note {i} (sur /20) : ");
                            note = double.Parse(Console.ReadLine());

            //Je vérifie et alerte (en rouge) si la note est inférieur à 0 (-1) ou supérieur à 20
                            if (note < 0 || note > 20)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"\t- Erreur de saisi de la note \n");
                                Console.ResetColor();
                            }
                            else
                            {
                                //Si true alors j'ajoute (.Add) la note à ma liste "listNotes"
                                listNotes.Add(note);

                                //Et je continu la saisie grâce l'incrémentation
                                i++;
                            }


                        }
            //Ma bouble continuera la saisi de notes tans que la note saisi n'est pas 999
                        while (note != 999);
                        Console.Clear();
                        break;

            //Affichage de la note max en vert
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("--- La plus grande note ---\n");
                        Console.WriteLine($"La note la plus grande est : {listNotes.Max()}/20 \n");
                        Console.ResetColor();
                        //Console.Clear();
                        break;

            //Affichage de la note min en rouge
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- La plus petite note ---\n");
                        Console.WriteLine($"La note la plus petite est : {listNotes.Min()}/20 \n");
                        Console.ResetColor();
                        break;

                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("--- La moyenne des notes ---\n");
                        Console.WriteLine($"La moyenne est de : {listNotes.Average()}/20 \n");
                        Console.ResetColor();
                        //Console.Clear();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("\n Fin du programme...Bye ");
                        Environment.Exit(0);
                        break;
                }


            }

            while (true);
        }
    }
}

