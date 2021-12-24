using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager.Score = 0;
        /*scoreManager = FindObjectOfType<ScoreManager>();*/
        scoreManager.Score = PlayerPrefs.GetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {
       


    }


}
