using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperAnswer : MonoBehaviour
{
    public GameObject Paper;
    private GameObject var;
    public GameObject Dpaper;
    public GameObject DGO;
    public Text text;
    private int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        text.text = score.ToString();
        text.text = "Pages Collected: " + score;
    }

    public void pressed()
    {
        Destroy(Dpaper);
        Destroy(DGO);
        Paper.SetActive(true);
        GameObject var = GameObject.Find("Player");
        var.GetComponent<Mouse>().enabled = false;
        var.GetComponent<Movement>().enabled = false;
        Debug.Log("Press");
        
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
    }

    public void scored()
    {
        score += 1;
        Debug.Log("Score");
    }
}
