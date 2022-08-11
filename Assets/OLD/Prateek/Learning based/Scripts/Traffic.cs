﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Traffic : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] Options1;                               //Array to hold the buttons
    public AudioSource Player;                                  //Holds the master audioclip
    public AudioClip[] Voices;                                  //Array for sounds
    int Selected = 0;                                           //Index of selected option
    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////

    public void Button()
    {
        for (int i = 0; i < 7; i++)
        {
            if (EventSystem.current.currentSelectedGameObject.name == Options1[i].name)
            {
                Selected = i;
                Debug.Log(Selected);
            }
        }

        player();
    }

    private void player()
    {
        Player.Stop();
        Debug.Log("Stopped");

        StartCoroutine(MasterPlay());
    }

    IEnumerator MasterPlay()
    {
        Player.clip = Voices[Selected];
        Player.Play();
        Debug.Log("Change2");

        yield return new WaitWhile(() => Player.isPlaying);
    }
}