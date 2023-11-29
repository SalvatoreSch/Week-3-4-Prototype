using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float delay = 2.0f;
    public bool active = true;
    public Vector2 delayRange = new Vector2(1, 2);

    void Start()
    {
        ResetDelay();
        StartCoroutine(EnemyGen());
    }

    IEnumerator EnemyGen()
    {
        yield return new WaitForSeconds(delay);

        if (active)
        {
            Vector2 newTransform = new Vector2(Random.Range(-28.71f, 28.37f), Random.Range(-8.83f, 8.24f));
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform, Quaternion.identity);
            ResetDelay();
        }
        if (Menu.menuState == GameStates.Game)
        {
            StartCoroutine(EnemyGen());
        }
       
    }
    //x -28.71 - 28.37
    //y -8.83 - 8.24
    void ResetDelay()
    {
        delay = Random.Range(delayRange.x, delayRange.y);
    }

}
