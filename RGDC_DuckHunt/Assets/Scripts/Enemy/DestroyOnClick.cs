using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour {

    public ParticleSystem popParticles;
    private bool _clickedOn;
    void OnMouseDown()
    {
        if (_clickedOn) { return; }
        _clickedOn = true;

        GetComponent<SpriteRenderer>().color =
                new Color(1.0f, 1.0f,1.0f, 0.0f);

        popParticles.Play();
        Score.CurrentScore++;
        // Tell the score manager that we have gotten a point
        Invoke("DestroyThis", 1f);
    }

    private void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
