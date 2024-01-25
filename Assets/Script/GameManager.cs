using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static Ash ashInstance;
    private static Misty mistyInstance;

    public static Ash AshInstance
    {
        get
        {
            if (ashInstance == null)
            {
                ashInstance = new Ash();
            }
            return ashInstance;
        }
    }

    public static Misty MistyInstance
    {
        get
        {
            if (mistyInstance == null)
            {
                mistyInstance = new Misty();
            }
            return mistyInstance;
        }
    }
}
