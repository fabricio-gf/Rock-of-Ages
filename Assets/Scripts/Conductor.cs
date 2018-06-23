using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Conductor : MonoBehaviour {
  
        int crotchetsperbar = 4;
        public float bpm = 120;
        public float crotchet;
        public float songposition, initialsongposition;
        public float offset = 0.2f;
        public AudioSource bpmsong;
        public float maxbeats;
        public float beatscount;
        public float barcount;
        public float sectorcount;
        public double dsptimesong;


        // Use this for initialization
        void Start()
        {

            initialsongposition = (float)(AudioSettings.dspTime - dsptimesong) * bpmsong.pitch - offset;
            beatscount = 0;
            crotchet = 60 / bpm;
            barcount = 0;

        }

        // Update is called once per frame
        void Update()
        {
            songposition = (float)(AudioSettings.dspTime - dsptimesong) * bpmsong.pitch - offset - initialsongposition;
            if (songposition > beatscount * crotchet)
            {
                beatscount++;

                checkbar();
            }
            if (songposition > 4 * barcount * crotchet + 4 * crotchet)
            {
                barcount++;

            }

            Debug.Log("total time" + " " + songposition);
            Debug.Log("beats count" + " " + beatscount);
            Debug.Log("sector count" + " " + sectorcount);
            Debug.Log("bar" + " " + barcount);

        }



        private void checkbar()
        {
            if (sectorcount < 4)
            {
                sectorcount++;
            }
            else
            {
                sectorcount = 1;
            }

        }
    }
    


