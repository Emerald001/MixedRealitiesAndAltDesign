using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private Vector3 playerStandardPos;

    private void Awake()
    {
        playerStandardPos = GameObject.Find("OVRPlayerController").transform.position;
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            var camPos = GameObject.Find("CenterEyeAnchor").transform.position;
            var offset = new Vector3(playerStandardPos.x - camPos.x, playerStandardPos.y, playerStandardPos.z - camPos.z);

            GameObject.Find("OVRPlayerController").transform.position = offset;
        }
    }
}
