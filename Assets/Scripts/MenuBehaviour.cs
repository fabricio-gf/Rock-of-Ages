using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour {

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

    public void ChangeScene(string name){
        SceneManager.LoadScene(name);
    }
}
