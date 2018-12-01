using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreatePlayer : MonoBehaviour
{
    private BasePlayerClass newPlayer;
    private string playerName = "Keyden";


    //UI

    public Text strengthText;
    public Text intelectText;
    public Text agilityText;
    public Text staminaText;
    public Text luckText;

    public Text hitpointText;

    private int pointsToSpend = 20;
    public Text pointsText;

    void Start()
    {
        newPlayer = new BasePlayerClass();
        UpdateUI();
    }

    public void CreateNewPlayer()
    {
        newPlayer.PlayerLevel = 1;
        newPlayer.PlayerName = playerName;

        GameInfo.PlayerLevel = newPlayer.PlayerLevel;
        GameInfo.PlayerName = newPlayer.PlayerName;
        GameInfo.PlayerClass = newPlayer.PlayerClass;

        GameInfo.Strength = newPlayer.Strength;
        GameInfo.Intelect = newPlayer.Intelect;
        GameInfo.Agility = newPlayer.Agility;
        GameInfo.Stamina = newPlayer.Stamina;
        GameInfo.Luck = newPlayer.Luck;
        GameInfo.Hitpoint = newPlayer.Hitpoint;

        SafeInfo.SaveAllInfo();
        SceneManager.LoadScene("Startmenue");

    }

    //Füge Hier die Klassen ein
    public void SetWarriorClass()
    {
        pointsToSpend = 20;
        newPlayer.PlayerClass = new BaseWarriorClass();
        newPlayer.Strength = newPlayer.PlayerClass.Strength;
        newPlayer.Intelect = newPlayer.PlayerClass.Intelect;
        newPlayer.Agility = newPlayer.PlayerClass.Agility;
        newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
        newPlayer.Luck = newPlayer.PlayerClass.Luck;
        newPlayer.Hitpoint = newPlayer.PlayerClass.Hitpoint;
        //UpdateUI
        UpdateUI();
    }
    // ENDE KLASSEN EINFÜGEN
    void UpdateUI()
    {
        strengthText.text = newPlayer.Strength.ToString();
        intelectText.text = newPlayer.Intelect.ToString();
        agilityText.text = newPlayer.Agility.ToString();
        staminaText.text = newPlayer.Stamina.ToString();
        luckText.text = newPlayer.Luck.ToString();
        hitpointText.text = newPlayer.Hitpoint.ToString();

        pointsText.text = pointsToSpend.ToString();
    }

    public void SetStrength(int amount)
    {
        if(newPlayer.PlayerClass != null)
        {
            if(amount >= 0 && pointsToSpend > 0)
            {
                newPlayer.Strength += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount <= 0 && newPlayer.Strength > newPlayer.PlayerClass.Strength)
            {
                newPlayer.Strength += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("No Class Choosen");
        }
    }

    public void SetIntelect(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount >= 0 && pointsToSpend > 0)
            {
                newPlayer.Intelect += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount <= 0 && newPlayer.Intelect > newPlayer.PlayerClass.Intelect)
            {
                newPlayer.Intelect += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("No Class Choosen");
        }
    }

    public void SetAgility(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount >= 0 && pointsToSpend > 0)
            {
                newPlayer.Agility += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount <= 0 && newPlayer.Agility > newPlayer.PlayerClass.Agility)
            {
                newPlayer.Agility += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("No Class Choosen");
        }
    }

    public void SetStamina(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount >= 0 && pointsToSpend > 0)
            {
                newPlayer.Stamina += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount <= 0 && newPlayer.Stamina > newPlayer.PlayerClass.Stamina)
            {
                newPlayer.Stamina += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("No Class Choosen");
        }
    }

    public void SetLuck(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount >= 0 && pointsToSpend > 0)
            {
                newPlayer.Luck += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount <= 0 && newPlayer.Luck > newPlayer.PlayerClass.Luck)
            {
                newPlayer.Luck += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("No Class Choosen");
        }
    }

    public void SetHitpoint(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount >= 0 && pointsToSpend > 0)
            {
                newPlayer.Hitpoint += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount <= 0 && newPlayer.Hitpoint > newPlayer.PlayerClass.Hitpoint)
            {
                newPlayer.Hitpoint += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("No Class Choosen");
        }
    }

    public void LoadCharakter()
    {
        LoadInfo.LoadAllInfo();
    }
}
