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

            List<double> notes = new List<double>();
            do
            {


                Console.WriteLine("--- Gestion des notes avec menu ---\n");

                Console.WriteLine("1 ----- Saisir des notes \n");
                Console.WriteLine("2 ----- La plus grande note \n");
                Console.WriteLine("3 ----- La plus petite note \n");
                Console.WriteLine("4 ----- La moyenne des notes \n");
                Console.WriteLine("0 ----- Quitter \n");
                Console.WriteLine(" \n");
                Console.Write($"Faites votre choix : ");
                int gestionNotes = int.Parse(Console.ReadLine());

                //double somme = 0;

                switch (gestionNotes)
                {
                    case 1:
                        double note;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n----- Saisir des notes ------ \n");
                        Console.WriteLine("(Tapez 999 pour stoper la saisie) \n");
                        Console.ResetColor();
                        int i = 1;

                        do
                        {
                            Console.Write($"- Merci de saisir la note {i} (sur /20) : ");
                            note = double.Parse(Console.ReadLine());

                            if (note < 0 || note > 20)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"\t- Erreur de saisi de la note \n");
                                Console.ResetColor();
                            }
                            else
                            {
                                notes.Add(note);
                                i++;
                            }


                        }
                        while (note != 999);
                        Console.Clear();
                        break;


                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("--- La plus grande note ---\n");
                        Console.WriteLine($"La note la plus grande est : {notes.Max()}/20 \n");
                        Console.ResetColor();
                        //Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- La plus petite note ---\n");
                        Console.WriteLine($"La note la plus petite est : {notes.Min()}/20 \n");
                        Console.ResetColor();
                        break;

                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("--- La moyenne des notes ---\n");
                        Console.WriteLine($"La moyenne est de : {notes.Average()}/20 \n");
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

