using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon_Name", menuName = "Pokemons/NewPokemon", order = 1)]
public class Pokemons : ScriptableObject
{
    public string NamePkmn;
    public int Hp;
    public int Atk;
    public int Def;
    public int Spd;
    public Types.MonsterType PkmnType;
    public Moves[] Move;
}
