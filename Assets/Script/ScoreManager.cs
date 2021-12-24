using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
   
    public UnityEngine.UI.Text TextScoreUI;


    private int _score;
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;


            TextScoreUI.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);

        }
    }


}
