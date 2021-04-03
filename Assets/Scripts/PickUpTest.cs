﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PickUpTest : MonoBehaviour
{
    public UnityEvent paper;
    public KeyCode Action;
    public bool range;
    public GameObject f;

    void Update()
    {
        if (range)
        {
            if (Input.GetKeyDown(Action))
            {
                paper.Invoke();
                f.SetActive(false);
                
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            f.SetActive(true);
            range = true;
            Debug.Log("Ranged");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            range = false;
            f.SetActive(false);
        }
    }
}
