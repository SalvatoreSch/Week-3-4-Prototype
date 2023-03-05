using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hello");
        //Do Something
        if (other.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            Debug.Log("Okay");
            Destroy(this.gameObject);
        }

       
    }

}
