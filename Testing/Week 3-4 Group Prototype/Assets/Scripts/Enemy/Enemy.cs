using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;
    public int enemyMaxHp = 3;
    public int enemyCurHp = 3;

    public void Awake()
    {

        enemyCurHp = enemyMaxHp;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            other.GetComponent<PlayerStats>().currentHP -= damage;
           if (other.GetComponent<PlayerStats>().currentHP == 0)
            {
               other.GetComponent<PlayerMovement>().Death();
               // Destroy(other.gameObject);
            }
           else
            {
                other.GetComponent<PlayerMovement>().PlayerHit();
            }
            Debug.Log("Okay");
         //   
        }
        if (other.GetComponent<Bullet>())
        {
            enemyCurHp--;
            if (enemyCurHp <= 0)
            {
                Destroy(this.gameObject);
            }
        }

    }





}
