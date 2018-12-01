using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass {

    private int strength;
    private int intelect;
    private int stamina;
    private int agility;
    private int luck;

    private int hitpoint;
    private int block;

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Intelect
    {
        get { return intelect; }
        set { intelect = value; }
    }
    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }
    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }

    public int Hitpoint
    {
        get { return hitpoint; }
        set { hitpoint = value; }
    }
}
