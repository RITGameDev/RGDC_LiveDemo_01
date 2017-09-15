using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnClick : MonoBehaviour {

    private void OnMouseDown()
    {
        // Destroy this object!
        Debug.Log("Clicked on this object: " + gameObject.name);
        Scoreboard.Score++;
        Destroy(this.gameObject);
    }
}
