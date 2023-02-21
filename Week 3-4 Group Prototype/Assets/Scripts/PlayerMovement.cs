using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 5f;
    public Vector2 moveDir;

   public SpriteRenderer playerSprite;

    public bool playerRotation;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveDir.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDir.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDir.x = -1;
            playerSprite.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir.x = 1;
            playerSprite.flipX = false;
        }
        Move(moveDir);
        moveDir = Vector2.zero;
        if (playerSprite.flipX == true)
        {
            playerRotation = true;
        }
        else
        {
            playerRotation = false;
        }
    }


    private void Move(Vector2 moveDir)
    {
       
        transform.Translate(moveDir * Time.deltaTime * playerSpeed);
    }
}
