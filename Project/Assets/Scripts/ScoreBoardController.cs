using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetResultFlag())
        {
            //ボードを上げる
            transform.Translate(0, 1.0f, 0);
            //ストップ
            if (transform.position.y > 1)
            {
                transform.Translate(0, -1.0f, 0);
            }
        }
	}
}
