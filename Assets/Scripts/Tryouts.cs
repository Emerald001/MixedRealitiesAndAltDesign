using UnityEngine;

public class Tryouts : MonoBehaviour {

    private GameObject hand;

    private void Start() {
        hand = this.gameObject;
    }

    // Update is called once per frame
    private void Update() {
    }

    private void OnTriggerStay(Collider other) {
        if (OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > .5f) {
            if (other.gameObject.transform.parent == null)
                other.gameObject.transform.parent = hand.transform;
        }
        else other.gameObject.transform.parent = null;
    }

    private void OnTriggerExit(Collider other) {
        other.gameObject.transform.parent = null;
    }
}