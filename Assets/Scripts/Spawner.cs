using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    enum CollectibleType{
        WEEDSPRAY,
        FERTILIZER,
        WATERDROP
    };

    [SerializeField]
    GameObject WeedSpray;
    [SerializeField]
    GameObject Fertilizer;
    [SerializeField]
    GameObject WaterDrop;

    private void Start()
    {
        for (; ; )
        {
            // Spawn();
            Debug.Log((int)Random.Range(0.0f, 0.2f));

        }
    }
    //public IEnumerator Spawn;
    //{




        /*int cy = (int)Random.Range(0.0f, 0.2f);
        Debug.Log(cy);
        switch (cy)
        {
            case (int)CollectibleType.WEEDSPRAY:
                GameObject collect = Instantiate(WeedSpray, gameObject.transform);
                Rigidbody2D rb2d = collect.GetComponent<Rigidbody2D>();
                rb2d.AddForce(transform.right * -1 * Time.deltaTime, ForceMode2D.Impulse);
                break;

            case (int)CollectibleType.FERTILIZER:
                GameObject collect1 = Instantiate(WeedSpray, gameObject.transform);
                Rigidbody2D rb2d1 = collect1.GetComponent<Rigidbody2D>();
                rb2d1.AddForce(transform.right * -1 * Time.deltaTime, ForceMode2D.Impulse);
                break;

            case (int)CollectibleType.WATERDROP:
                GameObject collect2 = Instantiate(WeedSpray, gameObject.transform);
                Rigidbody2D rb2d2 = collect2.GetComponent<Rigidbody2D>();
                rb2d2.AddForce(transform.right * -1 * Time.deltaTime, ForceMode2D.Impulse);
                break;
        }

        yield return new WaitForSeconds((int)Random.Range(0.0f, 10.0f));

        if (GameState.instance.gs != GameState.State.RUNNING) {
            Spawn(); 
        }*/
    //}
}
