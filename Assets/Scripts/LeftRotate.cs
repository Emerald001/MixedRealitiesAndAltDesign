using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotate : MonoBehaviour
{
    public GameObject LeftHand;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if (OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger) > 0.5f) {
            var targetLookat = new Vector3(LeftHand.transform.position.x, transform.position.y, LeftHand.transform.position.z);

            transform.LookAt(targetLookat, Vector3.up);
        }
    }
}
