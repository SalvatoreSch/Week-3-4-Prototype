using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _bulletSpeed = 1.5f;
    public PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void Start()
    {
        _bulletSpeed *= playerMovement.playerSpeed;
       if (playerMovement.playerSprite.flipX == true)
        {
            _bulletSpeed *= -1f;
        }

    }
    private void Update()
    {
        Debug.Log(_bulletSpeed);
        transform.Translate(Vector2.right * Time.deltaTime * _bulletSpeed);
           
    }
    private void OnCollisionEnter(Collision collision)
    {

        Destroy(this);
    }
}
