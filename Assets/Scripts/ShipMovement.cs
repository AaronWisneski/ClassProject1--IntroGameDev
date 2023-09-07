using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

   public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Tick");

        Vector3 newPosition = this.gameObject.transform.position;
        newPosition.z += speed * Time.deltaTime;

        this.gameObject.transform.position = newPosition;
    }
}
