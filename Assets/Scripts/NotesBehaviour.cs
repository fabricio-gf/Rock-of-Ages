using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesBehaviour : MonoBehaviour {
    public GameObject ConductorManager;
    public float[] notesequence;
    public Transform[] spaces;
    public GameObject[] references;
    public Conductor conductor;
    public int currnote;
    public Sprite voidsprite, greensprite,redsprite;
    public SpriteRenderer[] Sprite;
    public  float notecount;
    public float maxnote;
	// Use this for initialization
	void Start () {

        conductor = ConductorManager.GetComponent<Conductor>();
        currnote = 0;
        Sprite[0] = references[0].GetComponent<SpriteRenderer>();
        Sprite[1] = references[1].GetComponent<SpriteRenderer>();
        Sprite[2] = references[2].GetComponent<SpriteRenderer>();
        Sprite[3] = references[3].GetComponent<SpriteRenderer>();
        notecount = conductor.beatscount;
        InitSpaces();


    }
	
	// Update is called once per frame
	void Update () {
        if (conductor.beatscount > notecount&&currnote<=maxnote)
        {
            ChangeSpace();
            notecount++;
        }
	}
    void InitSpaces()
    {

       // Object.Instantiate(references[1], spaces[1]);
       // Object.Instantiate(references[2], spaces[2]);
       // Object.Instantiate(references[3], spaces[3]);
        //Object.Instantiate(references[4], spaces[4]);
        Sprite[0].sprite = voidsprite;
        Sprite[1].sprite = voidsprite;
        Sprite[2].sprite = voidsprite;
        Sprite[3].sprite = voidsprite;

    }
    
    void ChangeSpace()
    {
        //reference 1
        if (notesequence[currnote] == 0)
        {
            Sprite[0].sprite = redsprite;
        }
        else if (notesequence[currnote] == 1)
        {
            Sprite[0].sprite = greensprite;
        }

        //reference 2
        if (currnote - 1 > 0)
        {
            if (notesequence[currnote - 1] == 0)
            {
                Sprite[1].sprite = redsprite;
            }
            else if (notesequence[currnote-1] == 1)
            {
                Sprite[1].sprite = greensprite;
            }
        }

        //reference 3
        if (currnote - 2 > 0)
        {
            if (notesequence[currnote - 2] == 0)
            {
                Sprite[2].sprite = redsprite;
            }
            else if (notesequence[currnote-2] == 1)
            {
                Sprite[2].sprite = greensprite;
            }
        }

        //reference 4
        if (currnote - 3 > 0)
        {
            if (notesequence[currnote - 3] == 0)
            {
                Sprite[3].sprite = redsprite;
            }
            else if (notesequence[currnote - 3] == 1)
            {
                Sprite[3].sprite = greensprite;
            }
        }
        currnote++;



    }

}
