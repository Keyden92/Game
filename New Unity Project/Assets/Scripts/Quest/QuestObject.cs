﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    private bool inTrigger = false;

    public List<int> availableQuestIDs = new List<int>();
    public List<int> receivableQuestIDs = new List<int>();


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    { 
		if(inTrigger && Input.GetKeyDown(KeyCode.Space))
            {
            //quest UI manager
            }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }

}
