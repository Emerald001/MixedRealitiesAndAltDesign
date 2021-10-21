using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRotate : MonoBehaviour
{
    public GameObject RightHand;

    void Start()
    {
        
    }

    void Update()
    {
        var targetLookat = new Vector3(transform.position.x, RightHand.transform.position.y, RightHand.transform.position.z);

        transform.LookAt(targetLookat, Vector3.left);
    }

    /*
    private void OnTriggerStay(Collider other)
    {
        if (OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > 0.5f)
        {
            
            New code go here

        }
    }*/
}
