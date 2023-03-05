using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    public Transform lookAt;
    public Vector3 offset = new Vector3(60, 0, 0);

    private void LateUpdate()
    {
        transform.position = new Vector3(lookAt.transform.position.x + offset.x, offset.y, 0.0f);//0.0f, 0.0f);
    }

}
