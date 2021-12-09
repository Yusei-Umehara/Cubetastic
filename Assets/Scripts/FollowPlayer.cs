using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Variable publica que accede al componente transform del objeto player en el inspector
    //Tambien crea un nuevo componente dentro del script del objeto que se llena (en este caso) con el objeto Player.
    public Transform player;
    
    public Vector3 offset;

    void Update()
    {
        //transform con t minuscula, se refiere a la propiedad del componente Transform
        transform.position = player.position + offset; 
        
    }

    
}
