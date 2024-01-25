using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move_Name", menuName = "Pokemons/NewMove", order = 2)]
public class Moves : ScriptableObject
{
    public string NameMove;
    public int Power;
    public int HealingAmount;
    public Types.MonsterType MoveType;
}
