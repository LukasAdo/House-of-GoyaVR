﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDuelo : MonoBehaviour
{
    public AudioSource dueloAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playAudio()
    {
        dueloAudio.Play();
    }
}
