using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLogic3 : MonoBehaviour
{
    public GameObject intro3;
    public GameObject second3;
    public GameObject kill3;

    void Start()
    {
        intro3.SetActive(true);
        second3.SetActive(false);
        kill3.SetActive(false);

    }
    public void onClick()
    {
        Destroy(intro3);
        second3.SetActive(true);
        kill3.SetActive(false);
    }
    public void secondDialogue()
    {
        Destroy(second3);
        kill3.SetActive(true);
    }
    public void killDialogue()
    {
        Destroy(kill3);

    }
}
