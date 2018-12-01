using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goldmanager : MonoBehaviour
{

    public static Goldmanager goldmanager;
    [SerializeField] private int gold;

    public Text goldText;

    // Use this for initialization
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddGold(int amount)
    {
        gold += amount;
        UpdateUI();
    }

    public void ReduceGold(int amount)
    {
        gold -= amount;
        UpdateUI();
    }

    public bool CheckGold(int amount)
    {
        if (amount <= gold)
        {
            return true;
        }
        return false;

    }

    void UpdateUI()
    {
        goldText.text = gold.ToString("D");
    }
}