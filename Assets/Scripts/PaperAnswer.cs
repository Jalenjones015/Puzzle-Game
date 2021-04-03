using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PaperAnswer : MonoBehaviour
{
    public GameObject Paper;
    private GameObject var;
    public GameObject Dpaper;
    public GameObject DGO;
    bool locked;
    bool isp;

    public void pressed()
    {
        if (!isp)
        {
            isp = true;
            Destroy(Dpaper);
            Destroy(DGO);
            Paper.SetActive(true);
            GameObject var = GameObject.Find("Player");
            var.GetComponent<Mouse>().enabled = false;
            var.GetComponent<Movement>().enabled = false;
            Debug.Log("Press");
            locked = false;
            if (!locked)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        
        
    }

    public void AnsRight()
    {
        Destroy(Dpaper);
        Destroy(DGO);
        Paper.SetActive(false);
        GameObject var = GameObject.Find("Player");
        var.GetComponent<Mouse>().enabled = true;
        var.GetComponent<Movement>().enabled = true;
        Debug.Log("right");
        locked = true;
        if (locked)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void useless()
    {
        Destroy(Dpaper);
        Debug.Log("Wor");
    }
}
