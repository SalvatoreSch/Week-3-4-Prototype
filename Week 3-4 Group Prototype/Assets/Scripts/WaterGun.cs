using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{

    
    public GameObject attackPrefab;





    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }


    public void Attack()
    {
        Instantiate(attackPrefab, transform.position, Quaternion.identity);
    }
}
