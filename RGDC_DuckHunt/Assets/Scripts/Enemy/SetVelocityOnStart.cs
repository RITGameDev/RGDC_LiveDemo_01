using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVelocityOnStart : MonoBehaviour {

    public float minXSpeed = 3f;
    public float maxXSpeed = -3f;

    public float minYSpeed = 1f;
    public float maxYSpeed = 3f;

    // Use this for initialization
    void Start ()
    {
        Vector2 newVelocity = new Vector2(
            Random.Range(minXSpeed, maxXSpeed),
            Random.Range(minYSpeed, maxYSpeed));
        // Tell the rigidbody to move in a specifc direction ever time we start
        GetComponent<Rigidbody2D>().velocity = newVelocity;

        if(newVelocity.x < 0f)
        {
            // flip the sprite
            GetComponent<SpriteRenderer>().flipX = false;
        }

    }
	

}
