using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallnut : MonoBehaviour
{
    [SerializeField]
    float RotationSpeed = -700.0f ;
    Rigidbody2D rb2;

    [SerializeField]
    GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2.transform.Rotate(new Vector3(0, 0, RotationSpeed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Space)){
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver(collision);
    }

    void GameOver(Collision2D collision)
    {
        gameover.SetActive(true);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
