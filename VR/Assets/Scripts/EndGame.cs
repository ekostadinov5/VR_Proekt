﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("startAgainMenu");
    }
}
