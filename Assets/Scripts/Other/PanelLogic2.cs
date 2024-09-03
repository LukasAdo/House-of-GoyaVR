using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLogic2 : MonoBehaviour
{
    public GameObject intro2;
    public GameObject second2;
    public GameObject kill2;
    
    void Start()
    {
        intro2.SetActive(true);
        second2.SetActive(false);
        kill2.SetActive(false);

    }
    public void onClick()
    {
        Destroy(intro2);
        second2.SetActive(true);
        kill2.SetActive(false);
    }
    public void secondDialogue()
    {
        Destroy(second2);
        kill2.SetActive(true);
    }
    public void killDialogue()
    {
        Destroy(kill2);

    }
}
