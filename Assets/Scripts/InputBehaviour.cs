using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour {

	public KeyCode buttonCode;

	public GameObject pressRegion;
	public bool canPress = false;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(buttonCode)){
			if(canPress){
				print("acerto");
				if(GameManager.instance.mult < 2)
					GameManager.instance.mult += 0.1f;
				GameManager.instance.score += 100f*GameManager.instance.mult;
				canPress = false;
			}
			else{
				print("erro");
				GameManager.instance.mult = 1;
				canPress = false;
			}
		}
	}
}
