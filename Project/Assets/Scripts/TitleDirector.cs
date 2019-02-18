using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(GameObject.Find("StartButtonPrefab").GetComponent<ButtonController>().GetPushFlag())
        {
            SceneManager.LoadScene("Scenes/PlayScene");
        }
	}
}
