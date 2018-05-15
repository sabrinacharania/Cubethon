﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

bool gameIsOver = false;
public float restartDelay = 1f;
public GameObject completeLevelUI;
	public void completeLevel(){
		//Debug.Log("level completed");
		completeLevelUI.SetActive(true);
	}
	public void EndGame(){

		if(gameIsOver==false){
		Debug.Log("Game Over");
		gameIsOver = true;
		}
		Invoke("Restart", restartDelay);
	}

	public void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
