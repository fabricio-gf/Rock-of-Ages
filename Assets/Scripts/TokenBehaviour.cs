using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TokenBehaviour : MonoBehaviour{

	public int playerNum;
	
	public Vector2 initialPosition;
	public SectorBehaviour selectedSector;
	bool validSector = false;

	public int buttonLayout;
	public Sprite keyboardLayout;
	public Sprite joystickLayout;
	
	public void OnBeginDrag(){
		if(selectedSector != null)
			selectedSector.isValid = true;
	}

	public void OnDrag(){
		transform.position = Input.mousePosition;
	}

	public void OnEndDrag(){
		if(validSector){
			if(selectedSector.isValid){
				transform.localPosition = selectedSector.sectorPosition;
				selectedSector.isValid = false;
			}
		}
		else{
			transform.localPosition = new Vector3(initialPosition.x, initialPosition.y, 0);
			selectedSector = null;
		}
		ControllerLayout.instance.UpdateInstruments();
	}

	public void OnTriggerEnter2D (Collider2D other){
		if(other.tag == "Sector"){
			if(other.GetComponent<SectorBehaviour>() != null){
				print("enter sector");
				selectedSector = other.GetComponent<SectorBehaviour>();
				validSector = selectedSector.isValid;
				print("valid sector = "+ validSector);
			}
		}
		if(other.tag == "Center"){
			print("enter center");
			validSector = false;
		}
	}
	public void ChangeSprite(){
		Image image = GetComponent<Image>();
		if(buttonLayout == 0)
			image.sprite = keyboardLayout;
		else if(buttonLayout == 1)
			image.sprite = joystickLayout;
	}
}
