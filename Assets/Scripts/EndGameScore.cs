using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour {

	public Text[] score;


	// Use this for initialization
	void Start () {
		for(int i = 0; i < 4; i++){
			if(GameManager.instance.score[i] == 0){
				score[i].text = "PLAYER " + (i+1) + " SUCKS!!!";
				continue;
			}
			score[i].text = "Player " + (i+1) + ": " + GameManager.instance.score[i].ToString();
		}
	}
	
}
