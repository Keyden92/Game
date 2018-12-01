using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo {

    public static void LoadAllInfo()
    {
        GameInfo.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInfo.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        // PlayerKlasse muss noch eingefügt werden

        GameInfo.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInfo.Intelect = PlayerPrefs.GetInt("INTELECT");
        GameInfo.Agility = PlayerPrefs.GetInt("AGILITY");
        GameInfo.Stamina = PlayerPrefs.GetInt("STAMINA");
        GameInfo.Luck = PlayerPrefs.GetInt("LUCK");
        GameInfo.Hitpoint = PlayerPrefs.GetInt("HITPOINT");

    }
}
