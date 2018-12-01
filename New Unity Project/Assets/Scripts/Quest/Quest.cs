using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Quest
{
    //Variabel
    public enum QuestProgress { NOT_AVAILABLE, AVAILABLE, ACCEPTED, COMPLETE, DONE }
    public enum questDuration { shortDuration = 2, mediumDuration = 5, scamDuration = 10}

    public string title;                //Name der Quest
    public int id;                      //ID der Quest, mit der ID alle Daten für die Quest aufrufen
    public QuestProgress progress;      //Status der aktuellen Quest, siehe ENUM
    public string description;          //Beschreibung der Quest, Questtext, Story
    public string rewards;              //Belohnungen erhalten
    public int nextQuest;               //Falls genug ernergie neue quest
    public string questObjective;       //Items from quest
    public int questObjectiveCount;  //Counting the needed Items
    public int questObjectiveRequirement; // die Menge die nötig ist um die quest zu beenden
    public questDuration questTime;     //Questdauer
    

        //Belohnungen
    public int xpReward;
    public int goldReward;
    public string itemReward;




    //Methoden



}
