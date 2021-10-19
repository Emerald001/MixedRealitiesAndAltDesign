using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    private void Update()
    {
        transform.RotateAround(this.transform.position, Vector3.up, 360 * Time.deltaTime);
    }

    private void OnTriggerStay(Collider other)
    {
        var hand = other.gameObject;

        transform.RotateAround(this.transform.position, Vector3.up, 20 * Time.deltaTime);

    }

}
