using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingscript : MonoBehaviour
{
    public float firerate;
    float firecooldown = 0;
    public Transform projectile;
    // public KeyCode shootKey;
    public string ShootButton;
    // Update is called once per frame
    void Update()
    {
        firecooldown += Time.deltaTime;

        if (firecooldown >= firerate && Input.GetButton(ShootButton) )
        {
            shoot();
            firecooldown = 0;
        }

    }

    void shoot()
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
