using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUP : MonoBehaviour
{

    //Variables
    public int level;
    private float experience;
    private float experienceRequired;

    public float hp;                    //for testing purposes

    //Methods

    void Start()
    {
        level = 1;
        hp = 100;
        experience = 0;
        experienceRequired = 100;
    }

    void Update()
    {
        XP();
        //Das benutzt du an der Stelle wo er exp bekommen soll.
        if(Input.GetKeyDown(KeyCode.E))
        {
            experience += 100;
        }
    }

    void LevelInc()
    {
        level += 1;
        experience = 0;

        switch (level)
        {
            case 2:
                hp = 200;
                experienceRequired = 200;
                break;

            case 3:
                hp = 300;
                experienceRequired = 300;
                print("Glückwunsc! Du hast Level 3 erreicht!");
                break;

        }
    }

    void XP()
    {
        if (experience >= experienceRequired)
            LevelInc();
    }
}
