using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject iLight;
    public GameObject wick;
    public GameObject glow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleLight()
    {
        iLight.SetActive(true);
        wick.SetActive(true);
        glow.SetActive(true);


    }
}
