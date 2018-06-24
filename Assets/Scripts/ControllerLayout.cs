using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerLayout : MonoBehaviour {

	public static ControllerLayout instance;
	public int currentLayout = 0;
	public TokenBehaviour[] tokens;

	//vetor onde a posição+1 indica o jogador e o numero de 0 a 4 indica o instrumento. ex: pos 0 e valor 1 -> jogador 1 com o alaúde
	public int[] selectedInstruments;
	public Button playButton;

	void Awake(){
		if (instance == null)
            instance = this;
        else if (instance != this)
      		 Destroy(gameObject);
		DontDestroyOnLoad(gameObject);

		selectedInstruments = new int[4];
	}

	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown(KeyCode.Tab)){
			ChangeLayout();
		}*/
	}

	void ChangeLayout(){
		currentLayout = 1-currentLayout;
		for(int i = 0; i < 4; i++){
			tokens[i].buttonLayout = currentLayout;
			tokens[i].ChangeSprite();
		}
	}

	public void UpdateInstruments(){
		int count = 0;
		for(int i = 0; i < 4; i++){
			print("entrou");
			if(tokens[i].selectedSector != null){
				selectedInstruments[i] = tokens[i].selectedSector.instrument;
			}
			else{
				selectedInstruments[i] = 0;
			}
			if(selectedInstruments[i] == 0){
				count++;
			}
		}
		if(count == 4){
			playButton.interactable = false;
		}
		else{
			playButton.interactable = true;
		}
	}
}
