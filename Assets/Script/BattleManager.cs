using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public PokemonGenerator PokemonGen;

    void Start()
    {
        int seed = 12345;
        PokemonGen.SetSeed(seed);

        Ash ash = GameManager.AshInstance;
        Misty misty = GameManager.MistyInstance;

        RandomizeMonsters(ash, misty);

        Debug.Log("Seed used : " +seed);
    }

    void RandomizeMonsters(Ash ash, Misty misty)
    {
        List<Pokemons> ashMonsters = PokemonGen.GenerateRandomMonsters(2);
        List<Pokemons> mistyMonsters = PokemonGen.GenerateRandomMonsters(2);

        ash.Monsters.AddRange(ashMonsters);
        misty.Monsters.AddRange(mistyMonsters);

        Debug.Log("Ash team :");
        foreach (var monster in ashMonsters)
        {
            Debug.Log($"- {monster.NamePkmn}");
        }

        Debug.Log("Misty Team :");
        foreach (var monster in mistyMonsters)
        {
            Debug.Log($"- {monster.NamePkmn}");
        }
    }
}
