using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenPanel(GameObject panel)
    {
        panel.GetComponent<Animator>().SetBool("isOpen", true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.GetComponent<Animator>().SetBool("isOpen", false);
    }
}
