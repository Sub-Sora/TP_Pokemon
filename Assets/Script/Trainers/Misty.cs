using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misty : Humans, ITrainers
{

    public List<Pokemons> Monsters { get; } = new List<Pokemons>();
    void Start()
    {
        NameHmns = "Misty";
    }
}
