﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Emergency_veh : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public AudioSource Player;                                  //Holds the master audioclip
    public AudioClip[] Voices;                                  //Array for sounds
    int Selected = 0;                                           //Index of selected option
    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////

    public void Ambu()
    {
        Selected = 0;
        player();
    }
    public void Police()
    {
        Selected = 1;
        player();
    }
    public void Fire()
    {
        Selected = 2;
        player();
    }

    private void player()
    {
        Player.Stop();
        Debug.Log("Stopped");

        StartCoroutine(Play2());
    }

    IEnumerator Play2()
    {
        Player.clip = Voices[Selected];
        Player.Play();
        Debug.Log("Change2");

        yield return new WaitWhile(() => Player.isPlaying);
    }
}