using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLaser : MonoBehaviour
{
    private LineRenderer line;
    public bool rightHand = true;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool state;
        if (rightHand)
        {
            state = OVRInput.Get(OVRInput.RawButton.RHandTrigger);
        } else
        {
            state = OVRInput.Get(OVRInput.RawButton.LHandTrigger);
        }
        line.enabled = state;
    }
}
