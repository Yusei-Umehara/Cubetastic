using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    

    public float forwardForce = 1500f; // Original value = 2000f +
    public float sidewaysForce = 400f; // Original value = 600f

    // Start is called before the first frame update
    void Start()
    {
        
        //How to make a videogame unity e02 ytb
        //rb.useGravity = false;
        //Sirve para hacer console.log
        //Debug.Log("Hello world");
    }

    // Update is called once per frame
    //FixedUpdate metodo que aplica la actualizacion de las fisicas mejor 
    void FixedUpdate()
    {

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow))
        {
            //añadir fuerza al rigidbody es otra forma de generar movimiento.
            //otra forma es usar transform.position
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                
        }


        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            //ForceMode.VelocityChange, hace que se elimine la energia creada por la masa y el movimiento de un objeto.

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }

        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            //rb.AddForce(0, 0, 50 * Time.deltaTime );

            //regresar a fuerza inicial despues de ejecutar la fuerza en 2 segundos 
        }


        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().Restart();
        }

        if (Input.GetKey("r"))
        {
            FindObjectOfType<GameManager>().Restart();
        }
        
        if (Input.GetKey("m") || Input.GetKey("p"))
        {
            SceneManager.LoadScene(15);
        }

        //Application.targetFrameRate = 60;
        
    }

    //al crear una capa/layer y bloquearla, no se seleccionara en la escena
}
