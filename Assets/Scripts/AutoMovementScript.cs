using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovementScript : MonoBehaviour
{
    //speed of object
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //make a new vector
        Vector3 newPos = transform.position;

        //new position is equal to original + direction*speed *time
        newPos += transform.forward * speed * Time.deltaTime;

        transform.position = newPos;
    }
}
