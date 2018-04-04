using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class DoorControl : MonoBehaviour
{
    private int relicCount;
    public int numOfRelics;
    public GameObject relic;
    public string sceneToLoad;

    private void Start()
    {
        relicCount = 0;
    }

    private void Update()
    {

    }


    void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("Player"))
        {/*
            if (relicCount < numOfRelics && gameObject == relic)
            {
                relicCount++;
            }
            else */if (numOfRelics >= 3)
            {
                SceneManager.LoadScene(sceneToLoad);

            }
        }
    }
}