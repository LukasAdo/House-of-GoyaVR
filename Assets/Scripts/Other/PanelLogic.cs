using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLogic : MonoBehaviour
{
    public GameObject intro;
    public GameObject second;
    public GameObject kill;

    // Start is called before the first frame update
    void Start()
    {
        intro.SetActive(true);
        second.SetActive(false);
        kill.SetActive(false);

    }
    public void onClick()
    {
        Destroy(intro);
        second.SetActive(true);
        kill.SetActive(false);
    }
    public void secondDialogue()
    {
        Destroy(second);
        kill.SetActive(true);
    }
    public void killDialogue()
    {
        Destroy(kill);
        
    }


}
