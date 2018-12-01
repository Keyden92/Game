using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeInfo {

    public static void SaveAllInfo()
    {
        PlayerPrefs.SetString("PLAYERNAME", GameInfo.PlayerName);
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInfo.PlayerLevel);

        PlayerPrefs.SetInt("STRENGHT", GameInfo.Strength);
        PlayerPrefs.SetInt("INTELECT", GameInfo.Intelect);
        PlayerPrefs.SetInt("AGILITY", GameInfo.Agility);
        PlayerPrefs.SetInt("LUCK", GameInfo.Luck);
        PlayerPrefs.SetInt("HITPOINT", GameInfo.Hitpoint);

        SafeInfo.SaveAllInfo();
    }

}
