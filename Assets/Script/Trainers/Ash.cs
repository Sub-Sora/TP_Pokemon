using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ash : Humans, ITrainers
{

    public List<Pokemons> Monsters { get; } = new List<Pokemons>();
    void Start()
    {
        NameHmns = "Ash";
    }
}
