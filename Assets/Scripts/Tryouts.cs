using UnityEngine;

public class Tryouts : MonoBehaviour {

    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        AnimateHand();
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.layer == 6) {
            if (OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > .5f) {
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
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.layer == 6) {
            other.gameObject.transform.parent = null;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    public void AnimateHand() {
        var indexValue = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
        var threeFingersValue = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger);

        var thumbValue = 0;

        if (OVRInput.Get(OVRInput.Touch.Two)) {
            thumbValue = 1;
        }
        else {
            thumbValue = 0;
        }

        animator.SetFloat("Index", indexValue);
        animator.SetFloat("ThreeFingers", threeFingersValue);
        animator.SetFloat("Thumb", thumbValue);
    }
}