using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void returnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void levelSelector()
    {
        SceneManager.LoadScene(15);
    }

    public void Controls()
    {
        SceneManager.LoadScene(13);
    }


}
