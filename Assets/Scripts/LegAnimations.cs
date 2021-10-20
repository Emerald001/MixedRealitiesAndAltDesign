using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegAnimations : MonoBehaviour
{
    public Animator legAnimator;
    public float timeBetweenAnimations = 5;

    private bool CanDoOtherAnimation = true;

    // Update is called once per frame
    private void Update()
    {
        if (Random.Range(0, 3000) < 2 && CanDoOtherAnimation) {
            legAnimator.SetTrigger("ShakeLeg");
            Debug.Log("Shake leg");
            CanDoOtherAnimation = false;
            Invoke("CanInvoke", timeBetweenAnimations);
        }

        if (Random.Range(0, 3000) < 2 && CanDoOtherAnimation) {
            legAnimator.SetTrigger("CrossLegs");
            Debug.Log("Cross legs");
            CanDoOtherAnimation = false;
            Invoke("CanInvoke", timeBetweenAnimations);
        }
    }

    private void CanInvoke() {
        CanDoOtherAnimation = true;
    }
}
