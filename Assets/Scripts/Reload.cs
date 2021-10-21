using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public GameObject BulletPlacement;
    public Animator doorAnimator;
    public GameObject bullet;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Bullet")) {
            bullet.layer = 0;
            bullet.transform.parent = null;

            var bulletRigidboy = bullet.GetComponent<Rigidbody>();
            bulletRigidboy.useGravity = false;
            bulletRigidboy.isKinematic = true;

            //doorAnimator.SetTrigger("MoveDoor");
            doorAnimator.SetBool("MoveDoorBool", true);

            Invoke("ResetPosition", 2f);
        }
    }

    private void ResetPosition()
    {
        doorAnimator.SetBool("MoveDoorBool", false);

        bullet.transform.position = BulletPlacement.transform.position;
        bullet.transform.rotation = BulletPlacement.transform.rotation;

        bullet.GetComponent<Rigidbody>().useGravity = true;
        bullet.GetComponent<Rigidbody>().isKinematic = false;

        bullet.layer = 6;
    }
}
