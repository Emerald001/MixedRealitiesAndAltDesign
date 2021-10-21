using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRotate : MonoBehaviour
{
    public GameObject RightHand;

    private void Start() {
        var targetLookat = new Vector3(transform.position.x, RightHand.transform.position.y, RightHand.transform.position.z);
        transform.LookAt(targetLookat, Vector3.left);
    }

    private void OnTriggerStay(Collider other) {
        if (OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger) > 0.5f || OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > 0.5f) {
            var targetLookat = new Vector3(transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.LookAt(targetLookat, Vector3.left);
        }
    }
}
