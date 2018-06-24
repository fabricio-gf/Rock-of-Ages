using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputBehaviour : MonoBehaviour {

	public int player;
	public KeyCode buttonCode;

	public GameObject pressRegion;
	public bool canPress = false;

	public Text scoreText;
	public Text multText;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(buttonCode)){
			if(canPress){
				print("acerto");
				if(GameManager.instance.mult[player] < 2)
					GameManager.instance.mult[player] += 0.1f;
				GameManager.instance.score[player] += 100f*GameManager.instance.mult[player];
				scoreText.text = "Score: " + GameManager.instance.score[player].ToString();
				multText.text = "Multiplier: " + GameManager.instance.mult[player].ToString();
				canPress = false;
			}
			else{
				print("erro");
				GameManager.instance.mult[player] = 1;
				multText.text = "Multiplier: 1";
				canPress = false;
			}
		}
	}

	public void CheckMiss(){
		if(canPress){
			print("erro");
			GameManager.instance.mult[player] = 1;
			multText.text = "Multiplier: 1";
			canPress = false;
		}
	}
}
