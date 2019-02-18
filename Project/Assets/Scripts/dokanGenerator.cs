using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokanGenerator : MonoBehaviour
{
    public GameObject dokanoya;
    float span = 1.2f;
    float delta = 0;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetResultFlag())
        {
            if (!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetTutorialFlag())
            {
                this.delta += Time.deltaTime;
                if (this.delta > this.span)
                {
                    this.delta = 0;
                    GameObject go = Instantiate(dokanoya) as GameObject;
                    float px = Random.Range(-1.0f, 3);
                    go.transform.position = new Vector3(3.0f, px, 0);
                }
            }
        }          
	}

}
