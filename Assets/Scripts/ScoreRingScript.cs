using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRingScript : MonoBehaviour
{
    public string scoringtag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided wth obkect " + other.gameObject.name);
        if (other.CompareTag(scoringtag))
        {
            scoremanager.Instance.AddScore(10);

            Destroy(this.gameObject);
        }
    }
}
