using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotate : MonoBehaviour
{
    private void OnTriggerStay(Collider other) {
        if (OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger) > 0.5f || OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > 0.5f) {
            var targetLookat = new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);
            transform.LookAt(targetLookat, Vector3.up);
        }
    }
}
