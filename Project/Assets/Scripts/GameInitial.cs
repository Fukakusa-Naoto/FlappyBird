using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitial
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        Screen.SetResolution(620, 1280, false, 60);

    }
}
