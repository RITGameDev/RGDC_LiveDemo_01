using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

    public float lifetime = 4f;

	// Use this for initialization
	void Start ()
    {
        Invoke("KillMe", lifetime);
    }
	
	private void KillMe()
    {
        Destroy(this.gameObject);
    }
}
