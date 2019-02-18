using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontGroundController : MonoBehaviour
{
    float loopPoint = -3.0f;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(GameObject.Find("PlayDirectorPrefab"))
        {
            if (!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetResultFlag())
            {
                transform.Translate(-0.05f, 0, 0);

                if (transform.position.x < loopPoint)
                {
                    transform.position = new Vector3(-loopPoint, -4, 0);
                }
            }
        }
        else if(GameObject.Find("TitleDirectorPrefab"))
        {
            transform.Translate(-0.05f, 0, 0);

            if (transform.position.x < loopPoint)
            {
                transform.position = new Vector3(-loopPoint, -4, 0);
            }
        }
    }

}
