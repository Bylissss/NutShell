using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Spawner.isEnemyExists = false;
        ScoreCounter.AddPoint(15);
        Destroy(gameObject);
    }
}
