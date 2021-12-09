using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    //funcion interna de unity que detecta las colisiones entre los 2 objetos. 
    
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds (5);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log("We hit something");   
        //sirve para detectar el objeto con el que chocamos: Debug.Log(collisionInfo.collider.name);   
        //if (collisionInfo.collider.name == "ObstacleDemo")
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //FindObjectType es la forma correcta de buscar elementos de otro script e insertarlos en otro objeto o citarlos sin cometer el error de citarlos en el inspector, el cual, al usar objetos en multiples escenas, no tiene permanencia.
               
            FindObjectOfType<GameManager>().EndGame();
            
        }

    }


}
