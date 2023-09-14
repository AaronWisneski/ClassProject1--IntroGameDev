using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    public float speed;
    public float lifetime;
    private float lifetimecounter = 0;
    
    
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos += transform.forward * speed * Time.deltaTime;
        transform.position = newPos;
        lifetimecounter += Time.deltaTime;

        if( lifetimecounter > lifetime )
        {
            Destroy(this.gameObject);
        }

    }
}
