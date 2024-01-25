using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonGenerator : MonoBehaviour
{
    private System.Random random;
    public List<Pokemons> AllPkmn = new List<Pokemons>();

    public void SetSeed(int seed)
    {
        random = new System.Random(seed);
    }

    public List<Pokemons> GenerateRandomMonsters(int count)
    {
        List<Pokemons> randomMonsters = new List<Pokemons>();

        for (int i = 0; i < count; i++)
        {
            // Choose random Pokemon
            int randomIndex = random.Next(0, AllPkmn.Count);
            Pokemons randomMonster = AllPkmn[randomIndex];

            // Check if Pokemon wasn't already on the team
            while (randomMonsters.Contains(randomMonster))
            {
                randomIndex = random.Next(0, AllPkmn.Count);
                randomMonster = AllPkmn[randomIndex];
            }

            randomMonsters.Add(randomMonster);
        }

        return randomMonsters;
    }
}
