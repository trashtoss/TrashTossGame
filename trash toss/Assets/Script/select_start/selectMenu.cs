﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selectMenu : MonoBehaviour {

	public difficultySettings settings;
	public Button level1;


	// Use this for initialization
	void Start ()
	{
		Time.timeScale = 1;
		Button lvl1 = level1.GetComponent<Button>();
		lvl1.onClick.AddListener(selectLevel1);

	}

	// Update is called once per frame
	void Update () {

	}

	//This is the initial settings for endless mode. I apologize for the shit name and location but
	//I'm not brave enough to move it myself
	void selectLevel1()
	{
        difficultySettings.levelCounter = 1;
        difficultySettings.levelGoal = 5;
        //int goal, float gainGla, float gainPla, float gainMet, float gainPaper, float gainComp,
        //float drop, float speed, int landfillLimit, float gap
        settings.setDifficulty(5, .05f, .1f, .15f, .05f, .02f, .03f, .02f, 5, 2f);
        levelManager.LoadPlayScene();
	}
}
