using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowInteract : MonoBehaviour
{
    
    [SerializeField] private GameObject EInteract;
    // Start is called before the first frame update
    void Start()
    {
        EInteract.SetActive(false);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            EInteract.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EInteract.SetActive(false);
        }
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Deactivate EInteract when a new scene is loaded
        if (EInteract != null)
        {
            EInteract.SetActive(false);
        }
    }
}
