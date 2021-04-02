using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PickUpTest : MonoBehaviour
{
    public UnityEvent paper;
    public KeyCode Action;
    public bool range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (range)
        {
            if (Input.GetKeyDown(Action))
            {
                paper.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            range = true;
            Debug.Log("Ranged");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            range = false;
        }
    }
}
