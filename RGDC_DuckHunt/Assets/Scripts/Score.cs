using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static UnityEngine.UI.Text scoreText;

    private static int _currentScore = 0;

    public static int CurrentScore
    {
        get
        {
            return _currentScore;
        }
        set
        {
            _currentScore = value;
            scoreText.text = _currentScore.ToString();
        }
    }

    private void Start()
    {
        _currentScore = 0;
        scoreText = GetComponentInChildren<UnityEngine.UI.Text>();
        scoreText.text = _currentScore.ToString();
    }

}
