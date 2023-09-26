using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRingSpawning : MonoBehaviour
{
    //original script corrupted. grab Professor's script from git repo

    void Update()
    {
        spawnCounter += Time.deltaTime;

        if (spawnCounter > spawnrRate)
        {
            Instantiate(ringPrefab, spawnPoints[randomIndex].transform.position, spawnPoints[randomIndex].transform.rotation);
        }
}
