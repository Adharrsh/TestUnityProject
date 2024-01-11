using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBuilding : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    [SerializeField] private string newLevel;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                Debug.Log("Hello");
                SceneManager.LoadScene(1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            isInRange = true;
            Debug.Log("Player is in range with M");

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            isInRange = false;
            Debug.Log("Player is not in range with M");
        }
    }
}
