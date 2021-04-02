using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public bool Winning;
    public GameObject Finish;

    public void win(GameObject obj)
    {
        if (!Winning)
        {
            GameOver game = obj.GetComponent<GameOver>();
            if (game)
            {
                if (game.Collected == 5)
                {
                    Winning = true;
                    Finish.SetActive(true);
                    game.Gamedone();
                    Debug.Log("won");
                }
            }
        }
    }
}
