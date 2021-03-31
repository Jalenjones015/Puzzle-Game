using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pages : MonoBehaviour
{
    public Text texts;
    public float pages = 0;

    public void collected()
    {
        pages++;
        texts.text = pages.ToString();
    }
}
