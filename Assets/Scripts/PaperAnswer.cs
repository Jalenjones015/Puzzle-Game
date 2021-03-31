using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperAnswer : MonoBehaviour
{
    public GameObject Paper;
    private GameObject var;

    public void OnMouseDown()
    {
        Destroy(gameObject);
        Paper.SetActive(true);
        GameObject var = GameObject.Find("Player");
        var.GetComponent<Mouse>().enabled = false;
        var.GetComponent<Movement>().enabled = false;
    }

    public void AnsRight()
    {
          Paper.SetActive(false);
          GameObject var = GameObject.Find("Player");
          var.GetComponent<Mouse>().enabled = true;
          var.GetComponent<Movement>().enabled = true;

    }
}
