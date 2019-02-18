using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : SpriteNumber
{

	// Use this for initialization
	void Start ()
    {
        m_number = PlayerPrefs.GetInt("HighScore", 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Delete();
        Draw(m_number);

        if (GameObject.Find("ResultPrefab/OK").GetComponent<ButtonController>().GetPushFlag())
        {
            if (m_number < GameObject.Find("Canvas").GetComponent<ScoreController>().GetScore())
            {
                PlayerPrefs.SetInt("HighScore", GameObject.Find("Canvas").GetComponent<ScoreController>().GetScore());
                PlayerPrefs.Save();
            }
        }
    }
}
