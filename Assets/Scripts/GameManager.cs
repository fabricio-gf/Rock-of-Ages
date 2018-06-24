using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public ControllerLayout cl;
    public GameObject[] notes;
    public float[] score;
    public float[] mult;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        Initialize();
    }

    void Initialize(){
        score = new float[4];
        mult = new float [4];
        for(int i = 0; i < 4; i ++){
            score[i] = 0;
            mult[i] = 1;
        }
        cl = ControllerLayout.instance;
        int[] instruments = cl.selectedInstruments;
        if(cl.currentLayout == 0){
            for(int i = 0; i < 4; i++){

                switch (instruments[i])
                {
                    case 0:
                        Destroy(notes[i].gameObject);
                        break;
                    case 1:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.Q;
                        break;
                    case 2:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.Space;
                        break;
                    case 3:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.P;
                        break;
                    case 4:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.KeypadEnter;
                        break;
                    default:
                        break;
                }
            }

        }
        /*else{
            for(int i = 0; i < 4; i++){
                switch (instruments[i])
                {
                    case 0:
                        //disable
                        break;
                    case 1:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.;
                        break;
                    case 2:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.;
                        break;
                    case 3:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.;
                        break;
                    case 4:
                        notes[i].GetComponent<InputBehaviour>().buttonCode = KeyCode.;
                        break;
                    default:
                        break;
                }
            }
        }*/

        Destroy(cl.gameObject);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
