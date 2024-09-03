using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform vr;
    public float tAngle = 30.0f;
    public float s = 3.0f;
    public bool F;

    private CharacterController xx;
    // Start is called before the first frame update
    void Start()
    {
        xx = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vr.eulerAngles.x >=tAngle && vr.eulerAngles.x < 90.0f)
        {
            F = true;
        }
        else
        {
            F = false;
        }
        if (F)
        {
            Vector3 f = vr.TransformDirection(Vector3.forward);
            xx.SimpleMove(f * s);
        }
    }
}
