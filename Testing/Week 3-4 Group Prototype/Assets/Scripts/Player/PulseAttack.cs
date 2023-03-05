using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseAttack : MonoBehaviour
{
    public GameObject pulse;
    public Vector3 sizeChange;
    //public float pulseSize = 0.1f;

    void LateUpdate()
    {
        pulse.transform.localScale = pulse.transform.localScale + sizeChange;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "")
        {
            Destroy(this);
        }

    }

}
