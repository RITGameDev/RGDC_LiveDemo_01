using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVelocityOnStart : MonoBehaviour {

    public float minXValue = 5f;
    public float maxXValue = 5f;

    public float minYValue = 1f;
    public float maxYValue = 1f;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minXValue,maxXValue),
            Random.Range(minYValue, maxYValue)
        );
	}

}
