using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseGreeting : MonoBehaviour
{
    public AudioSource houseAudio;
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
        houseAudio.Play();
    }
}
