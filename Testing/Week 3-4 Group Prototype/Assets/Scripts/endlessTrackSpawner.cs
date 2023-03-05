using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessTrackSpawner : MonoBehaviour
{
    public float speed;
    public float endX;
    public float startX;

    public float timeRemaining = 5;


    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x <= endX)
            {

                Vector2 pos = new Vector2(startX, transform.position.y);
                transform.position = pos;


            }
        }

    }

}
