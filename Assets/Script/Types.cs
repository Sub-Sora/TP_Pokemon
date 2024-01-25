using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public static class Types
{
    public enum MonsterType
    {
        Normal,
        Water,
        Fire,
        Grass
    }

    public static float GetEffectiveness(MonsterType attacker, MonsterType target)
    {
        // All weak and resistance types
        float[,] effectivenessTable = new float[,]
        {
            /*            Normal  Water   Fire    Grass   */
            /* Normal */ {1.0f,   1.0f,   1.0f,   1.0f},
            /* Water  */ {1.0f,   0.5f,   2.0f,   0.5f},
            /* Fire   */ {1.0f,   0.5f,   0.5f,   2.0f},
            /* Grass  */ {1.0f,   2.0f,   0.5f,   0.5f}
        };

        // Check valid types
        if ((int)attacker < 0 || (int)attacker >= effectivenessTable.GetLength(0) ||
            (int)target < 0 || (int)target >= effectivenessTable.GetLength(1))
        {
            Debug.LogError("Type isn't valid");
            // Return a normal type if an error occured
            return 1.0f; 
        }

        return effectivenessTable[(int)attacker, (int)target];
    }
}
