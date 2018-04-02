using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class DoorControl : MonoBehaviour
{
    [SerializeField] private int LoadLevel;
    public int relicCount;
    public GameObject relic; 

    private void Start()
    {
        relicCount = 0; 
    }

    private void Update()
    {
        
    }


    void OnCollisionEnter(Collision other)

    {
        if (relicCount >= 3)
        {

            if (other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneBuildIndex: LoadLevel);

            }
        }
    }
}