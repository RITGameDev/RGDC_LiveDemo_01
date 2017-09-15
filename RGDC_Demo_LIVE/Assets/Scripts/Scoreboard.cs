using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour {

    private static UnityEngine.UI.Text scoreboardText;

    private static int _score = 0;

    public static int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            // Set some UI
            scoreboardText.text = _score.ToString();
            Debug.Log("Scored! " + _score.ToString());
        }
    }

    private void Start()
    {
        scoreboardText = GetComponent<UnityEngine.UI.Text>();
    }

}
