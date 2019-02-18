using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZoon : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.bounds.center.x > GetComponent<Collider2D>().bounds.center.x)
        {
            GameObject.Find("Canvas").GetComponent<ScoreController>().AddScore();
        }     
    }
}
