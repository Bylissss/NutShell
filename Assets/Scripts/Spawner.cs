using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject Spray;
    [SerializeField]
    GameObject Fertilizer;
    [SerializeField]
    GameObject WaterDrop;

    Vector3 point = new Vector3(9.0f, -3.80f, -1.0f);
    static public bool isEnemyExists = false;
    

    private void Update()
    {

        if (!isEnemyExists)
        {
           StartCoroutine(Wait());

        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }

    void Spawn()
    {
        int x = Random.Range(0, 3);

        switch (x)
        {
            case 0:
                Instantiate(Spray);
                Spray.transform.position = point;
                isEnemyExists = true;
                break;
            case 1:
                Instantiate(Fertilizer);
                Fertilizer.transform.position = point;
                isEnemyExists = true;
                break;
            case 2:
                Instantiate(WaterDrop);
                WaterDrop.transform.position = point;
                isEnemyExists = true;
                break;
            default:
                break;
        }
    }

}
