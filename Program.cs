using System;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom,prenom;
            int anneenaissance;
            DateTime date = DateTime.Today;

            Console.WriteLine("Quelle est votre nom");
            nom=Console.ReadLine();
            Console.WriteLine("Quelle est votre prenom");
            prenom = Console.ReadLine();
            Console.WriteLine("Quelle est votre annee de naissance");
            anneenaissance = Convert.ToInt32(Console.ReadLine());
            int year = date.Year;
            int age = year - anneenaissance;
            Console.WriteLine("Fiches de renseignement:");
            Console.WriteLine("*Prénom: "+prenom);
            Console.WriteLine("*Nom: " + nom);
            Console.WriteLine("*Age: " + age);



        }
    }
}
