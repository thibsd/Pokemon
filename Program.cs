namespace Pokemon;
/*
    CONSIGNES
    1. Déclarer un tableau contenant les six Pokémon suivants :
       - Pikachu
       - Dracaufeu
       - Tortank
       - Florizarre
       - Ectoplasma
       - Ronflex
   2. Utiliser une boucle for pour parcourir le tableau.
   3. Afficher chaque Pokémon avec sa position dans l'équipe.
   4. Afficher le nombre total de Pokémon.
*/
class Program
{
    static void Main(string[] args) 
    {
      string[] pokemons = {"Pikachu", "Dracaufeu", "Tortank", "Florizarre", "Ectoplasma", "Ronflex"};
    


     for (int i = 0; i < pokemons.Length; i++)
     {
       Console.Writeline((i+1).ToString() + ". " + pokemons[i]);
     }

     Console.Writeline("\nNombre total de pokemons: " + pokemons.Length.ToString());

    }
}