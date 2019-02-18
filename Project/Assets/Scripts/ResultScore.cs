using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScore : SpriteNumber
{
	// Use this for initialization
	void Start ()
    {
   
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_number = GameObject.Find("Canvas").GetComponent<ScoreController>().GetScore();
        Delete();
        Draw(m_number);
    }
}
