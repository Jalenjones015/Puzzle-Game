using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperAnswer : MonoBehaviour
{
    public GameObject Paper;
    private GameObject var;
    bool paperup;

    public void OnMouseDown()
    {
        Destroy(gameObject);
        Paper.SetActive(true);
        GameObject var = GameObject.Find("Player");
        var.GetComponent<Mouse>().enabled = false;
        var.GetComponent<Movement>().enabled = false;
        Cursor.visible = true;
    }

    public void AnsRight()
    {
         if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            var.GetComponent<Mouse>().enabled = true;
            var.GetComponent<Movement>().enabled = true;
            Cursor.visible = false;
        }
    }
}
