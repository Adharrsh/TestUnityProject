using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInteract : MonoBehaviour
{
    [SerializeField] private GameObject uiElement;
    [SerializeField] private GameObject EInteract;
    // Start is called before the first frame update
    void Start()
    {
        uiElement.SetActive(false);
        EInteract.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(true);
            EInteract.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(false);
            EInteract.SetActive(false);
        }
    }
}
