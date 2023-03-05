using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    public PlayerMovement playerMove;
    
    public GameObject attackPrefab;

    private void Awake()
    {


    }



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Dash();
        }
     


    }


    public void Attack()
    {
        playerMove.playerAnim.SetTrigger("Attack");
        Instantiate(attackPrefab, transform.position, Quaternion.identity);
    }


    public void Dash()
    {
       // if()
        playerMove.playerAnim.SetTrigger("Dash");
        // transform.Translate(playerMove.moveDir * 20);
        PlayerMovement.playerSpeed = 20;

    }


}
