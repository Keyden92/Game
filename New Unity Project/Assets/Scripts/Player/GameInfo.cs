using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour {

	void Awake ()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public static string PlayerName{get; set;}
    public static int PlayerLevel { get; set; }
    public static BaseClass PlayerClass { get; set; }

    public static int Strength { get; set; }
    public static int Intelect { get; set; }
    public static int Agility { get; set; }
    public static int Stamina { get; set; }
    public static int Luck { get; set; }
    public static int Hitpoint { get; set; }
}
