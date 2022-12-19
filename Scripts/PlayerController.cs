using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float speed=10.0f;
    public float xMax=20;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If we go to far to the left...
        if(transform.position.x < -xMax){
            transform.position = new Vector3(-xMax,transform.position.y,transform.position.z);
        }
        //If we go to far to the right...
        if(transform.position.x > xMax){
            transform.position = new Vector3(xMax,transform.position.y,transform.position.z);
        }
        //Storing our horizontal input.
        hInput=Input.GetAxis("Horizontal");
        //Moving our player to the right/left.
        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);
        //If the player presses down on the spacebar...
        //The GetKeyDown() method stores whether a key is being pressed down.
        //We use the spacebar's key code to check if the spacebar is being pressed.
        if(Input.GetKeyDown(KeyCode.Space)){
            //Launch a projectile prefab.
            Instantiate(projectile,transform.position,projectile.transform.rotation);
            //We pass in the object we want to create, the position we want it to start at, 
            //and we leave its rotation alone. We want it to start at our player's position.
        }
    }
}
