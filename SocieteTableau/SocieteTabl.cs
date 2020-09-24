using System;

namespace SocieteTableau
{
    class SocieteTabl
    {
        static void Main(string[] args)
        {
            //Créer un tableau de 8 Personnes ( 5 Employé - 5 Chefs - 1Directeur)
            Personne[] Tab = new Personne[8];
            Tab[0] = new Employe("LAIB", "LAIB", 18, 1000);
            Tab[1] = new Employe("KACED ", "Yasmine", 19, 1100);
            Tab[2] = new Employe("ATHMANI ", "Darine", 20, 1200);
            Tab[3] = new Employe("AYAD ", "Ishak", 21, 1300);
            Tab[4] = new Employe("IGHIT ", "Yanis", 22, 1400);
            Tab[5] = new Chef("BEAUCHAMP", "David", 48 , 4000, "Informatique");
            Tab[6] = new Chef("PRECIGOUT", "Pascal", 50 , 3000, "Medecine");
            Tab[7] = new Directeur("JOLIE", "Femme",45, 3000, "MEDECINE", "Medecin");

            //Afficher le tableau avec la boucle for
            Console.WriteLine("Afficher le tableau ");
            for (int i=0; i<8; i++) 
            {
                Console.WriteLine(Tab[i]);
            }

            //affichage du tableau avec la boucle foreach
            foreach (Employe e in Tab)
            {
                Console.WriteLine(e);
            }



        }
    }
}
