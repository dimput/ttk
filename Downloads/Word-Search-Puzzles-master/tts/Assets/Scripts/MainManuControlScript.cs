﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManuControlScript : MonoBehaviour {

	public Button level02Button, level03Button;
	int levelPassed;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
		levelPassed = PlayerPrefs.GetInt ("LevelPassed");
		level02Button.interactable = false;
		level03Button.interactable = false;

		switch (levelPassed) {
		case 1:
			level02Button.interactable = true;
			break;
		case 2:
			level02Button.interactable = true;
			level03Button.interactable = true;
			break;
		}
	}
	
	public void levelToBasic()
	{
		SceneManager.LoadScene(2);
	}
	public void levelToMedium ()
	{
		Debug.Log("belum ada");
	}

	public void resetPlayerPrefs()
	{
		level02Button.interactable = false;
		level03Button.interactable = false;
		PlayerPrefs.DeleteAll ();
		SceneManager.LoadScene(0);
	}
}
