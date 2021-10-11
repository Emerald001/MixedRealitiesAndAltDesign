using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnableObject : MonoBehaviour
{
    public GameObject ObjectToTurn;
    public GameObject Hand;

    public bool Holding;

    private void Update() {
        if(Holding)
            ObjectToTurn.transform.LookAt(Hand.transform);

        if (OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) < .5f) {
            Holding = false;
            Hand = null;
        }
    }

    private void OnTriggerStay(Collider other) {
        if(OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > .5f) {
            Hand = other.gameObject;
            Holding = true;
        }
    }
}