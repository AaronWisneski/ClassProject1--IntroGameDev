using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRingScript : MonoBehaviour
{
    public string scoringtag = "Player";
    // public Transform ringExplosion;

    public GameObject ringmesh;
    public Collider ringCollider;

    public AudioSource ringsoundplayer;
    public AudioClip scoresound;

    private void start()
    {
        ringsoundplayer.clip = scoresound;

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided wth obkect " + other.gameObject.name);
        if (other.CompareTag(scoringtag))
        {
            scoremanager.Instance.AddScore(10);
           // Instantiate(ringExposion, this.transform.position, this.transform.rotation, this.transform);

           // Destroy(this.gameObject);
           ringmesh.SetActive(false);
           ringCollider.enabled = false;
           ringsoundplayer.Play();
        }
    }
}
