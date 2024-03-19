using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    AudioClip clip;
    AudioSource source;

    Vector3 beginvec = new Vector3(0.0f, 6.0f, -1.0f);

    [SerializeField]
    GameObject ingameui;
    [SerializeField]
    GameObject Wallnut;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
        source.loop = true;
        source.Play();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("Key");
            source.Pause();
            ingameui.SetActive(true);
            gameObject.SetActive(false);
            Instantiate(Wallnut);
            Wallnut.transform.position = beginvec;
        }
    }

    static public void GameBegin()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
