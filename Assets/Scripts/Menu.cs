using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Puzzle Game");
        Debug.Log("Start");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("credits");
    }

    public void Howto()
    {
        SceneManager.LoadScene("How To");
        Debug.Log("Start");
    }

    public void close()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void back()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Back");
    }

    public void restart()
    {
        SceneManager.LoadScene("Puzzle Game");
        Debug.Log("Back");
    }

    public void Crediback()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        Debug.Log("Back");
    }
}
