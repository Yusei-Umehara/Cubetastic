using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;

    //crear variable publica para la animacion, funcion y numero especifico por escenario.
    public void CompleteLevel()
    {
        //Debug.Log("Level WON !");
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Invoke es un metodo interno que nos ayuda a retrasar una funcion, metodo o algo en especifico y se puede acceder en el inspector.
            //Los parametros son, el objeto al que se va a aplicar el efecto, 2: la dilatacion en segundos = 2f;
            Invoke("Restart", restartDelay);
        }

    }

    public void Restart()
    {
        //SceneManager.LoadScene("level01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
