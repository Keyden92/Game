using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

    public static MoneyManager moneymanager;
    [SerializeField] private int money;


    public Text moneyText;

	// Use this for initialization
	void Start () {
        UpdateUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddMoney(int menge)
    {
        money += menge;
        UpdateUI();
    }

    public void ReduceMoney(int menge)
    {
        money -= menge;
        UpdateUI();
    }

    public bool CheckMoney(int menge)
    {
        if (menge <=money)
        {
            return true;
        }
        return false;
    }

    void UpdateUI()
    {
        moneyText.text = "€ " + money.ToString("D");
    }
}
