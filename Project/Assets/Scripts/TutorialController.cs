using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);

            GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().FinishTutorial();
        }
	}
}
