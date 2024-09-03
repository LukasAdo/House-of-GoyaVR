using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDog : MonoBehaviour
{
    public AudioSource dogAudio;
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
        dogAudio.Play();
    }
}
