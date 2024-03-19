using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(-9.0f * Time.deltaTime, 0.0f, 0.0f) , Space.World);
        StartCoroutine(Wait());
        Spawner.isEnemyExists = false;
        Destroy(gameObject);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }
}
