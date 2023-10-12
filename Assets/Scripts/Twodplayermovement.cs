using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Twodplayermovement : MonoBehaviour
{
    public Rigidbody2D reggiebody;
    public float jumpforce;
    public float speed;
   
    [SerializeField]
    private bool physicsmovement = true;


    public float minfloordistance;
    public Vector3 raycastOriginOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (physicsmovement)
            PhysicsMovement();
        else
            KinematicMovement();
    }
    void KinematicMovement()
    {

    }
    void PhysicsMovement()
    {
        //Ray2D floordetection = new Ray2D(this.transform.position, -Vector2.up);

        if (Input.GetButtonDown("Jump") && Physics2D.Raycast(this.transform.position + raycastOriginOffset, -Vector2.up, minfloordistance))
        {
            reggiebody.AddForce(Vector2.up * jumpforce);
        }

        float xmov = Input.GetAxisRaw("Horizontal");

        // reggiebody.AddForce(Vector2.right * xmov * speed * Time.deltaTime);
        reggiebody.velocity = new Vector2(xmov * speed, reggiebody.velocity.y);

    }
}
