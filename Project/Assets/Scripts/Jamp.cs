using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamp : MonoBehaviour
{
    //Animator animator;
    float rotSpeed = 0;
	// Use this for initialization
	void Start ()
    {
        //this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetResultFlag())
        {
            if (!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetTutorialFlag())
            {
                GetComponent<Rigidbody2D>().gravityScale = 1;

                if (Input.GetMouseButtonDown(0))
                {
                    this.rotSpeed = -this.rotSpeed;
                    GetComponent<Rigidbody2D>().velocity = (Vector2.up * 5);
                    GetComponent<AudioSource>().Play();
                }

                if (this.rotSpeed > 5.0f || this.rotSpeed < -5.0f)
                {
                    this.rotSpeed = 0;
                }
                else
                {
                    this.rotSpeed += -0.1f;
                }
                transform.Rotate(0, 0, this.rotSpeed);
            }
            else
            {
                GetComponent<Rigidbody2D>().gravityScale = 0;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 4;
            GetComponent<Animator>().enabled = false;
        }
        
        if(transform.position.y>=5)
        {
            GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().FinishPlay();
        }
        
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().FinishPlay();
    }

}
