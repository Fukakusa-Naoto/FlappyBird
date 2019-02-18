using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DokanController : MonoBehaviour
{
    public GameObject dokanPrefab;
    float speed = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetResultFlag())
        {
            this.speed = -0.05f;
            //左に1動かす
            transform.Translate(this.speed, 0, 0);

            if (transform.position.x < -12.0f)
            {
                Destroy(dokanPrefab);
            }
        }
            
    }
}
