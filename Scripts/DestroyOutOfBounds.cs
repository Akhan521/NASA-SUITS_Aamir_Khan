using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound=30;
    public float lowerBound=-10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If our object goes out of bounds, we destroy it.
        if(transform.position.z > topBound){
            Destroy(gameObject);
            //We destroy the object that the script is tied to.
        }
        else if(transform.position.z < lowerBound){
            //If an animal gets past the player, we output Game Over!
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
