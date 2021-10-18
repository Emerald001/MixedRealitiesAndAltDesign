using UnityEngine;

public class LeftTryouts : MonoBehaviour {

    private Vector3 playerStandardPos;

    private void Awake() {
        playerStandardPos = GameObject.Find("OVRPlayerController").transform.position;
    }

    private void Update() {
        if (OVRInput.GetDown(OVRInput.Button.Three)) {
            var camPos = GameObject.Find("CenterEyeAnchor").transform.position;
            var offset = new Vector3(playerStandardPos.x - camPos.x, playerStandardPos.y, playerStandardPos.z - camPos.z);

            GameObject.Find("OVRPlayerController").transform.position = offset;
        }
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log("Colliding");

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