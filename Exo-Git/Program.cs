///Exercice 8----------Quelle taille choisir-------------
///
using System;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //< -
            //int bonneTaille = 0;

            Console.WriteLine("------------Quelle taille dois-je prendre--------------");

            Console.Write("Entrez votre taille (en cm) : ");
            int taille = int.Parse(Console.ReadLine());

            Console.Write("Entrez votre poids (en kg) : ");
            int poids = int.Parse(Console.ReadLine());

            if (taille <= 145 && taille <= 169 && poids <= 43 && poids <= 65)
            {
                Console.WriteLine("Aucune taille ne vous correspond ");
            }

            else if (taille >= 145 && taille <= 169 && poids >= 43 && poids <= 65)
            {
                Console.WriteLine("Prenez la taille 1");
            }
            else if (taille >= 169 && taille <= 178 && poids >= 48 && poids <= 71)
            {
                Console.WriteLine("Prenez la taille 2");
            }
            else if (taille >= 163 && taille <= 183 && poids >= 53 && poids <= 77)
            {
                Console.WriteLine("Prenez la taille 3");
            }
            else Console.WriteLine("Aucune taille ne vous correspond ");
        }
    }
 }
