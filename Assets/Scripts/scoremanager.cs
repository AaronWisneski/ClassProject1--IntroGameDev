using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoremanager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoredisplay;
    public static scoremanager Instance;
    // Start is called before the first frame update
    void Start()
    {
        scoredisplay.text = score.ToString();
        Instance = this;
    }
    //the functio that tells this script when to increase score. 
    public void AddScore(int value)
    {
        score += value;
        //display score
        scoredisplay.text = score.ToString();
        
        return;
    }
}
