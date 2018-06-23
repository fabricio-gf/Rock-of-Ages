using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    public static GameManager instance = null;

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
