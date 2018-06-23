using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public ControllerLayout cl;
    public GameObject[] notes;

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
        cl = ControllerLayout.instance;
        int[] instruments = cl.selectedInstruments;
        if(cl.currentLayout == 0){
            for(int i = 0; i < 4; i++){
                switch (instruments[i])
                {
                    case 0:
                        //disable
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

    public void NextBeat()
    {
        //chama os eventos relativos a cada batida;
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
