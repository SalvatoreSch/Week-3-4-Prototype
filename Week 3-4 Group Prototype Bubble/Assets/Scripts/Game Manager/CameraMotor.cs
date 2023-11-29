using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;

    public Vector3 offset = new Vector3(0, 0, -7.0f);

    private void LateUpdate()
    {
        transform.position = lookAt.transform.position + offset;
    }
}
