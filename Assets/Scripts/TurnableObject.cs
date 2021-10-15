using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnableObject : MonoBehaviour
{
    public GameObject ObjectToTurn;
    private GameObject Hand;

    private bool Holding;

    private void Update() {
        if(Holding)
            ObjectToTurn.transform.LookAt(Hand.transform);

        if (OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) < .5f) {
            Holding = false;
            Hand = null;
        }
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log(other);

        if(OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > .5f) {
            Hand = other.gameObject;
            Holding = true;
        }
    }
}