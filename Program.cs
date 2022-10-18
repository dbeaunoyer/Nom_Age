using System;

namespace premier_programme
{
    class Program
    {
        static void AfficherInfosPersonne(string nom, int age )

        {

            // AFFICHE LES RESULTATS
            Console.WriteLine();          // LIGNE VIDE
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine("Dans un an, vous aurez " + (age + 1) + " ans");

            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur... ");
            }

            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientot majeur");
            }

            else if ((age >= 12) && (age < 18))
            {
                Console.WriteLine("vous etes un adolescent");
            }

            else if ((age == 1) || (age == 2))
            {
                Console.WriteLine("vous etes un bebe");
            }

            else if (age >= 60)

            {
                Console.WriteLine("Vous etes senior");
            }

            else if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur... ");
            }

            else if (age < 10)
            {
                Console.WriteLine("Vous etes un enfant");
            }

            else
            {
                Console.WriteLine("Vous êtes mineur... ");

            }

            Console.WriteLine("Vous faites" + taille + " m de hauteur");

        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";
            while (nom == "")
            {
                Console.Write("Quel est le nom de la personne numéro " + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");
                }
            }
            return nom;
        }

        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write(nom + ", quel est ton age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: L'age ne doit pas être égal à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur :  Vous devez rentrer un age valide.");
                }
            }
            return age_num;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // DEMANDE LE NOM
            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);

            // DEMANDE L'AGE
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);



            // AFFICHE LES RESULTATS
            AfficherInfosPersonne(nom1, age1, 1.75);
            AfficherInfosPersonne(nom2, age2);


           
        }
    }
}
