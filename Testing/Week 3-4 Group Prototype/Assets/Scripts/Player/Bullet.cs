using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _bulletSpeed = 1.5f;
    public PlayerMovement playerMovement;
    public SpriteRenderer bulletSprite;

    private void Awake()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void Start()
    {
        _bulletSpeed *= PlayerMovement.playerSpeed;
       if (playerMovement.playerSprite.flipX == true)
        {
            _bulletSpeed *= -1f;
            bulletSprite.flipX = true;
        }

    }
    private void Update()
    {
        Debug.Log(_bulletSpeed);
        transform.Translate(Vector2.right * Time.deltaTime * _bulletSpeed);
           
    }
 

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hello");
        //Do Something
        if (other.GetComponent<Obstacle>())
        {
            Debug.Log("Okay");
            Destroy(this.gameObject);
        }


    }

}
