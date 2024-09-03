using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Move : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
   
    }
    
   
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Black()
    {
        Destroy(gameObject);
        //GetComponent<Renderer>().material.color = Color.black;
    }

}
