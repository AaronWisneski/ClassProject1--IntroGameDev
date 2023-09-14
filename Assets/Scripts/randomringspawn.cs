using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomringspawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] spawnPoints = new GameObject[6];

    public float spawnrate = 1.0f;
    private float spawncounter = 0.0f;


    // Update is called once per frame
    void Update()
    {
        spawncounter += Time.deltaTime; 
        if(spawncounter > spawnrate)
        {
            int randomIndex = Random.Range(0, spawnPoints.length);
            //spawn something
            Debug.Log("spawning ring at" + spawnPoints[randomIndex].name);

            spawncounter = 0.0f;
        }
    }
}
