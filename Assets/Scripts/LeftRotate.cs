using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotate : MonoBehaviour
{
    public GameObject LeftHand;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var targetLookat = new Vector3(LeftHand.transform.position.x, transform.position.y, LeftHand.transform.position.z);

        transform.LookAt(targetLookat, Vector3.up);
    }

    /*
    private void OnTriggerStay(Collider other)
    {

        transform.LookAt(LeftHand.transform);
        if (OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger) > 0.5f || OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > 0.5f)
        {
            transform.LookAt(other.transform);
        }

    }*/
}
