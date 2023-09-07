using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingScript : MonoBehaviour
{


    //run a timer
    //make a var
    //every second add time passed to var
    //every x seconds
    //find piece at back
    //find pos of front
    //move piece at back to front

    public Transform currentfrontpiece;
    public Transform firstpiece;
    public Transform secondpiece;
    public Transform thirdpiece;


    public float switchdistance = 0;
    private float timePassed = 0;
    public float switchtime = 0;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if(timePassed > switchtime)
        {
            if(firstpiece.position.z < secondpiece.position.z)
            {
                if(firstpiece.position.z < thirdpiece.position.z)
                {
                    firstpiece.transform.position = currentfrontpiece.position + Vector3.forward * switchdistance;
                    //first piece is at the back
                    currentfrontpiece = firstpiece;
                }
                else
                {
                    thirdpiece.transform.position = currentfrontpiece.position + Vector3.forward * switchdistance;
                    //third piece is at the back
                    currentfrontpiece = thirdpiece;
                }
            }
            else
            {
                if(secondpiece.position.z < thirdpiece.position.z)
                {
                    secondpiece.transform.position = currentfrontpiece.position + Vector3.forward * switchdistance;
                    //second piece at back
                    currentfrontpiece = secondpiece;
                }
                else
                {
                    thirdpiece.transform.position = currentfrontpiece.position + Vector3.forward * switchdistance;
                    //third piece is at the back
                    currentfrontpiece = thirdpiece;
                }
            }
            timePassed = 0;
        }
        
    }
}
