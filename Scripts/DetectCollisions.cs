using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Whenever a collision trigger is detected...
    private void OnTriggerEnter(Collider other){
        //We delete our current game object.
        Destroy(gameObject);
        //We also delete the object being collided with.
        Destroy(other.gameObject);
    }
}
