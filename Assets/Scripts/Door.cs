using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform Camera;
    [Header("MaxDistance you can open or close the door.")]
    public float Max = 5;

    private bool opened = false;
    private Animator anim;



    void Update()
    {
        //This will tell if the player press F on the Keyboard. P.S. You can change the key if you want.
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pressed();
            //Delete if you dont want Text in the Console saying that You Press F.
            Debug.Log("You Press E");
        }
    }

    void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit hit;

        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, Max))
        {

            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (hit.transform.tag == "Door")
            {
                anim = hit.transform.GetComponentInParent<Animator>();
                opened = !opened;
                anim.SetBool("Opened", !opened);
            }
        }
    }
}
