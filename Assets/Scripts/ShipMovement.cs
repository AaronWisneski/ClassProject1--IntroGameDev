using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Vector2 movboundMin;
    public Vector2 movboundMax;
    
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {

        #region Example
        Vector3 newPosition = this.gameObject.transform.position;

        newPosition.z += speed * Time.deltaTime;

        this.gameObject.transform.position = newPosition;
        #endregion

        float xMov;
        float yMov;

        xMov = Input.GetAxis("Horizontal");
        yMov = Input.GetAxis("Vertical");

        Vector3 motion = new Vector3(xMov, yMov, 0) * speed * Time.deltaTime;

        Vector3 finalpos = transform.position + motion;


        //make sure bounds are good
        if(finalpos.x > movboundMax.x)
            finalpos.x = movboundMax.x;
        if(finalpos.x < movboundMin.x)
            finalpos.x = movboundMin.x;

        if (finalpos.y > movboundMax.y)
            finalpos.y = movboundMax.y;
        if (finalpos.y < movboundMin.y)
            finalpos.y = movboundMin.y;

        transform.position = finalpos;

    }
}
