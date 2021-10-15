using UnityEngine;

public class LeftTryouts : MonoBehaviour {
    private void Update() {
        if (OVRInput.Get(OVRInput.RawButton.X)) {

        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.layer != 6) {
            return;
        }

        if (OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger) > .5f) {
            if (other.gameObject.transform.parent == null)
                other.gameObject.transform.parent = this.transform;
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
        else {
            other.gameObject.transform.parent = null;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    private void OnTriggerExit(Collider other) {
        other.gameObject.transform.parent = null;
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}